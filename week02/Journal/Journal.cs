public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public string SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"Date: {item._date} - Prompt: {item._promptText} - Answer: {item._entryText} - From: {item._name}");
            }
        }

        return $"Your journal has been saved successfully to '{file}'";
    }

    public string LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) { continue; }

            // Expected format:
            // Time: [date] - Prompt: [prompt] - Answer: [entry]
            string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
            if (parts.Length < 3) { continue; }

            string date = parts[0].Replace("Date: ", "").Trim();
            string prompt = parts[1].Replace("Prompt: ", "").Trim();
            string answer = parts[2].Replace("Answer: ", "").Trim();
            string name = parts[3].Replace("From: ", "").Trim();

            Entry entry = new Entry
            {
                _date = date,
                _promptText = prompt,
                _entryText = answer,
                _name = name
            };

            _entries.Add(entry);
        }

        return $"Your journal has been loaded sucessfully from '{file}'";
    }
}
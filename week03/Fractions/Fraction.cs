public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int inputTopValue, int inputBottomValue)
    {
        _top = inputTopValue;
        _bottom = inputBottomValue;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int inputTopValue)
    {
        _top = inputTopValue;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int inputBottomValue)
    {
        _bottom = inputBottomValue;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetFractionValue()
    {
        return (double)_top / _bottom;
    }
}
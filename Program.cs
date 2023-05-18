using System;

//Created class to hold fraction
public class Fraction
{   
    //_top : int
    //_bottom : int
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //Constructor that has no parameters that initializes the number to 1/1
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }


    //Constructor that has one parameter for the top and that initializes the denominator to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
//GetFractionString() : string
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.

        string text = $"{_top}/{_bottom}";
        return text;
    }

//GetDecimalValue() : double
    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}

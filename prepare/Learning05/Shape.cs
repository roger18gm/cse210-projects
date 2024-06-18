using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public abstract class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }
    public string GetColor()
    {
        return this.color;
    }
    public void SetColor(string value)
    {
        this.color = value;
    }
    public abstract double GetArea();
}
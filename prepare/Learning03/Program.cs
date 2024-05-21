using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Fraction fractionTwo = new Fraction(5);
        Fraction fractionThree = new Fraction(3,4);
        Fraction fractionFour = new Fraction(1,3);

       
        fractionOne.GetFractionString();
        Console.WriteLine(fractionOne.GetDecimalValue()); 

        
        fractionTwo.GetFractionString();  
        Console.WriteLine(fractionTwo.GetDecimalValue()); 

       
        fractionThree.GetFractionString();
        Console.WriteLine(fractionThree.GetDecimalValue()); 

        
        fractionFour.GetFractionString();          
        Console.WriteLine(fractionFour.GetDecimalValue()); 
    }
}
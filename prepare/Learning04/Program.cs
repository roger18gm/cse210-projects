using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Weezy F. Baby","Fractions");
        myAssignment.GetSummary();

        MathAssignment myMath = new MathAssignment("Peter Johnson", "pemdas","7.8","21-24,27");
        myMath.GetSummary();
        myMath.GetHomeworkList();
        
        WritingAssignment myWriting = new WritingAssignment("Roger Galan","Kentucky History","Divison from south and north");
        myWriting.GetSummary();
        myWriting.GetWritingInfo();

    }
}
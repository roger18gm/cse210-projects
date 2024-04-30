using System;
using Internal;
using Microsoft.CodeAnalysis.Scripting.Hosting;
// using Internal; /* equivalent to System */
// dotnet script .\demo.csx
// .csx is a c# script type

// Console.WriteLine("Hello World!");
// Console.WriteLine("Hello, what is your name?");

// string name = Console.ReadLine();
// Console.WriteLine($"Hello, {name}!");

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());
//float floatAge = float.Parse(Console.ReadLine());

for (int i = 1, i <= 5; i++) // a+=2 a--
{
    Console.WriteLine(i);
}
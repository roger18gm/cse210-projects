using System;
// using Internal; /* equivalent to System */
// dotnet script .\demo.csx
// .csx is a c# script type

Console.WriteLine("Hello World!");
Console.WriteLine("Hello, what is your name?");

string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
using ProjectEuler;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

var problem = new Problem04();
Console.WriteLine($"Solving problem {problem.Index}...");
Console.WriteLine($"Solution: {problem.Solve()}");
using ProjectEuler;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

var problem = new Problem07();
Console.WriteLine($"Solving problem {problem.Index}...");
Console.WriteLine($"Solution: {problem.Solve(10001)}");
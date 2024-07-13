using ProjectEuler.Problems_00;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

var problem = new Problem_07();
Console.WriteLine($"Solving problem {problem.Index}...");
Console.WriteLine($"Solution: {problem.Solve(10001)}");
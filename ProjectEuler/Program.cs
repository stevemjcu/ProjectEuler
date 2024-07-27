using System.Diagnostics;
using System.Runtime.CompilerServices;
using ProjectEuler.Problems;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

var problem = new Problem_0027();
var stopwatch = new Stopwatch();

Console.WriteLine($@"Solving problem {problem.Index}...");

stopwatch.Start();
var solution = problem.Solve();
stopwatch.Stop();

Console.WriteLine($@"Solution: {solution}");
Console.WriteLine($@"Time: {stopwatch.ElapsedMilliseconds} ms");
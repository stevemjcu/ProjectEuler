using ProjectEuler.Problems;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

var problem = new Problem_0050();
var stopwatch = new Stopwatch();

Console.WriteLine($@"Solving problem {problem.Index}...");

stopwatch.Start();
var solution = problem.Solve();
stopwatch.Stop();

Console.WriteLine($@"Solution: {solution}");
Console.WriteLine($@"Time: {stopwatch.ElapsedMilliseconds} ms");
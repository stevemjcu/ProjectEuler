using ProjectEuler.Problems;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

Console.WriteLine("Solving...");
var sw = new Stopwatch();
sw.Start();
Console.WriteLine($"Answer: {new Problem_0005().Solve()}");
sw.Stop();
Console.WriteLine($"Time: {sw.ElapsedMilliseconds} ms");
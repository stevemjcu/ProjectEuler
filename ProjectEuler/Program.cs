using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.Tests")]

namespace ProjectEuler
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var type = Assembly
				.GetExecutingAssembly()
				.GetTypes()
				.Where(t => t.Namespace is not null && t.Namespace.EndsWith(args[0]))
				.Where(t => t.Name.EndsWith(args[1]))
				.First();

			var problem = (Problem?)Activator.CreateInstance(type)
				?? throw new Exception("Problem not found");

			Console.WriteLine($"Solving problem {problem.Index}...");
			Console.WriteLine($"Solution: {problem.Solve(args[2])}");
		}
	}
}
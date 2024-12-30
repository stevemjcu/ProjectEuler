namespace ProjectEuler.Problems;

public class Problem_0062 : Problem
{
	public const int N = 5;
	public const int M = 10000;

	/// <returns>The smallest cube where exactly N permutations of its digits are cube.</returns>
	public override object Solve()
	{
		// Enumerate M cubes
		// Select base permutation of each cube
		// Find count of each base permutation
		// Find first cube whose base permutation has a count of N

		var cubes = Enumerable.Range(1, M).Select(n => (long)n * n * n).ToList();
		var lookup = cubes.ToLookup(GetBasePermutation); // base : cubes
		return cubes.First(c => lookup[GetBasePermutation(c)].Count() == N);
	}

	private static string GetBasePermutation(long n)
	{
		var sorted = n.ToString().ToList();
		sorted.Sort();
		return string.Concat(sorted);
	}
}
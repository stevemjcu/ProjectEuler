namespace ProjectEuler.Problems;

public class Problem_0023 : Problem
{
	public int Max = 28123;

	/// <returns>The sum of all positive integers which are not the sum of two abundant numbers.</returns>
	public override object Solve()
	{
		var sums = new HashSet<int>();
		var numbers = Enumerable
			.Range(1, Max)
			.Where(IsAbundant)
			.ToList();

		foreach (var i in numbers)
		{
			foreach (var j in numbers)
			{
				sums.Add(i + j);
			}
		}

		return Enumerable
			.Range(1, Max)
			.ToHashSet()
			.Except(sums)
			.Sum();
	}

	/// <returns>True if n is abundant; otherwise, false.</returns>
	public static bool IsAbundant(int n)
	{
		return Problem_0021.GetProperFactors(n).Sum() > n;
	}
}
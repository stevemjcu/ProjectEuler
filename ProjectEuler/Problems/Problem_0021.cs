namespace ProjectEuler.Problems;

public class Problem_0021 : Problem
{
	public int N = 10000;

	/// <returns>The sum of all amicable numbers under N.</returns>
	public override object Solve()
	{
		return GetAmicableNumbers(N).Sum();
	}

	/// <returns>The numbers under n which are in an amicable pair.</returns>
	public static IEnumerable<int> GetAmicableNumbers(int n)
	{
		var sums = new Dictionary<int, int>();
		for (var i = 1; i <= n; i++)
		{
			sums[i] = (int)GetProperFactors(i).Sum();
		}
		foreach (var (a, b) in sums)
		{
			if (a != b && sums.TryGetValue(b, out var c) && c == a)
			{
				yield return a;
			}
		}
	}

	/// <returns>The proper factors of n.</returns>
	public static IEnumerable<long> GetProperFactors(long n)
	{
		return Problem_0003.GetFactors(n).ToList()[..^1];
	}
}
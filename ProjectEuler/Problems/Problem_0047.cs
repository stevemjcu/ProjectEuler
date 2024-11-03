namespace ProjectEuler.Problems;

public class Problem_0047 : Problem
{
	public int N = 4;
	public int M = 1000000;

	/// <returns>The first of N consecutive integers to each have four distinct prime factors.</returns>
	public override object Solve()
	{
		var counts = Enumerable.Range(1, M).Select(CountDistinctPrimeFactors1).ToArray();
		var i = 1;
		foreach (var window in Utils.GetSlidingWindows(counts, N))
		{
			if (window.All(c => c == N)) return i;
			i++;
		}
		return 0;
	}

	public static int CountDistinctPrimeFactors1(int i)
	{
		var set = new HashSet<long>();
		Utils.GetDistinctPrimeFactors(i, set);
		return set.Count;
	}

	public static int CountDistinctPrimeFactors2(int i)
	{
		return Utils.GetPrimeFactors(i).ToHashSet().Count;
	}
}
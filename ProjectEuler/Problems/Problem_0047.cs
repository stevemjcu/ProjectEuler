namespace ProjectEuler.Problems;

public class Problem_0047 : Problem
{
	public int N = 4;
	public int M = 1000000;

	/// <returns>The first of N consecutive integers to each have four distinct prime factors.</returns>
	public override object Solve()
	{
		var arr = Enumerable
			.Range(1, M)
			.Select(i => Utils.GetDistinctPrimeFactors(i).Count)
			.ToArray();

		var i = 1;
		foreach (var window in arr.GetSlidingWindows(N))
		{
			if (window.All(t => t == N)) return i;
			i++;
		}
		return 0;
	}
}
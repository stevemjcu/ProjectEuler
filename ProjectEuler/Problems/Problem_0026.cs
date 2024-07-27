namespace ProjectEuler.Problems;

internal class Problem_0026 : Problem
{
	public int N = 1000;

	/// <returns>The value under N with the longest recurring cycle in its reciprocal's decimal fraction.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N - 1)
			.MaxBy(i => GetRecurringCycleLength(1, i));
	}

	/// <returns>The length of the recurring cycle in the quotient's decimal fraction.</returns>
	public static int GetRecurringCycleLength(int a, int b)
	{
		// Divide until remainder reoccurs
		var cache = new Dictionary<int, int>();
		for (var i = 0; a > 0; i++)
		{
			if (cache.TryGetValue(a, out var j))
			{
				return i - j;
			}
			cache[a] = i;
			while (a < b)
			{
				a *= 10;
			}
			a %= b;
		}
		return 0; // no cycle
	}
}
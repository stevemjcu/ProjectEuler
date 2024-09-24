namespace ProjectEuler.Problems;

internal class Problem_0031 : Problem
{
	public int N = 200;
	public static List<int> coins = [1, 2, 5, 10, 20, 50, 100, 200];

	/// <returns>The number of different ways N pence can be made using any number of coins.</returns>
	public override object Solve()
	{
		coins.Reverse();
		return GetWays(N, coins, []);
	}

	public static int GetWays(
		int n,
		IEnumerable<int> units,
		Dictionary<(int, int), int> cache)
	{
		if (n == 0) return 0;
		if (cache.TryGetValue((n, units.First()), out var value)) return value;

		var count = 0;
		units = units.Where(x => x <= n);
		foreach (var u in units)
			if (u == n) count++;
			else count += GetWays(n - u, units.Where(x => x <= u), cache);

		cache[(n, units.First())] = count;
		return count;
	}
}


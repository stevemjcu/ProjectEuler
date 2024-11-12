namespace ProjectEuler.Problems;

public class Problem_0044 : Problem
{
	public int N = 5000;

	/// <returns>The distance between the closest pair of pentagonal numbers whose sum and difference are also pentagonal.</returns>
	public override object Solve()
	{
		return GetPentagonalPairs(N).Select(a => a.Item2 - a.Item1).First();
	}

	/// <returns>The sequence of pentagonal numbers with indices under n and whose sum and difference are also pentagonal.</returns>
	public static IEnumerable<(int, int)> GetPentagonalPairs(int n)
	{
		var map = Enumerable.Range(1, n).Select(GetPentagonalNumber).ToArray();
		var set = map.ToHashSet();
		for (var i = 0; ; i++)
		{
			var a = map[i];
			for (var j = i + 1; j < n - 1; j++)
			{
				var b = map[j];
				if (a + b < map[j + 1]) break;
				if (set.Contains(a + b) && set.Contains(b - a)) yield return (a, b);
			}
		}
	}

	/// <returns>The pentagonal numbers given by x = n(3n-1)/2.</returns>
	public static int GetPentagonalNumber(int n)
	{
		return n * (3 * n - 1) / 2;
	}

	/// <returns>True if x = n(3n-1)/2 for some positive integer n; otherwise, false.</returns>
	public static bool IsPentagonalNumber(int x)
	{
		// x = n(3n-1)/2 => 0 = 3n^2 - n - 2x
		return double.IsInteger(Utils.SolveQuadratic(3, -1, -2d * x).Item1);
	}
}
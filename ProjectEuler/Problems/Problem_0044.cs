namespace ProjectEuler.Problems;

public class Problem_0044 : Problem
{
	public int N = 1000;

	/// <returns>The distance between the closest pair of pentagonal numbers whose sum and difference are also pentagonal.</returns>
	public override object Solve()
	{
		return GetPentagonalPairs().Select(a => a.Item2 - a.Item1).First();
	}

	public static IEnumerable<(long, long)> GetPentagonalPairs()
	{
		for (var i = 1; i < 2000; i++)
		{
			var a = GetPentagonalNumber(i);
			for (var j = i + 1; ; j++)
			{
				var b = GetPentagonalNumber(j);
				var c = GetPentagonalNumber(j + 1);
				if (IsPentagonal(a + b) && IsPentagonal(b - a)) yield return (a, b);
				if (a + b < c) break;
			}
		}
	}

	/// <returns>True if x = (1/2)n(3n-1) for some integer n; otherwise, false.</returns>
	public static bool IsPentagonal(long p)
	{
		return double.IsInteger(Utils.SolveQuadratic(3, -1, -2 * p).Item1);
	}


	/// <returns>The triangle numbers given by x = (1/2)n(3n-1).</returns>
	public static long GetPentagonalNumber(long n)
	{
		return n * (3 * n - 1) / 2;
	}

	/// <returns>The sequence of triangle numbers given by x = (1/2)n(3n-1).</returns>
	public static IEnumerable<long> GetPentagonalNumbers()
	{
		// TODO: Implement pairwise enumeration in Utils?
		for (var i = 1; ; i++)
		{
			yield return GetPentagonalNumber(i);
		}
	}
}
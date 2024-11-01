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
		for (var i = 1; ; i++)
		{
			var a = GetPentagonalNumber(i);
			var b = GetPentagonalNumber(i + 1);
			var c = GetPentagonalNumber(i + 2);
			for (var j = i + 2; a + b > c; j++, b = c, c = GetPentagonalNumber(j))
			{
				if (IsPentagonalNumber(a + b) && IsPentagonalNumber(b - a))
					yield return (a, b);
			}
		}
	}

	/// <returns>True if x = n(3n-1)/2 for some positive integer n; otherwise, false.</returns>
	public static bool IsPentagonalNumber(long x)
	{
		// x = n(3n-1)/2 => 0 = 3n^2 - n - 2x
		return double.IsInteger(Utils.SolveQuadratic(3, -1, -2 * x).Item1);
	}


	/// <returns>The triangle numbers given by x = n(3n-1)/2.</returns>
	public static long GetPentagonalNumber(long n)
	{
		return n * (3 * n - 1) / 2;
	}
}
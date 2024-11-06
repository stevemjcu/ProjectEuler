namespace ProjectEuler.Problems;

public class Problem_0048 : Problem
{
	public int N = 1000;
	public const long M = (long)1e10;

	/// <returns>The last 10 digits of the summation of the series n^n for n = [1, N].</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N)
			.Select(i => Power(i, i, M))
			.Sum() % M;
	}

	/// <returns>The truncated value of a raised to the power of b.</returns>
	public static long Power(int a, int b, long limit)
	{
		var res = (long)a;
		for (var i = 1; i < b; i++)
		{
			res = res * a % limit;
		}
		return res;
	}
}
namespace ProjectEuler.Problems;

public class Problem_0012 : Problem
{
	public long N = 500;

	/// <returns>The first triangle number to have over N divisors.</returns>
	public override object Solve()
	{
		return GetTriangleNumbers()
			.First(n => Problem_0003.GetFactors(n).Count() > N);
	}

	public static IEnumerable<int> GetTriangleNumbers()
	{
		for (var (i, acc) = (1, 0);; i++)
		{
			acc += i;
			yield return acc;
		}
	}
}
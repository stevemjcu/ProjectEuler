using System.Numerics;

namespace ProjectEuler.Problems;

public class Problem_0053 : Problem
{
	public int N = 100;
	public int M = 1000000;

	/// <returns>The number of ways you can select r from n, where n = 1..N, which exceed M.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N)
			.Select(GenerateCombinations)
			.Select(l => l.Count(e => e > M))
			.Sum();
	}

	/// <returns>The sequence created from the number of ways you can select r from n where r = 1..n.</returns>
	public static IEnumerable<BigInteger> GenerateCombinations(int n)
	{
		for (var r = 1; r <= n; r++)
			yield return CountCombinations(new(n), new(r));
	}

	/// <returns>The number of ways you can select r from n.</returns>
	public static BigInteger CountCombinations(BigInteger n, BigInteger r)
	{
		// n! / (r!(n - r)!)
		var a = Utils.Factorial(n);
		var b = Utils.Factorial(r);
		var c = Utils.Factorial(n - r);
		return a / (b * c);
	}
}
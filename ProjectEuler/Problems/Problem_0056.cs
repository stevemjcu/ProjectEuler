using System.Numerics;

namespace ProjectEuler.Problems;

public class Problem_0056 : Problem
{
	public int N = 100;

	/// <returns>The largest digital sum of a^b where a and b are natural numbers under N.</returns>
	public override object Solve()
	{
		return GenerateSequence(N).Max(SummateDigits);
	}

	private static IEnumerable<BigInteger> GenerateSequence(int n)
	{
		for (var i = 0; i < n; i++)
			for (var j = 0; j < n; j++)
				yield return BigInteger.Pow(i, j);
	}

	private static int SummateDigits(BigInteger n)
	{
		return n
			.ToString()
			.Select(i => i.ToString())
			.Sum(int.Parse);
	}
}
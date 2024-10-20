using System.Numerics;

namespace ProjectEuler.Problems;

public class Problem_0020 : Problem
{
	public int N = 100;

	/// <returns>The sum of the digits in the factorial of N.</returns>
	public override object Solve()
	{
		return Factorial(new BigInteger(N))
			.ToString()
			.Select(c => int.Parse(c.ToString()))
			.Sum();
	}

	/// <returns>The factorial of N.</returns>
	public static T Factorial<T>(T n) where T : struct, INumber<T>
	{
		return Utils
			.Range(T.One, n)
			.Aggregate(T.One, (acc, i) => acc * i);
	}
}
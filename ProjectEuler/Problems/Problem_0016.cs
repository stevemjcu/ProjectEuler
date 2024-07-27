using System.Numerics;

namespace ProjectEuler.Problems;

public class Problem_0016 : Problem
{
	public int N = 1000;

	/// <returns>The sum of the digits of 2 raised to the N power.</returns>
	public override object Solve()
	{
		return Enumerable
			.Repeat(new BigInteger(2), N)
			.Product()
			.ToString()
			.Select(c => int.Parse(c.ToString()))
			.Sum();
	}
}
using System.Numerics;

namespace ProjectEuler.Problems;

public class Problem_0055 : Problem
{
	public int N = 10000;
	public int M = 50;

	/// <returns>The number of Lychrel numbers below N.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N - 1)
			.Count(i => IsLychrelNumber(i, M));
	}

	/// <returns>True if n never forms a palindrome by adding its reverse iteratively; otherwise, false.</returns>
	public static bool IsLychrelNumber(BigInteger n, int limit)
	{
		for (var i = 0; i < limit; i++)
		{
			n += Reverse(n);
			if (Utils.IsPalindrome(n.ToString())) return false;
		}
		return true;
	}

	/// <returns>The reverse of the number n.</returns>
	public static BigInteger Reverse(BigInteger n)
	{
		var m = BigInteger.Zero;
		for (; n > 0; n /= 10)
			m = (m * 10) + n % 10;
		return m;
	}
}
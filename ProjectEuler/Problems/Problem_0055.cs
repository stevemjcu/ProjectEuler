using System.Numerics;

namespace ProjectEuler.Problems;

public class Problem_0055 : Problem
{
	public int N = 10000;
	public const int M = 50;

	/// <returns>The number of Lychrel numbers below N.</returns>
	public override object Solve()
	{
		return Enumerable.Range(1, N).Count(IsLychrelNumber);
	}

	/// <returns>True if n never forms a palindrome by adding its reverse iteratively; otherwise, false.</returns>
	public static bool IsLychrelNumber(int n) => IsLychrelNumber(n, 1);

	private static bool IsLychrelNumber(BigInteger n, int count)
	{
		n += Reverse(n);
		if (Utils.IsPalindrome(n.ToString())) return false;
		if (++count >= M) return true;
		return IsLychrelNumber(n, count);
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
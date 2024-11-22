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
			n += n.Reverse();
			if (Utils.IsPalindrome(n.ToString())) return false;
		}
		return true;
	}
}
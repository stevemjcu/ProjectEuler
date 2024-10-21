namespace ProjectEuler.Problems;

public class Problem_0037 : Problem
{
	/// <returns>The sum of the 11 prime numbers which remain prime when truncated from the left or right.</returns>
	public override object Solve()
	{
		var primes = Utils.Range(1, null).Where(Utils.IsPrime);
		return primes.Where(IsTruncatablePrime).Take(11).Sum();
	}

	/// <returns>True if the number x remains prime when truncated from the left or right.</returns>
	public static bool IsTruncatablePrime(int x)
	{
		// 2, 3, 5, and 7 are not considered truncatable primes
		return x > 10 && GetTruncations(x).All(Utils.IsPrime);
	}

	/// <returns>A sequence that contains the left to right truncations of the number n.</returns>
	public static IEnumerable<int> GetTruncations(int x)
	{
		var digits = Utils.ToDigits(x);
		for (var i = 0; i < digits.Count; i++)
			yield return Utils.FromDigits(digits[i..]);
		for (var i = digits.Count; i > 0; i--)
			yield return Utils.FromDigits(digits[..i]);
	}
}
namespace ProjectEuler.Problems;

public class Problem_0046 : Problem
{
	public int N = 10000;

	/// <returns>The smallest odd composite number which is not the sum of a prime and twice a square.</returns>
	public override object Solve()
	{
		var range = Enumerable.Range(2, N).ToList(); // 1 doesn't count
		var candidates = range.Where(i => int.IsOddInteger(i) && !Utils.IsPrime(i));
		var primes = range.Where(Utils.IsPrime).ToList();
		return candidates.First(i => !AssertGoldbachConjecture(i, primes));
	}

	/// <returns>True if the number x is twice a square; otherwise, false.</returns>
	public static bool IsTwiceASquare(int x)
	{
		// x = 2 * n^2 => sqrt(x/2) = n
		return double.IsInteger(Math.Sqrt(x / 2.0));
	}

	/// <returns>True if the odd composite number x is the sum of a prime and twice a square; otherwise, false.</returns>
	public static bool AssertGoldbachConjecture(int x, List<int> primes)
	{
		return primes.TakeWhile(p => p < x).Any(p => IsTwiceASquare(x - p));
	}
}
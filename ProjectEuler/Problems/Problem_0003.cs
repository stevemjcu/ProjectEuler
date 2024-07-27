namespace ProjectEuler.Problems;

public class Problem_0003 : Problem
{
	public long N = 600851475143;

	/// <returns>The largest prime factor of N.</returns>
	public override object Solve()
	{
		return GetFactors(N)
			.Reverse()
			.First(IsPrime);
	}

	/// <returns>True if n is prime; otherwise, false.</returns>
	public static bool IsPrime(long n)
	{
		for (var i = 2L; i <= (long)Math.Sqrt(n); i++)
		{
			if (n % i == 0)
			{
				return false;
			}
		}
		return n != 1;
	}

	/// <returns>True if n is prime; otherwise, false.</returns>
	public static bool IsPrime(int n)
	{
		// TODO: Genericize (unless much slower)?
		return IsPrime((long)n);
	}

	/// <returns>A sequence that contains the factors of n in ascending order.</returns>
	public static IEnumerable<long> GetFactors(long n)
	{
		var factors = new Stack<long>();
		for (var i = 1L; i <= (long)Math.Sqrt(n); i++)
		{
			if (n % i == 0)
			{
				yield return i;
				factors.Push(i);
			}
		}
		foreach (var f in factors)
		{
			if (n / f != f)
			{
				yield return n / f;
			}
		}
	}
}
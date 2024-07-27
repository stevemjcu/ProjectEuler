namespace ProjectEuler.Problems;

public class Problem_0035 : Problem
{
	public int N = 1000000;

	/// <returns>The number of circular primes below N.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N - 1)
			.Where(Problem_0003.IsPrime)
			.Count(IsCircularPrime);
	}

	/// <returns>True if all rotations of n are prime; otherwise, false.</returns>
	public static bool IsCircularPrime(int n)
	{
		for (var i = 0; i < n.ToString().Length; i++)
		{
			if (!Problem_0003.IsPrime(RotateLeft(n, i)))
			{
				return false;
			}
		}
		return true;
	}

	/// <returns>The rotation of n by the given amount.</returns>
	public static int RotateLeft(int n, int amount)
	{
		var length = n.ToString().Length;
		for (var i = 0; i < amount; i++)
		{
			var factor = (int)Math.Pow(10, length - 1);
			var a = n / factor;
			var b = n % factor;
			n = b * 10 + a;
		}
		return n;
	}
}
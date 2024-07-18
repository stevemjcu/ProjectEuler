﻿namespace ProjectEuler.Problems
{
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
			// LINQ version:
			//return n != 1 && !GetFactors(n).Any(f => f != 1 && f != n);

			for (int i = 2; i <= (int)Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return n != 1;
		}

		/// <returns>A sequence that contains the factors of n.</returns>
		public static IEnumerable<long> GetFactors(long n)
		{
			// TODO: Speed up!

			var factors = Utilities
				.Range(1L, (long)Math.Sqrt(n) - 1)
				.Where(i => n % i == 0);

			var copy = new Stack<long>();
			foreach (var f in factors)
			{
				yield return f;
				copy.Push(f);
			}
			foreach (var f in copy)
			{
				if (n / f != f)
				{
					yield return n / f;
				}
			}
		}
	}
}
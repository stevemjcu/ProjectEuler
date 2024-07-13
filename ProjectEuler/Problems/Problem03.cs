namespace ProjectEuler
{
	internal class Problem03 : Problem<long>
	{
		/// <returns>The largest prime factor of n.</returns>
		public override long Solve(long n)
		{
			return GetFactors(n).Reverse().First(IsPrime);
		}

		/// <returns>True if n is prime; otherwise, false.</returns>
		public static bool IsPrime(long n)
		{
			return n != 1 && !GetFactors(n).Any(f => f != 1 && f != n);
		}

		/// <returns>A sequence that contains the factors of n.</returns>
		public static IEnumerable<long> GetFactors(long n)
		{
			var factors = Utilities
				.Range(1L, (long)Math.Sqrt(n) - 1)
				.Where(i => n % i == 0);

			foreach (var f in factors)
			{
				yield return f;
			}
			foreach (var f in factors.Reverse())
			{
				if (n / f != f)
				{
					yield return n / f;
				}
			}
		}
	}
}

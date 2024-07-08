namespace ProjectEuler
{
	internal class Problem03 : Problem<long>
	{
		public Problem03() => N = 600851475143;

		/// <returns>The largest prime factor of N.</returns>
		public override long Solve()
		{
			return GetFactors(N).Reverse().First(IsPrime);
		}

		/// <returns>True if n is prime; otherwise, false.</returns>
		public static bool IsPrime(long n)
		{
			return !GetFactors(n).Any(f => f != 1 && f != n);
		}

		/// <returns>A sequence that contains the factors of n.</returns>
		public static IEnumerable<long> GetFactors(long n)
		{
			var factors = Utilities.LongRange(1, (long)Math.Sqrt(n) - 1).Where(i => n % i == 0);

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

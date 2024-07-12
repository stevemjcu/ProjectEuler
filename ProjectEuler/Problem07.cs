namespace ProjectEuler
{
	internal class Problem07 : Problem<int>
	{
		public Problem07() => N = 10001;

		/// <returns>The Nth prime number.</returns>
		public override int Solve()
		{
			return GetPrimes(N).Last();
		}

		/// <returns>A sequence that contains the prime numbers up to and including n.</returns>
		public static IEnumerable<int> GetPrimes(int n)
		{
			for (var (i, j) = (1, 0); j < n; i++)
			{
				if (Problem03.IsPrime(i))
				{
					yield return i;
					j++;
				}
			}
		}
	}
}

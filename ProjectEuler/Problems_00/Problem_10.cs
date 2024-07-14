namespace ProjectEuler.Problems_00
{
	internal class Problem_10 : Problem
	{
		public long N = 2000000;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The sum of all the primes below N.</returns>
		public long SolveInternal()
		{
			return Utilities
				.Range(1L, N - 1L)
				.Where(Problem_03.IsPrime)
				.Sum();
		}
	}
}

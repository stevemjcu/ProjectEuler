namespace ProjectEuler.Problems
{
	public class Problem_10 : Problem
	{
		public long N = 2000000;

		/// <returns>The sum of all the primes below N.</returns>
		public override string Solve()
		{
			return Utilities
				.Range(1L, N - 1)
				.Where(Problem_03.IsPrime)
				.Sum()
				.ToString();
		}
	}
}

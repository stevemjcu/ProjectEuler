namespace ProjectEuler.Problems
{
	public class Problem_0010 : Problem
	{
		public long N = 2000000;

		/// <returns>The sum of all the primes below N.</returns>
		public override string Solve()
		{
			return Utilities
				.Range(1L, N - 1)
				.Where(Problem_0003.IsPrime)
				.Sum()
				.ToString();
		}
	}
}

namespace ProjectEuler.Problems
{
	public class Problem_0007 : Problem
	{
		public int N = 10001;

		/// <returns>The Nth prime number.</returns>
		public override string Solve()
		{
			return Utilities
				.Range(1, null)
				.Where(x => Problem_0003.IsPrime(x))
				.Take(N)
				.Last()
				.ToString();
		}
	}
}

namespace ProjectEuler.Problems
{
	public class Problem_0001 : Problem
	{
		public int N = 1000;

		/// <returns>The sum of the multiples of 3 or 5 below N.</returns>
		public override string Solve()
		{
			return Enumerable
				.Range(0, N)
				.Where(i => i % 3 == 0 || i % 5 == 0)
				.Sum()
				.ToString();
		}
	}
}

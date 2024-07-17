namespace ProjectEuler.Problems
{
	public class Problem_0001 : Problem
	{
		public int N = 1000;

		/// <returns>The sum of the multiples of 3 or 5 below N.</returns>
		public override object Solve() => SolveLoop();

		public int SolveLinq()
		{
			return Enumerable
				.Range(0, N)
				.Where(i => i % 3 == 0 || i % 5 == 0)
				.Sum();
		}

		public int SolveLoop()
		{
			var acc = 0;
			for (int i = 0; i < N; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					acc += i;
				}
			}
			return acc;
		}
	}
}

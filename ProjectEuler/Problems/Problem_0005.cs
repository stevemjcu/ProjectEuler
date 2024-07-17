namespace ProjectEuler.Problems
{
	public class Problem_0005 : Problem
	{
		public int N = 20;

		/// <returns>The smallest positive number whose factors include 1 through N.</returns>
		public override object Solve() => SolveLoop();

		public int SolveLinq()
		{
			return Enumerable
				.Range(1, int.MaxValue)
				.First(i => Enumerable.Range(1, N).All(j => i % j == 0));
		}

		public int SolveLoop()
		{
			for (int i = 1; ; i++)
			{
				for (int j = 1; j <= N; j++)
				{
					if (i % j != 0)
					{
						break;
					}
					if (j == N)
					{
						return i;
					}
				}
			}
		}
	}
}

namespace ProjectEuler.Problems_00
{
	internal class Problem_05 : Problem
	{
		public int N = 20;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The smallest positive number whose factors include 1 through N.</returns>
		public int SolveInternal()
		{
			for (int i = 1; ; i++)
			{
				if (Enumerable.Range(1, N).All(j => i % j == 0))
				{
					return i;
				}
			}
		}
	}
}

namespace ProjectEuler
{
	internal class Problem05 : Problem<int>
	{
		public Problem05() => N = 20;

		/// <returns>The smallest positive number whose factors include 1 through N.</returns>
		public override int Solve()
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

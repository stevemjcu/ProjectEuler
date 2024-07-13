namespace ProjectEuler.Problems_00
{
	internal class Problem_05 : Problem<int>
	{
		/// <returns>The smallest positive number whose factors include 1 through n.</returns>
		public override int Solve(int n)
		{
			for (int i = 1; ; i++)
			{
				if (Enumerable.Range(1, n).All(j => i % j == 0))
				{
					return i;
				}
			}
		}
	}
}

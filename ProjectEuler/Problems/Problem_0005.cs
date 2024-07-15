namespace ProjectEuler.Problems
{
	public class Problem_0005 : Problem
	{
		public int N = 20;

		/// <returns>The smallest positive number whose factors include 1 through N.</returns>
		public override string Solve()
		{
			for (int i = 1; ; i++)
			{
				if (Enumerable.Range(1, N).All(j => i % j == 0))
				{
					return i.ToString();
				}
			}
		}
	}
}

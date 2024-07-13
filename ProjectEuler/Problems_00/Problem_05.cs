namespace ProjectEuler.Problems_00
{
	internal class Problem_05 : Problem
	{
		public override string Solve(string n) => Solve(int.Parse(n)).ToString();

		/// <returns>The smallest positive number whose factors include 1 through n.</returns>
		public static int Solve(int n)
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

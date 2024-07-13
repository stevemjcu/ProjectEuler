namespace ProjectEuler.Problems_00
{
	internal class Problem_01 : Problem
	{
		public override string Solve(string n) => Solve(int.Parse(n)).ToString();

		/// <returns>The sum of the multiples of 3 or 5 below n.</returns>
		public static int Solve(int n)
		{
			return Enumerable.Range(0, n).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
		}
	}
}

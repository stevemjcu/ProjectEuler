namespace ProjectEuler.Problems_00
{
	internal class Problem_07 : Problem
	{
		public override string Solve(string n) => Solve(int.Parse(n)).ToString();

		/// <returns>The nth prime number.</returns>
		public static int Solve(int n)
		{
			return Utilities
				.Range(1, null)
				.Where(x => Problem_03.IsPrime(x))
				.Take(n)
				.Last();
		}
	}
}

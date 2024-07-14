namespace ProjectEuler.Problems_00
{
	internal class Problem_07 : Problem
	{
		public int N = 10001;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The Nth prime number.</returns>
		public int SolveInternal()
		{
			return Utilities
				.Range(1, null)
				.Where(x => Problem_03.IsPrime(x))
				.Take(N)
				.Last();
		}
	}
}

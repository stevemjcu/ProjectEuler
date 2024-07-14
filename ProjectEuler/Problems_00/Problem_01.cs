namespace ProjectEuler.Problems_00
{
	internal class Problem_01 : Problem
	{
		public int N = 1000;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The sum of the multiples of 3 or 5 below N.</returns>
		public int SolveInternal()
		{
			return Enumerable.Range(0, N).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
		}
	}
}

namespace ProjectEuler.Problems00xx
{
	internal class Problem01 : Problem<int>
	{
		/// <returns>The sum of the multiples of 3 or 5 below n.</returns>
		public override int Solve(int n)
		{
			return Enumerable.Range(0, n).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
		}
	}
}

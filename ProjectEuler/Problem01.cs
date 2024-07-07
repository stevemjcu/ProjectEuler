namespace ProjectEuler
{
	internal class Problem01 : Problem<int>
	{
		public Problem01() => N = 1000;

		/// <returns>Sum of multiples of 3 or 5 below N</returns>
		public override int Solve()
		{
			return Enumerable.Range(0, N).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
		}
	}
}

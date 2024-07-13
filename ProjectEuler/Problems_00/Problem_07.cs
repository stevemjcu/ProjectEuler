namespace ProjectEuler.Problems_00
{
	internal class Problem_07 : Problem<int>
	{
		/// <returns>The nth prime number.</returns>
		public override int Solve(int n)
		{
			return Utilities
				.Range(1, null)
				.Where(x => Problem_03.IsPrime(x))
				.Take(n)
				.Last();
		}
	}
}

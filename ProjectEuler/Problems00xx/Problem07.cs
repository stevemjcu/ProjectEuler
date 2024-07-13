namespace ProjectEuler.Problems00xx
{
	internal class Problem07 : Problem<int>
	{
		/// <returns>The nth prime number.</returns>
		public override int Solve(int n)
		{
			return Utilities
				.Range(1, null)
				.Where(x => Problem03.IsPrime(x))
				.Take(n)
				.Last();
		}
	}
}

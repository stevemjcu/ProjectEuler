namespace ProjectEuler
{
	internal class Problem07 : Problem<int>
	{
		public Problem07() => N = 10001;

		/// <returns>The Nth prime number.</returns>
		public override int Solve()
		{
			return Utilities
				.InfiniteRange(1)
				.Where(x => Problem03.IsPrime(x))
				.Take(N)
				.Last();
		}
	}
}

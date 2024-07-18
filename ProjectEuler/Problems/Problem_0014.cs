namespace ProjectEuler.Problems
{
	public class Problem_0014 : Problem
	{
		public int N = 1000000;

		/// <returns>The starting number under N whose Collatz sequence is the longest.</returns>
		public override object Solve()
		{
			return Utilities
				.Range(1, N - 1)
				.MaxBy(x => GetCollatzSequenceLength(x));
		}

		public static long GetCollatzSequenceLength(long n)
		{
			var i = 1L;
			for (; n != 1; i++)
			{
				if (n % 2 == 0)
				{
					n /= 2;
				}
				else
				{
					n = 3 * n + 1;
				}
			}
			return i;
		}
	}
}

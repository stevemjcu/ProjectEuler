namespace ProjectEuler.Problems_00
{
	internal class Problem_02 : Problem
	{
		public int N = 4000000;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The sum of the even Fibonacci terms below N.</returns>
		public int SolveInternal()
		{
			return GetFibonacciSequence(N).Where(x => x % 2 == 0).Sum();
		}

		/// <returns>A sequence that contains the Fibonacci terms below n.</returns>
		public static IEnumerable<int> GetFibonacciSequence(int n)
		{
			var (i, j) = (1, 2);
			while (true)
			{
				var k = i + j;
				if (i >= n)
				{
					break;
				}
				yield return i;
				(i, j) = (j, k);
			}
		}
	}
}

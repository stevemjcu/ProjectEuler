namespace ProjectEuler.Problems00xx
{
	internal class Problem02 : Problem<int>
	{
		/// <returns>The sum of the even Fibonacci terms below n.</returns>
		public override int Solve(int n)
		{
			return GetFibonacciSequence(n).Where(x => x % 2 == 0).Sum();
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

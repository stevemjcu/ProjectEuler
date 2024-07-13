namespace ProjectEuler.Problems_00
{
	internal class Problem_02 : Problem
	{
		public override string Solve(string n) => Solve(int.Parse(n)).ToString();

		/// <returns>The sum of the even Fibonacci terms below n.</returns>
		public static int Solve(int n)
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

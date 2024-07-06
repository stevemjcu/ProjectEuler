namespace ProjectEuler
{
	internal class Problem02 : Problem
	{
		public Problem02() => N = 4000000;

		/// <returns>Sum of even Fibonacci terms below N.</returns>
		public override int Solve()
		{
			return GetFibonacciSequence(N).FindAll(x => x % 2 == 0).Sum();
		}

		/// <returns>Fibonacci terms below n.</returns>
		public static List<int> GetFibonacciSequence(int n)
		{
			var terms = new List<int>() { 1, 2 };
			while (true)
			{
				var x = terms[^1] + terms[^2];
				if (x >= n)
				{
					return terms;
				}
				terms.Add(x);
			}
		}
	}
}

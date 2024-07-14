namespace ProjectEuler.Problems_00
{
	internal class Problem_09 : Problem
	{
		public int N = 1000;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The product abc of the Pythagorean triplet whose sum is N.</returns>
		public int SolveInternal()
		{
			var range = Enumerable.Range(1, N);
			foreach (var a in range)
			{
				foreach (var b in range)
				{
					var c = Math.Sqrt(a * a + b * b);
					if (double.IsInteger(c) && a + b + c == N)
					{
						return a * b * (int)c;
					}
				}
			}
			return 0;
		}
	}
}

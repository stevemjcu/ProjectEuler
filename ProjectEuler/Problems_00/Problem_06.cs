namespace ProjectEuler.Problems_00
{
	internal class Problem_06 : Problem
	{
		public int N = 100;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The difference between the sum of squares and the square of the sum for the first N natural numbers.</returns>
		public int SolveInternal()
		{
			var numbers = Enumerable.Range(1, N);
			var a = numbers.Select(x => x * x).Sum();
			var b = numbers.Sum(); b *= b;
			return b - a;
		}
	}
}

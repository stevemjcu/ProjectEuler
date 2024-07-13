namespace ProjectEuler.Problems_00
{
	internal class Problem_06 : Problem
	{
		public override string Solve(string n) => Solve(int.Parse(n)).ToString();

		/// <returns>The difference between the sum of squares and the square of the sum for the first n natural numbers.</returns>
		public static int Solve(int n)
		{
			var numbers = Enumerable.Range(1, n);
			var a = numbers.Select(x => x * x).Sum();
			var b = numbers.Sum(); b *= b;
			return b - a;
		}
	}
}

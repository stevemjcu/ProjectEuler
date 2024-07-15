namespace ProjectEuler.Problems
{
	public class Problem_06 : Problem
	{
		public int N = 100;

		/// <returns>The difference between the sum of squares and the square of the sum for the first N natural numbers.</returns>
		public override string Solve()
		{
			var numbers = Enumerable.Range(1, N);
			var a = numbers.Select(x => x * x).Sum();
			var b = numbers.Sum(); b *= b;
			return (b - a).ToString();
		}
	}
}

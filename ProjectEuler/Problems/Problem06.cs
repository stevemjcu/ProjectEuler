namespace ProjectEuler
{
	internal class Problem06 : Problem<int>
	{
		/// <returns>The difference between the sum of squares and the square of the sum for the first n natural numbers.</returns>
		public override int Solve(int n)
		{
			var numbers = Enumerable.Range(1, n);
			var a = numbers.Select(x => x * x).Sum();
			var b = numbers.Sum(); b *= b;
			return b - a;
		}
	}
}

namespace ProjectEuler
{
	internal class Problem06 : Problem<int>
	{
		public Problem06() => N = 100;

		/// <returns>The difference between the sum of squares and the square of the sum for the first N natural numbers.</returns>
		public override int Solve()
		{
			var numbers = Enumerable.Range(1, N);
			var a = numbers.Select(x => x * x).Sum();
			var b = numbers.Sum(); b *= b;
			return b - a;
		}
	}
}

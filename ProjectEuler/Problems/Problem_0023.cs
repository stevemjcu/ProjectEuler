namespace ProjectEuler.Problems
{
	public class Problem_0023 : Problem
	{
		public int Max = 28123;

		/// <returns>The sum of all positive integers which are not the sum of two abundant numbers.</returns>
		public override object Solve()
		{
			var abundantNumbers = Enumerable.Range(1, Max).Where(IsAbundant).ToList(); // don't defer!
			var abundantSums = new HashSet<int>();

			foreach (var i in abundantNumbers)
			{
				foreach (var j in abundantNumbers)
				{
					abundantSums.Add(i + j);
				}
			}

			return Enumerable
				.Range(1, Max)
				.ToHashSet()
				.Except(abundantSums)
				.Sum();
		}

		/// <returns>True if n is abundant; otherwise, false.</returns>
		public static bool IsAbundant(int n)
		{
			return Problem_0021.GetProperFactors(n).Sum() > n;
		}
	}
}

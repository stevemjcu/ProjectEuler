namespace ProjectEuler
{
	internal class Problem_01 : BaseProblem
	{
		public const int N = 1000;

		/// <returns>
		/// Sum of all multiples of 3 or 5 below N.
		/// </returns>
		public override string Solve()
		{
			// List multiples below N
			var multiples = new List<int>();
			foreach (var i in Enumerable.Range(0, N))
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					multiples.Add(i);
				}
			}
			// Aggregate list
			return multiples.Sum().ToString();
		}
	}
}

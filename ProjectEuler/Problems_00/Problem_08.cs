using ProjectEuler.Properties;

namespace ProjectEuler.Problems_00
{
	internal class Problem_08 : Problem
	{
		public int N = 13;

		public IEnumerable<long> M
		{
			get
			{
				var lines = Resources.Problem_08.Split(Environment.NewLine);
				var number = string.Join(string.Empty, lines);
				return number.Select(c => long.Parse(c.ToString()));
			}
		}

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The greatest product of N adjacent digits in the 1000-digit number M.</returns>
		public long SolveInternal()
		{
			return Utilities
				.SlidingWindows(M, N)
				.Max(w => w.Aggregate(1L, (acc, x) => acc * x));
		}
	}
}

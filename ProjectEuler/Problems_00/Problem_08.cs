using ProjectEuler.Properties;

namespace ProjectEuler.Problems
{
	public class Problem_08 : Problem
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

		/// <returns>The greatest product of N adjacent digits in the 1000-digit number M.</returns>
		public override string Solve()
		{
			return Utilities
				.SlidingWindows(M, N)
				.Max(w => w.Aggregate(1L, (acc, x) => acc * x))
				.ToString();
		}
	}
}

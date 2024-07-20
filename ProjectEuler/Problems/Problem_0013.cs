using System.Numerics;

namespace ProjectEuler.Problems
{
	public class Problem_0013 : Problem
	{
		public int N = 10;

		public IEnumerable<BigInteger> M
		{
			get => Resource
				.Split(Environment.NewLine)
				.Select(BigInteger.Parse);
		}

		/// <returns>The first N digits of the sum of the one hundred 50-digit numbers in M.</returns>
		public override object Solve()
		{
			var sum = M.Aggregate((acc, x) => acc + x);
			return long.Parse(sum.ToString()[0..N]);
		}
	}
}

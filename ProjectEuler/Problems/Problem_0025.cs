using System.Numerics;

namespace ProjectEuler.Problems
{
	class Problem_0025 : Problem
	{
		public int N = 1000;

		/// <returns>The index of the first Fibonacci term to have N digits.</returns>
		public override object Solve()
		{
			return GetFibonacciSequence()
				.Select((val, idx) => (val, idx))
				.First(t => t.val.ToString().Length >= N)
				.idx;
		}

		/// <returns>The terms of the Fibonacci sequence, starting at 1.</returns>
		public static IEnumerable<BigInteger> GetFibonacciSequence()
		{
			var (a, b) = (BigInteger.One, BigInteger.One);
			while (true)
			{
				yield return a;
				(a, b) = (b, a + b);
			}
		}
	}
}

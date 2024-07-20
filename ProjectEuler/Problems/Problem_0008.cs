﻿namespace ProjectEuler.Problems
{
	public class Problem_0008 : Problem
	{
		public int N = 13;

		public IEnumerable<long> M
		{
			get => Resource
				.Replace(Environment.NewLine, string.Empty)
				.Select(c => c.ToString())
				.Select(long.Parse);
		}

		/// <returns>The greatest product of N adjacent digits in the 1000-digit number M.</returns>
		public override object Solve()
		{
			return Utilities
				.SlidingWindows(M, N)
				.Max(w => w.Product());
		}
	}
}

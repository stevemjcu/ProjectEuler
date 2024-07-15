﻿namespace ProjectEuler.Problems
{
	public class Problem_07 : Problem
	{
		public int N = 10001;

		/// <returns>The Nth prime number.</returns>
		public override string Solve()
		{
			return Utilities
				.Range(1, null)
				.Where(x => Problem_03.IsPrime(x))
				.Take(N)
				.Last()
				.ToString();
		}
	}
}

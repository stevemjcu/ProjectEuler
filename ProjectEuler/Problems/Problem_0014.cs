﻿namespace ProjectEuler.Problems;

public class Problem_0014 : Problem
{
	public int N = 1000000;

	/// <returns>The starting number under N with the longest Collatz sequence.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N - 1)
			.MaxBy(i => GetCollatzSequenceLength(i));
	}

	public static int GetCollatzSequenceLength(long n)
	{
		var i = 1;
		for (; n != 1; i++)
		{
			if (n % 2 == 0) n /= 2;
			else n = 3 * n + 1;
		}
		return i;
	}
}
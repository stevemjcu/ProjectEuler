namespace ProjectEuler.Problems;

public class Problem_0014 : Problem
{
	public int N = 1000000;

	/// <returns>The starting number under N with the longest Collatz sequence.</returns>
	public override object Solve()
	{
		return Utils
			.Range(1L, N - 1)
			.MaxBy(GetCollatzSequenceLength);
	}

	public static long GetCollatzSequenceLength(long n)
	{
		var i = 1L;
		for (; n != 1; i++)
		{
			if (n % 2 == 0) n /= 2;
			else n = 3 * n + 1;
		}
		return i;
	}
}
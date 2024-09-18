namespace ProjectEuler.Problems;

internal class Problem_0030 : Problem
{
	public int N = 5;

	/// <returns>The sum of all numbers which can be written as the sum of the Nth powers of their digits.</returns>
	public override object Solve()
	{
		int max;
		for (var len = 1; ; len++)
		{
			max = (int)Math.Pow(9, N) * len;
			var sum = (int)Math.Pow(10, len) - 1;
			if (max < sum) break;
		}

		return Enumerable
			.Range(10, max - 10) // [1, 9] are not sums
			.Where(x => x == SumPowersOfDigits(x, N))
			.Sum();
	}

	public static int SumPowersOfDigits(int num, int pow)
	{
		return num
			.ToString()
			.Select(d => int.Parse(d.ToString()))
			.Select(d => (int)Math.Pow(d, pow))
			.Sum();
	}
}


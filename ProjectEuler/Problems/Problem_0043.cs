namespace ProjectEuler.Problems;

public class Problem_0043 : Problem
{
	private const int N = 7; // number of windows
	private const int M = 3; // size of windows
	private static readonly int[] _divisors = [2, 3, 5, 7, 11, 13, 17];

	/// <returns>The sum of all 0 to 9 pandigital numbers with the sub-string divisibility property.</returns>
	public override object Solve()
	{
		return Utils
			.GetPermutations(Enumerable.Range(0, 10).ToArray())
			.Where(IsSubStringDivisible)
			.Sum(Utils.FromDigits);
	}

	/// <returns>True if the 10-digit number x has a certain sub-string divisibility property; otherwise, false.</returns>
	public static bool IsSubStringDivisible(int[] x)
	{
		for (var i = N; i > 0; i--)
		{
			var window = ((Span<int>)x).Slice(i, M);
			var value = window[0] * 100 + window[1] * 10 + window[2];
			if (value % _divisors[i - 1] != 0) return false;
		}
		return true;
	}
}
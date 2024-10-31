namespace ProjectEuler.Problems;

public class Problem_0043 : Problem
{
	private static readonly int[] _factors = [2, 3, 5, 7, 11, 13, 17];

	/// <returns>The sum of all 0 to 9 pandigital numbers with the sub-string divisibility property.</returns>
	public override object Solve()
	{
		return Utils
			.GetPermutations(Utils.Range(0, 10).ToArray())
			.Where(IsSubStringDivisible)
			.Sum(Utils.FromDigits);
	}

	/// <returns>True if the sum of alphabetical positions is a triangle number; otherwise, false.</returns>
	public static bool IsSubStringDivisible(int[] s)
	{
		var i = 0;
		foreach (var window in Utils
			.GetSlidingWindows(s, 3)
			.Select(Utils.FromDigits)
			.Skip(1))
		{
			if (window % _factors[i] != 0) return false;
			i++;
		}
		return true;
	}
}
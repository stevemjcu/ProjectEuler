namespace ProjectEuler.Problems;

public class Problem_0043 : Problem
{
	private static readonly int[] _factors = [2, 3, 5, 7, 11, 13, 17];

	/// <returns>The sum of all 0 to 9 pandigital numbers with the sub-string divisibility property.</returns>
	public override object Solve()
	{
		var permutations = Utils.GetPermutations(Utils.Range(0L, 10L));
		var matches = permutations.Where(IsSubStringDivisible).Select(Utils.FromDigits);
		return matches.Sum();
	}

	/// <returns>True if the sum of alphabetical positions is a triangle number; otherwise, false.</returns>
	public static bool IsSubStringDivisible(IEnumerable<long> s)
	{
		var i = 0;
		foreach (var window in s.SlidingWindows(3).Skip(1))
		{
			if (Utils.FromDigits(window) % _factors[i] != 0) return false;
			i++;
		}
		return true;
	}
}
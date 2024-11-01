namespace ProjectEuler.Problems;

public class Problem_0042 : Problem
{
	public IEnumerable<string> M => Resource.Split(',').Select(s => s[1..^1]);

	/// <returns>The number of triangle words in the word list M.</returns>
	public override object Solve()
	{
		return M.Count(IsTriangleWord);
	}

	/// <returns>True if the sum of alphabetical positions is a triangle number; otherwise, false.</returns>
	public static bool IsTriangleWord(string s)
	{
		return IsTriangleNumber(s.ToCharArray().Select(c => c - 'A' + 1).Sum());
	}

	/// <returns>True if x = n(3n-1)/2 for some positive integer n; otherwise, false.</returns>
	public static bool IsTriangleNumber(int x)
	{
		// x = n(n+1)/2 => 0 = n^2 + n - 2x
		return double.IsInteger(Utils.SolveQuadratic(1, 1, -2 * x).Item1);
	}
}
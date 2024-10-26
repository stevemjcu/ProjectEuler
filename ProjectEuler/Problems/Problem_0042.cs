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
		var sum = s.ToCharArray().Select(c => c - 'A' + 1).Sum();
		var t = GetTriangleNumbers().TakeWhile(t => t <= sum).Last();
		return sum == t;
	}

	/// <returns>The sequence of triangle numbers given by tn = (1/2)n(n+1).</returns>
	public static IEnumerable<int> GetTriangleNumbers()
	{
		for (var n = 1; ; n++)
		{
			yield return n * (n + 1) / 2;
		}
	}
}
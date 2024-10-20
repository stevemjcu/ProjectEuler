namespace ProjectEuler.Problems;

public class Problem_0022 : Problem
{
	public List<string> M =>
		Resource
			.Split(",")
			.Select(s => s[1..^1])
			.ToList();

	/// <returns>A total score corresponding to the alphabetical value and position of each name in M.</returns>
	public override object Solve()
	{
		var names = M;
		names.Sort(CompareAlphabetically);
		return names.Select(Score).Sum();
	}

	/// <returns>A positive value if a follows b alphabetically; otherwise, negative or zero.</returns>
	public static int CompareAlphabetically(string a, string b)
	{
		return Utils.CompareLexicographically(a.ToCharArray(), b.ToCharArray());
	}

	/// <returns>The product of a name's alphabetical value and position.</returns>
	public static int Score(string name, int index)
	{
		var a = name.Select(c => c - 'A' + 1).Sum();
		var b = index + 1;
		return a * b;
	}
}
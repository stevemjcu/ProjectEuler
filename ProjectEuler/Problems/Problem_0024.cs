namespace ProjectEuler.Problems;

public class Problem_0024 : Problem
{
	public int N = 1000000;
	public int M = 9;

	/// <returns>The Nth lexicographic permutation of 0 through M.</returns>
	public override object Solve()
	{
		var original = Enumerable.Range(0, M + 1).ToArray();
		return long.Parse(string.Join("", Utils.GetPermutations(original).ElementAt(N - 1)));
	}
}
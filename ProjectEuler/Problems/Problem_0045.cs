namespace ProjectEuler.Problems;

public class Problem_0045 : Problem
{
	public int N = 40755;

	/// <returns>The next number after N which is triangular, pentagonal, and hexagaonal.</returns>
	public override object Solve()
	{
		IsHexagonalNumber(N, out var n);
		return Utils.Range(n, null)
			.Select(GetHexagonalNumber) // fastest growth
			.Where(Problem_0044.IsPentagonalNumber)
			.Where(Problem_0042.IsTriangleNumber) // slowest growth
			.Skip(1)
			.First();
	}

	/// <returns>The hexagonal numbers given by x = n(2n-1).</returns>
	public static int GetHexagonalNumber(int n)
	{
		return n * (2 * n - 1);
	}

	/// <returns>True if x = n(2n-1) for some positive integer n; otherwise, false.</returns>
	public static bool IsHexagonalNumber(int x, out int n)
	{
		// x = n(2n-1) => 0 = 2n^2 - n - x
		var root = Utils.SolveQuadratic(2, -1, -x).Item1;
		n = (int)root;
		return double.IsInteger(root);
	}
}
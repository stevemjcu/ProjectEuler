namespace ProjectEuler.Problems;

public class Problem_0045 : Problem
{
	/// <returns>The next number after N which is triangular, pentagonal, and hexagaonal.</returns>
	public override object Solve()
	{
		return Utils.Range(143, null)
			.Select(GetHexagonalNumber)
			.Where(Problem_0044.IsPentagonalNumber)
			.Where(Problem_0042.IsTriangleNumber)
			.Skip(1)
			.First();
	}

	/// <returns>The hexagonal numbers given by x = n(2n-1).</returns>
	public static int GetHexagonalNumber(int n)
	{
		return n * (2 * n - 1);
	}

	/// <returns>True if x = n(2n-1) for some positive integer n; otherwise, false.</returns>
	public static bool IsHexagonalNumber(int x)
	{
		// x = n(2n-1) => 0 = 2n^2 - n - x
		return double.IsInteger(Utils.SolveQuadratic(2, -1, -x).Item1);
	}
}
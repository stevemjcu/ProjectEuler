namespace ProjectEuler.Problems;

public class Problem_0041 : Problem
{
	/// <returns>The largest n-digit pandigital prime.</returns>
	public override object Solve()
	{
		return Enumerable.Range(1, 9).Max(GetLargestPandigitalPrime);
	}

	public static int GetLargestPandigitalPrime(int n)
	{
		return (int)Utils
			.GetPermutations(Enumerable.Range(1, n).Reverse().ToArray())
			.Select(Utils.FromDigits<int>)
			.FirstOrDefault(Utils.IsPrime);
	}
}
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
		var max = Enumerable.Range(1, n).Reverse().ToArray();
		var permutations = Utils.GetPermutations(max).Select(i => Utils.FromDigits(new(i)));
		return permutations.FirstOrDefault(Utils.IsPrime);
	}
}
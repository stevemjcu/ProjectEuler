namespace ProjectEuler.Problems;

public class Problem_0003 : Problem
{
	public long N = 600851475143;

	/// <returns>The largest prime factor of N.</returns>
	public override object Solve()
	{
		return Utils
			.GetFactors(N)
			.Last(Utils.IsPrime);
	}
}
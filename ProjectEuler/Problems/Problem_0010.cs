namespace ProjectEuler.Problems;

public class Problem_0010 : Problem
{
	public int N = 2000000;

	/// <returns>The sum of all the primes below N.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, N - 1)
			.Where(Utils.IsPrime)
			.Sum(i => (long)i);
	}
}
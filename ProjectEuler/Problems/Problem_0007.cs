namespace ProjectEuler.Problems;

public class Problem_0007 : Problem
{
	public int N = 10001;

	/// <returns>The Nth prime number.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, int.MaxValue)
			.Where(Utils.IsPrime)
			.ElementAt(N - 1);
	}
}
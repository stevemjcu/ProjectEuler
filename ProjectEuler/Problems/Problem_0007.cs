namespace ProjectEuler.Problems;

public class Problem_0007 : Problem
{
	public int N = 10001;

	/// <returns>The Nth prime number.</returns>
	public override object Solve()
	{
		return Utils
			.Range(1, null)
			.Where(Problem_0003.IsPrime)
			.ElementAt(N - 1);
	}
}
namespace ProjectEuler.Problems;

public class Problem_0008 : Problem
{
	public int N = 13;

	public IEnumerable<long> M => Resource
		.Replace(Environment.NewLine, string.Empty)
		.Select(c => long.Parse(c.ToString()));

	/// <returns>The greatest product of N adjacent digits in the 1000-digit number M.</returns>
	public override object Solve()
	{
		return Utils
			.GetSlidingWindows(M.ToArray(), N)
			.Max(w => w.Product());
	}
}
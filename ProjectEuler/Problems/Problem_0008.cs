namespace ProjectEuler.Problems;

public class Problem_0008 : Problem
{
	public int N = 13;

	public long[] M => Resource
		.Replace(Environment.NewLine, string.Empty)
		.Select(c => long.Parse(c.ToString()))
		.ToArray();

	/// <returns>The greatest product of N adjacent digits in the 1000-digit number M.</returns>
	public override object Solve()
	{
		return M
			.GetSlidingWindows(N)
			.Max(w => w.Product());
	}
}
namespace ProjectEuler.Problems;

public class Problem_0005 : Problem
{
	public int N = 20;

	/// <returns>The smallest positive number whose factors include 1 through N.</returns>
	public override object Solve()
	{
		return SolveLoop();
	}

	public int SolveLinq()
	{
		// Can this performance be improved?
		var factors = Enumerable.Range(1, N).ToList();
		return Utils
			.Range(1, null)
			.First(i => factors.All(j => i % j == 0));
	}

	public int SolveLoop()
	{
		for (var i = 1; ; i++)
		{
			for (var j = 1; j <= N; j++)
			{
				if (i % j != 0)
				{
					break;
				}
				if (j == N)
				{
					return i;
				}
			}
		}
	}
}
namespace ProjectEuler.Problems;

public class Problem_0028 : Problem
{
	public int N = 1001;

	/// <returns>The sum of the numbers on the diagonals in an N by N spiral matrix.</returns>
	public override object Solve()
	{
		var layers = N / 2 + 1;
		var cur = 1;
		var sum = 1;

		for (var i = 1; i < layers; i++)
		{
			for (var j = 0; j < 4; j++)
			{
				cur += i * 2;
				sum += cur;
			}
		}

		return sum;
	}
}
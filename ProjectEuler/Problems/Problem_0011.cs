namespace ProjectEuler.Problems;

public class Problem_0011 : Problem
{
	public int N = 4;

	public int[,] M => Resource
		.Split([Environment.NewLine, " "], default)
		.Select(int.Parse)
		.ToRectangularArray(20, 20);

	/// <returns>The greatest product of N adjacent digits in the 20x20 grid M.</returns>
	public override object Solve()
	{
		var top = 0;
		top = Math.Max(top, Reduce(M, N, 1, 0));
		top = Math.Max(top, Reduce(M, N, 0, 1));
		top = Math.Max(top, Reduce(M, N, 1, 1));
		top = Math.Max(top, Reduce(M.ReverseRows(), N, 1, 1));
		return top;
	}

	public static int Reduce(int[,] source, int n, int dx, int dy)
	{
		var top = 0;
		for (var y = 0; y + n * dy < source.GetLength(0); y++)
		{
			for (var x = 0; x + n * dx < source.GetLength(1); x++)
			{
				var acc = 1;
				for (var k = 0; k < n; k++)
				{
					acc *= source[y + k * dy, x + k * dx];
				}
				top = Math.Max(top, acc);
			}
		}
		return top;
	}
}
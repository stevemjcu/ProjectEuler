namespace ProjectEuler.Problems;

public class Problem_0040 : Problem
{
	/// <returns>The value of Champernowne's Constant.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(0, 7)
			.Select(i => (int)Math.Pow(10, i))
			.Select(GetNthDigit)
			.Product();
	}

	public static int GetNthDigit(int n)
	{
		var idx = 1;
		for (var i = 1; ; i++)
		{
			var next = idx + Utils.GetLength(i);
			if (next > n)
			{
				return Utils.ToDigits(i)[n - idx];
			}
			idx = next;
		}
	}
}
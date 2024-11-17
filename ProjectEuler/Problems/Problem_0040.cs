namespace ProjectEuler.Problems;

public class Problem_0040 : Problem
{
	public int N = 7;

	/// <returns>The product of the first N powers of 10 in the fractional part of the Champernowne constant.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(0, N)
			.Select(i => (int)Math.Pow(10, i))
			.Select(ExpandChampernowneConstant)
			.Product();
	}

	/// <returns>The nth digit in the fractional part of the Champernowne constant.</returns>
	public static int ExpandChampernowneConstant(int n)
	{
		for (var (x, i) = (1, 1); ; x++)
		{
			var next = i + x.Length();
			if (next > n)
			{
				return Utils.ToDigits(x)[n - i];
			}
			i = next;
		}
	}
}
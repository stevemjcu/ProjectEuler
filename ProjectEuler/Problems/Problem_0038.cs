namespace ProjectEuler.Problems;

public class Problem_0038 : Problem
{
	/// <returns>The largest pandigital number which can be formed from the concatenated products of any integer and [1..n] where n = (1..9].</returns>
	public override object Solve()
	{
		return Enumerate().Max();
	}

	public static IEnumerable<int> Enumerate()
	{
		for (var n = 2; n <= 9; n++)
			for (var i = 1; ; i++)
			{
				var p1 = ConcatenatedProduct(i, n);
				if (p1.Length < 9) continue;
				if (p1.Length > 9) break;
				var p2 = int.Parse(p1);
				if (Problem_0032.IsPandigital([.. Utils.ToDigits(p2)]))
					yield return p2;
			}
	}

	/// <returns>The concatenated product of x and each value in [1..n].</returns>
	public static string ConcatenatedProduct(int x, int n)
	{
		var acc = string.Empty;
		for (var i = 1; i <= n; i++)
			acc = string.Concat(acc, (x * i).ToString());
		return acc;
	}
}
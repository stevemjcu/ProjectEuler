using System.Collections;

namespace ProjectEuler.Problems;

public class Problem_0051 : Problem
{
	public int N = 8;
	public int M = 10;

	/// <returns>The smallest prime which is part of an N-prime family.</returns>
	public override object Solve()
	{
		return GenerateFamilies(M)
			.First(f => f.Count(Utils.IsPrime) == N)
			.First(Utils.IsPrime);
	}

	/// <returns>The sequence of possible families within n digits, without repeats.</returns>
	private static IEnumerable<IEnumerable<int>> GenerateFamilies(int n)
	{
		var seen = new HashSet<int>();
		var masks = GenerateMasks(n).ToArray();
		for (var i = 0; i < Math.Pow(10, n); i++)
		{
			if (seen.Contains(i)) continue;
			var len = i.Length();
			for (var j = 0; j < len * len; j++)
			{
				var family = GenerateFamily(i, masks[j]);
				seen.UnionWith(family);
				yield return family;
			}
		}
	}

	/// <returns>The sequence of possible numbers which can be created by replacing the masked digits of n.</returns>
	private static IEnumerable<int> GenerateFamily(int n, BitArray mask)
	{
		var m = Utils.ToDigits(n).ToArray();
		for (var i = 0; i < 10; i++)
		{
			if (mask[0] && i == 0) continue; // skip leading zero
			for (var j = 0; j < m.Length; j++)
				if (mask[j]) m[j] = i;
			yield return Utils.FromDigits<int>(m);
		}
	}

	/// <returns>The sequence of possible masks which are the size n.</returns>
	private static IEnumerable<BitArray> GenerateMasks(int n)
	{
		for (var i = 1; i < n * n - 1; i++)
			yield return new([i]);
	}
}
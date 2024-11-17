using System.Collections;

namespace ProjectEuler.Problems;

public class Problem_0051 : Problem
{
	public int N = 8;

	/// <returns>The smallest prime which is part of an N-prime family.</returns>
	public override object Solve()
	{
		return GenerateFamilies()
			.First(f => f.Count(Utils.IsPrime) == N)
			.First(Utils.IsPrime);
	}

	/// <returns>The sequence of possible families under n digits, without repeats.</returns>
	private static IEnumerable<IEnumerable<int>> GenerateFamilies()
	{
		// Maintain member cache to avoid duplicates?
		for (var i = 2; ; i++)
		{
			var start = (int)Math.Pow(10, i - 1);
			var end = (int)Math.Pow(10, i);
			var masks = GenerateMasks(i).ToArray()[1..^1];
			for (var j = start; j < end; j++)
				foreach (var m in masks)
					yield return GenerateFamily(j, m);
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
			yield return (int)Utils.FromDigits(m);
		}
	}

	/// <returns>The sequence of possible masks which are the size n.</returns>
	private static IEnumerable<BitArray> GenerateMasks(int n)
	{
		for (var i = 0; i < n * n; i++)
			yield return new([i]);
	}
}
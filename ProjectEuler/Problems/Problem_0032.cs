namespace ProjectEuler.Problems;

internal class Problem_0032 : Problem
{
	public static int N = 9;

	/// <returns>The sum of all products a * b = c where 'abc' is pandigital.</returns>
	public override object Solve()
	{
		var set = new HashSet<int>();
		for (var i = 1; ; i++)
		{
			var a = Utils.ToDigits(i);
			if (a.Count >= N - 2) break;
			for (var j = 1; ; j++)
			{
				int[] abc = [
					.. a,
					.. Utils.ToDigits(j),
					.. Utils.ToDigits(i * j)
				];
				if (abc.Length < N) continue;
				if (abc.Length > N) break;
				if (IsPandigital(abc)) set.Add(i * j);
			}
		}
		return set.Sum();
	}

	/// <returns>True if x makes use of all digits 1-n exactly once; otherwise, false.</returns>
	public static bool IsPandigital(int[] x)
	{
		var set = x.ToHashSet();
		if (set.Count != N) return false;
		for (var i = 1; i <= N; i++)
		{
			if (!set.Contains(i)) return false;
		}
		return true;
	}
}


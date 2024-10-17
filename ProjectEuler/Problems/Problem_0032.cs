namespace ProjectEuler.Problems;

internal class Problem_0032 : Problem
{
	public int N = 9;

	/// <returns>The sum of all products a * b = c which can be written as 1-N pandigital.</returns>
	public override object Solve()
	{
		var set = new HashSet<int>();
		for (var a = 1; Utilities.ToDigits(a).Count < N - 2; a++)
		{
			for (var b = 1; ; b++)
			{
				var c = a * b;
				int[] d = [
					.. Utilities.ToDigits(a),
					.. Utilities.ToDigits(b),
					.. Utilities.ToDigits(c)
				];
				if (d.Length < N) continue;
				if (d.Length > N) break;
				if (IsPandigital(d, N)) set.Add(c);
			}
		}
		return set.Sum();
	}

	/// <returns>True if x makes use of all digits 1-n exactly once; otherwise, false.</returns>
	public static bool IsPandigital(int[] x, int n)
	{
		var set = x.ToHashSet();
		if (set.Count != n) return false;
		for (var i = 1; i <= n; i++)
		{
			if (!set.Contains(i)) return false;
		}
		return true;
	}
}


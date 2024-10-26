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
				int[] abc = [.. a, .. Utils.ToDigits(j), .. Utils.ToDigits(i * j)];
				if (abc.Length < N) continue;
				if (abc.Length > N) break;
				if (Utils.IsPandigital(abc, N)) set.Add(i * j);
			}
		}
		return set.Sum();
	}
}
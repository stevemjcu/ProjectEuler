namespace ProjectEuler.Problems;

internal class Problem_0033 : Problem
{
	private const double TOLERANCE = 0.001;

	/// <returns>The denominator of the product of the four non-trivial, two-digit, less than one, digit cancelling fractions.</returns>
	public override object Solve()
	{
		var acc = GetFractions().Where(CanSimplify).Take(4).Aggregate(
			(f, p) => (f.Item1 * p.Item1, f.Item2 * p.Item2));
		return acc.Item2 / Utils.GCD(acc.Item1, acc.Item2);
	}

	private static IEnumerable<(int, int)> GetFractions()
	{
		for (var i = 10; i < 100; i++)
			for (var j = i + 1; j < 100; j++)
				yield return (i, j);
	}

	private static bool CanSimplify((int, int) f)
	{
		var a = Utils.ToDigits(f.Item1);
		var b = Utils.ToDigits(f.Item2);

		var matches = a.Intersect(b).ToList();
		if (matches.Count != 1) return false;
		var c = matches[0];
		if (c == 0) return false;

		a.Remove(c);
		b.Remove(c);
		if (b[0] == 0) return false;

		var x = (double)a[0] / b[0];
		var y = (double)f.Item1 / f.Item2;
		return Math.Abs(x - y) < TOLERANCE;
	}
}


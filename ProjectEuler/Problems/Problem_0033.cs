﻿namespace ProjectEuler.Problems;

internal class Problem_0033 : Problem
{
	/// <returns>The denominator of the product of all non-trival, two-digit, less than one, digit cancelling fractions.</returns>
	public override object Solve()
	{
		var acc = GetFractions().Where(CanSimplify).Aggregate((f, p) => (f.Item1 * p.Item1, f.Item2 * p.Item2));
		return acc.Item2 / Utils.GCD(acc.Item1, acc.Item2);
	}

	public static IEnumerable<(int, int)> GetFractions()
	{
		for (var i = 10; i < 100; i++)
			for (var j = i + 1; j < 100; j++)
				yield return (i, j);
	}

	public static bool CanSimplify((int, int) f)
	{
		var a = Utils.ToDigits(f.Item1);
		var b = Utils.ToDigits(f.Item2);

		var matches = a.Intersect(b);
		if (matches.Count() != 1) return false;
		var x = matches.First();
		if (x == 0) return false;

		a.Remove(x);
		b.Remove(x);
		if (b.First() == 0) return false;

		return (float)a.First() / b.First() == (float)f.Item1 / f.Item2;
	}
}


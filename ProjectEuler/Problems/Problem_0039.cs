﻿namespace ProjectEuler.Problems;

public class Problem_0039 : Problem
{
	public int N = 1000;

	/// <returns>The perimeter &lt;= N which can be formed by the most right triangles with integral length sides.</returns>
	public override object Solve()
	{
		return Enumerable.Range(1, N).MaxBy(p => GetIntegerRightTriangles(p).Count());
	}

	/// <returns>A sequence that contains the integer right triangles whose perimeters equal p.</returns>
	public static IEnumerable<(int, int, int)> GetIntegerRightTriangles(int p)
	{
		for (var a = 1; a < p / 2; a++)
		{
			for (var b = 1; ; b++)
			{
				var h = Math.Sqrt(a * a + b * b);
				var c = Convert.ToInt32(h);
				if (a + b + c > p) break;
				if (double.IsInteger(h) && a + b + c == p) yield return (a, b, c);
			}
		}
	}
}
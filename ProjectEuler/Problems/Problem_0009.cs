namespace ProjectEuler.Problems;

public class Problem_0009 : Problem
{
	public int N = 1000;

	/// <returns>The product abc of the Pythagorean triplet whose sum is N.</returns>
	public override object Solve()
	{
		var range = Enumerable.Range(1, N);
		foreach (var a in range)
		{
			foreach (var b in range)
			{
				var c = Math.Sqrt(a * a + b * b);
				if (double.IsInteger(c) && a + b + c == N)
				{
					return a * b * (int)c;
				}
			}
		}
		return string.Empty;
	}
}
namespace ProjectEuler.Problems;

public class Problem_0006 : Problem
{
	public int N = 100;

	/// <returns>The difference between the sum of squares and the square of the sum for the first N natural numbers.</returns>
	public override object Solve()
	{
		var numbers = Enumerable.Range(1, N).ToList();
		var a = numbers.Select(x => x * x).Sum();
		var b = numbers.Sum();
		return b * b - a;
	}
}
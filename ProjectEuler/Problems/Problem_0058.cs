namespace ProjectEuler.Problems;

public class Problem_0058 : Problem
{
	public double N = 0.1;
	public int M = 10000;

	/// <returns>
	/// The side length of the square spiral where the ratio of primes on both diagonals falls under N.
	/// </returns>
	public override object Solve()
	{
		var ratios = ExpandPrimeRatios(ExpandSpiralDiagonals());
		var idx = ratios.Skip(1).TakeWhile(r => r >= N).Count();
		return (idx + 1) * 2 + 1; // skipped first layer (0%)
	}

	// consider layers l = 0..N
	// side length a: 1, 3, 5, 7...
	// diagonal step b: 0, 2, 4, 6...
	// a = l * 2 + 1
	// b = l * 2

	/// <returns>The sequence of diagonal numbers on each layer of a square spiral.</returns>
	private static IEnumerable<int[]> ExpandSpiralDiagonals()
	{
		var cur = 1;
		yield return [cur];
		for (var i = 1; ; i++)
		{
			var arr = new int[4];
			for (var j = 0; j < 4; j++)
			{
				cur += i * 2;
				arr[j] = cur;
			}
			yield return arr;
		}
	}

	/// <returns>The sequence of aggregate ratios of diagonal primes on each layer of a square spiral.</returns>
	private static IEnumerable<double> ExpandPrimeRatios(IEnumerable<int[]> spiral)
	{
		var i = 0;
		var length = 0;
		var primes = 0;
		foreach (var layer in spiral)
		{
			length += i == 0 ? 1 : 4;
			primes += layer.Count(Utils.IsPrime);
			yield return (double)primes / length;
			i++;
		}
	}
}
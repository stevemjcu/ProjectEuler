namespace ProjectEuler.Problems;

public class Problem_0050 : Problem
{
	public int N = 1000000;

	/// <returns>The prime under N which is the sum of the most consecutive primes.</returns>
	public override object Solve()
	{
		var primes = GetPrimes(N).ToArray();
		var primesSet = primes.ToHashSet();

		var (n, sum) = (0, 0);
		foreach (var p in primes)
		{
			sum += p;
			if (sum > N) break;
			n++;
		}
		primes = primes[..n];

		for (var i = n; i > 0; i--)
		{
			foreach (var span in primes.GetSlidingWindows(i))
			{
				sum = span.Sum();
				if (primesSet.Contains(sum)) return sum;
			}
		}
		return 0;
	}

	/// <returns>The list of primes under n.</returns>
	public static IEnumerable<int> GetPrimes(int n)
	{
		return Enumerable
			.Range(1, n)
			.Where(Utils.IsPrime)
			.TakeWhile(p => p < n);
	}
}
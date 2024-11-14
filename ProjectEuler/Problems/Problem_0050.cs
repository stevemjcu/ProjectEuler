namespace ProjectEuler.Problems;

public class Problem_0050 : Problem
{
	public int N = 1000000;

	/// <returns>The prime under N which is the sum of the most consecutive primes.</returns>
	public override object Solve()
	{
		var primes = GetPrimes(N).ToArray();
		var primesSet = primes.ToHashSet();

		var (n, acc) = (0, 0);
		foreach (var p in primes)
		{
			acc += p;
			if (acc > N) break;
			n++;
		}

		for (; n > 0; n--)
		{
			foreach (var span in Utils.GetSlidingWindows(primes, n))
			{
				var sum = span.Sum(p => (long)p);
				if (sum > N) break; // subsequent windows will be larger
				if (primesSet.Contains((int)sum)) return sum;
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
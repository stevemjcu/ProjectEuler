namespace ProjectEuler.Problems;

public class Problem_0050 : Problem
{
	public int N = 1000000;

	/// <returns>The prime under N which is the sum of the most consecutive primes.</returns>
	public override object Solve()
	{
		// FIXME: This works, but has very poor time complexity. How to reduce overlap?
		var primes = Enumerable.Range(1, N).Where(Utils.IsPrime).TakeWhile(p => p < N).ToList();
		return primes.MaxBy(p => CountConsecutiveAddends(p, primes));
	}

	/// <returns>The maximum number of consecutive addends whose summation is n.</returns>
	private static int CountConsecutiveAddends(int n, List<int> addends)
	{
		for (var i = 0; addends[i] <= n; i++)
		{
			var sum = 0;
			for (var j = i; sum < n; j++)
			{
				sum += addends[j];
				if (sum == n) return j - i + 1;
			}
		}
		return 0;
	}
}
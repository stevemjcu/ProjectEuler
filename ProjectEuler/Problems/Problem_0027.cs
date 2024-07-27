namespace ProjectEuler.Problems;

public class Problem_0027 : Problem
{
	public int N = 1000;

	/// <returns>
	///     The product of coefficients for the quadratic expression n^2 + an + b where |a| &lt; N and |b| &lt;= N that
	///     produces the most consecutive primes for values of n, starting at n = 0.
	/// </returns>
	public override object Solve()
	{
		(int product, int count) max = (0, 0);
		for (var i = -N + 1; i < N; i++)
		{
			for (var j = -N; j <= N; j++)
			{
				var (a, b) = (i, j);
				var count = CountConsecutivePrimes(n => n * n + a * n + b);
				if (count > max.count)
				{
					max = (a * b, count);
				}
			}
		}
		return max.product;
	}

	/// <returns>The number of consecutive primes for values of n, starting at n = 0.</returns>
	public static int CountConsecutivePrimes(Func<int, int> fn)
	{
		for (var i = 0;; i++)
		{
			if (!Problem_0003.IsPrime(fn(i)))
			{
				return i;
			}
		}
	}
}
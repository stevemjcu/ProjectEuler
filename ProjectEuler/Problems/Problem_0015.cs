namespace ProjectEuler.Problems
{
	public class Problem_0015 : Problem
	{
		public int N = 20;

		/// <returns>The number of possible routes between two opposite corners on a grid of order N.</returns>
		public override object Solve()
		{
			return GetRoutes(0, 0, N, []);
		}

		/// <returns>The number of possible routes from the current to the maximum coordinate on a grid of order n.</returns>
		public static long GetRoutes(int x, int y, int n, Dictionary<(int, int), long> cache)
		{
			if (cache.ContainsKey((x, y)))
			{
				return cache[(x, y)];
			}

			var result = 0L;
			if (x == n && y == n)
			{
				result = 1;
			}
			else
			{
				if (x < n)
				{
					result += GetRoutes(x + 1, y, n, cache);
				}
				if (y < n)
				{
					result += GetRoutes(x, y + 1, n, cache);
				}
			}

			cache[(x, y)] = result;
			return result;
		}
	}
}

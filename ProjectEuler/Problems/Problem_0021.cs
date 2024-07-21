namespace ProjectEuler.Problems
{
	public class Problem_0021 : Problem
	{
		public int N = 10000;

		/// <returns>The sum of all amicable numbers under N.</returns>
		public override object Solve()
		{
			return GetAmicableNumbers(N).Sum();
		}

		public static IEnumerable<int> GetAmicableNumbers(int n)
		{
			var map = new Dictionary<int, int>();
			for (int i = 1; i <= n; i++)
			{
				map[i] = (int)GetProperFactors(i).Sum();
			}
			foreach (var (a, b) in map)
			{
				if (a != b && map.TryGetValue(b, out var c) && c == a)
				{
					yield return a;
				}
			}
		}

		public static IEnumerable<long> GetProperFactors(long n)
		{
			return Problem_0003.GetFactors(n).ToList()[0..^1];
		}
	}
}

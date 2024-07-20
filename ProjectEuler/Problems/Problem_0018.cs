namespace ProjectEuler.Problems
{
	public class Problem_0018 : Problem
	{
		public int[][] M
		{
			get => Resource
				.Split(Environment.NewLine)
				.Select(s => s
					.Split(" ")
					.Select(int.Parse)
					.ToArray())
				.ToArray();
		}

		/// <returns>The maximum total from the top to the bottom of the triangle M.</returns>
		public override object Solve()
		{
			return GetMaxTotal(0, 0, M, []);
		}

		/// <returns>The maximum total from the coordinate (x, y) to the bottom of the triangle.</returns>
		public static int GetMaxTotal(int x, int y, int[][] triangle, Dictionary<(int, int), int> cache)
		{
			if (y == triangle.Length)
			{
				return 0;
			}
			if (cache.ContainsKey((x, y)))
			{
				return cache[(x, y)];
			}

			var result = triangle[y][x] + Math.Max(
				GetMaxTotal(x, y + 1, triangle, cache),
				GetMaxTotal(x + 1, y + 1, triangle, cache));

			cache[(x, y)] = result;
			return result;
		}
	}
}

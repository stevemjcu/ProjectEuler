namespace ProjectEuler.Problems
{
	public class Problem_0024 : Problem
	{
		public int N = 1000000;
		public int M = 9;

		/// <returns>The Nth lexicographic permutation of 0 through M.</returns>
		public override object Solve()
		{
			var original = Enumerable.Range(0, M + 1).ToList();
			return long.Parse(string.Join("", Permute(original).ElementAt(N - 1)));
		}

		/// <returns>The ordered permutations of n.</returns>
		public static IEnumerable<IList<int>> Permute(IList<int> n)
		{
			if (n.Count == 1)
			{
				yield return n;
			}
			for (var i = 0; i < n.Count; i++)
			{
				// Move ith element to front, permute remainder
				var m = new List<int>(n);
				m.RemoveAt(i);
				foreach (var b in Permute(m))
				{
					var a = new List<int>() { n[i] };
					yield return a.Concat(b).ToList();
				}
			}
		}
	}
}

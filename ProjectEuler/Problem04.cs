namespace ProjectEuler
{
	internal class Problem04 : Problem<int>
	{
		public Problem04() => N = 3;

		/// <returns>Largest palindrome product of two N-digit numbers</returns>
		public override int Solve()
		{
			// degree	range			steps
			// 1		[1-10)			9
			// 2		[10-100)		90
			// 3		[100-1000)		900
			// N		[1e(N-1)-1eN)	9e(N-1)

			var from = (int)Math.Pow(10, N - 1);
			var to = (int)Math.Pow(10, N);
			var terms = Enumerable.Range(from, to - from);

			return GetProducts(terms, terms).Where(IsPalindrome).Max();
		}

		public static IEnumerable<int> GetProducts(IEnumerable<int> a, IEnumerable<int> b)
		{
			foreach (var x in a)
			{
				foreach (var y in b)
				{
					yield return x * y;
				}
			}
		}

		public static bool IsPalindrome(int n)
		{
			var str = n.ToString(); // TODO: Reverse this and use same index for both... simpler!
			var idx = str.Length / 2;

			var a = str[0..idx];
			var b = str[(str.Length % 2 == 0 ? idx : idx + 1)..]; // ignore midpoint

			return string.Compare(a, string.Concat(b.Reverse())) == 0;
		}
	}
}

namespace ProjectEuler.Problems_00
{
	internal class Problem_04 : Problem
	{
		public int N = 3;

		public override string Solve() => SolveInternal().ToString();

		/// <returns>The largest palindrome product of two N-digit numbers.</returns>
		public int SolveInternal()
		{
			var from = (int)Math.Pow(10, N - 1);
			var to = (int)Math.Pow(10, N);
			var terms = Enumerable.Range(from, to - from);

			return GetProducts(terms, terms).Where(IsPalindrome).Max();
		}

		/// <returns>A sequence that contains the product of each term of a with each term of b.</returns>
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

		/// <returns>True if n is a palindrome; otherwise, false.</returns>
		public static bool IsPalindrome(int n)
		{
			var str = n.ToString();
			var idx = str.Length / 2; // trucates midpoint

			var a = str[0..idx];
			var b = string.Concat(str.Reverse())[0..idx];

			return string.Compare(a, b) == 0;
		}
	}
}

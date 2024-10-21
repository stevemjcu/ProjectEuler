namespace ProjectEuler.Problems;

public class Problem_0004 : Problem
{
	public int N = 3;

	/// <returns>The largest palindrome product of two N-digit numbers.</returns>
	public override object Solve()
	{
		var from = (int)Math.Pow(10, N - 1);
		var to = (int)Math.Pow(10, N);
		var terms = Enumerable
			.Range(from, to - from)
			.ToList();

		return GetProducts(terms, terms)
			.Where(i => Utils.IsPalindrome(i.ToString()))
			.Max();
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
}
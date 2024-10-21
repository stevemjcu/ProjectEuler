namespace ProjectEuler.Problems;

public class Problem_0036 : Problem
{
	public int N = 1000000;

	/// <returns>The sum of all numbers under N which are palindromic in both base 10 and base 2.</returns>
	public override object Solve()
	{
		return Enumerable.Range(0, N)
			.Where(i => Utils.IsPalindrome(i.ToString())) // base 10
			.Where(i => Utils.IsPalindrome(Convert.ToString(i, 2))) // base 2
			.Sum();
	}
}
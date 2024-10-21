namespace ProjectEuler.Problems;

internal class Problem_0034 : Problem
{
	private static readonly Dictionary<int, int> _cache = [];

	/// <returns>The sum of all numbers which are equal to the sum of the factorial of their digits.</returns>
	public override object Solve()
	{
		return Enumerable.Range(3, FindLimit()).Where(i => DigitFactorial(i) == i).Sum();
	}

	public static int FindLimit()
	{
		for (var i = 1; ; i++)
		{
			var x = (int)Math.Pow(10, i) - 1;
			if (DigitFactorial(x) < x) return x;
		}
	}

	public static int DigitFactorial(int x)
	{
		return Utils.ToDigits(x).Sum(Factorial);
	}

	public static int Factorial(int x)
	{
		if (_cache.TryGetValue(x, out var value)) return value;
		_cache.Add(x, Problem_0020.Factorial(x));
		return _cache[x];
	}
}


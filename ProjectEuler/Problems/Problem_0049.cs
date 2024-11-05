namespace ProjectEuler.Problems;

public class Problem_0049 : Problem
{
	public int N = 4; // digits
	public int M = 1487; // exclude

	/// <returns>The concatenated sequence of three 4-digit primes which are equally spaced and permutations of each other.</returns>
	public override object Solve()
	{
		var start = (int)Math.Pow(10, N - 1);
		var count = (int)Math.Pow(10, N) - start;
		var primes = Enumerable.Range(start, count).Where(Utils.IsPrime);
		var permutations = GetPermutations(primes.ToList());

		var result = new List<int>();
		_ = permutations.Where(l => HasSequence(l, out result) && l[0] != M).First();

		return long.Parse(
			result[0].ToString() +
			result[1].ToString() +
			result[2].ToString());
	}

	private static List<List<int>> GetPermutations(List<int> list)
	{
		var map = new Dictionary<int, List<int>>();
		foreach (var n in list)
		{
			var digits = Utils.ToDigits(n);
			digits.Sort();
			var key = (int)Utils.FromDigits(digits);
			map.TryGetValue(key, out var value);
			map[key] = [.. value ?? [], n];
		}
		return [.. map.Values];
	}

	private static bool HasSequence(List<int> permutations, out List<int> sequence)
	{
		sequence = [];
		for (var i = 0; i < permutations.Count; i++)
		{
			var a = permutations[i];
			for (var j = i + 1; j < permutations.Count; j++)
			{
				var b = permutations[j];
				var c = b + (b - a);
				if (!permutations.Contains(c)) continue;
				sequence = [a, b, c];
				return true;
			}
		}
		return false;
	}
}
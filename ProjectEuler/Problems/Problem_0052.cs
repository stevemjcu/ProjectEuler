namespace ProjectEuler.Problems;

public class Problem_0052 : Problem
{
	public int N = 6;

	/// <returns>The smallest integer x such that 2x through Nx contain the same digits.</returns>
	public override object Solve()
	{
		return Enumerable
			.Range(1, int.MaxValue)
			.Select(GenerateMultiples)
			.First(ContainSameDigits)
			.First();
	}

	/// <returns>The ordered sequence created by multiplying x by 1 through N.</returns>
	private IEnumerable<int> GenerateMultiples(int x)
	{
		for (var i = 1; i <= N; i++)
			yield return x * i;
	}

	/// <returns>True if each member of the sequence contain the same digits; otherwise, false.</returns>
	private static bool ContainSameDigits(IEnumerable<int> arr)
	{
		var set1 = Utils.ToDigits(arr.First()).ToHashSet();
		foreach (var x in arr.Skip(1))
		{
			var set2 = Utils.ToDigits(x).ToHashSet();
			if (!set1.SetEquals(set2)) return false;
		}
		return true;
	}
}
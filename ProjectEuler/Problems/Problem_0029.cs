using System.Numerics;

namespace ProjectEuler.Problems;

internal class Problem_0029 : Problem
{
	public int N = 100;

	/// <returns>The number of distinct terms in the sequence a^b for 2 &lt;= a &lt;= N and 2 &lt;= b &lt;= N.</returns>
	public override object Solve()
	{
		var terms = new HashSet<BigInteger>();
		for (var a = 2; a <= N; a++)
		{
			for (var b = 2; b <= N; b++)
			{
				terms.Add(BigInteger.Pow(a, b));
			}
		}
		return terms.Count;
	}
}


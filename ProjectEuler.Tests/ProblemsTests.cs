using ProjectEuler.Problems;

namespace ProjectEuler.Tests;

[TestClass]
public class ProblemsTests
{
	public static IEnumerable<object[]> Solutions =>
	[
		[new Problem_0001(), 233168],
		[new Problem_0002(), 4613732],
		[new Problem_0003(), 6857L],
		[new Problem_0004(), 906609],
		[new Problem_0005(), 232792560],
		[new Problem_0006(), 25164150],
		[new Problem_0007(), 104743],
		[new Problem_0008(), 23514624000],
		[new Problem_0009(), 31875000],
		[new Problem_0010(), 142913828922],
		[new Problem_0011(), 70600674],
		[new Problem_0012(), 76576500],
		[new Problem_0013(), 5537376230],
		[new Problem_0014(), 837799L],
		[new Problem_0015(), 137846528820],
		[new Problem_0016(), 1366],
		[new Problem_0017(), 21124],
		[new Problem_0018(), 1074],
		[new Problem_0019(), 171],
		[new Problem_0020(), 648],
		[new Problem_0021(), 31626],
		[new Problem_0022(), 871198282],
		[new Problem_0023(), 4179871],
		[new Problem_0024(), 2783915460L],
		[new Problem_0025(), 4782],
		[new Problem_0026(), 983],
		[new Problem_0027(), -59231],
		[new Problem_0028(), 669171001],
		[new Problem_0029(), 9183],
		[new Problem_0030(), 443839],
		[new Problem_0031(), 73682],
		[new Problem_0032(), 45228],
		[new Problem_0033(), 100],
		[new Problem_0034(), 40730],
		[new Problem_0035(), 55],
		[new Problem_0036(), 872187],
		[new Problem_0037(), 748317],
		[new Problem_0038(), 932718654],
		[new Problem_0039(), 840],
		[new Problem_0040(), 210],
		[new Problem_0041(), 7652413],
		[new Problem_0042(), 162],
		//[new Problem_0043(), 16695334890],
		[new Problem_0067(), 7273],
	];

	[TestMethod]
	[DynamicData(nameof(Solutions))]
	public void CheckSolutions(Problem problem, object expected)
	{
		Assert.AreEqual(expected, problem.Solve());
	}
}
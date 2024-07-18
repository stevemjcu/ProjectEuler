namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		public static IEnumerable<object[]> Solutions => [
			[new Problems.Problem_0001(), 233168],
			[new Problems.Problem_0002(), 4613732],
			[new Problems.Problem_0003(), 6857L],
			[new Problems.Problem_0004(), 906609],
			[new Problems.Problem_0005(), 232792560],
			[new Problems.Problem_0006(), 25164150],
			[new Problems.Problem_0007(), 104743],
			[new Problems.Problem_0008(), 23514624000],
			[new Problems.Problem_0009(), 31875000],
			[new Problems.Problem_0010(), 142913828922],
			[new Problems.Problem_0011(), 70600674],
			[new Problems.Problem_0012(), 76576500],
			[new Problems.Problem_0013(), 5537376230]
		];

		[TestMethod]
		[DynamicData(nameof(Solutions))]
		public void CheckSolutions(Problem problem, object expected)
		{
			Assert.AreEqual(expected, problem.Solve());
		}
	}
}
namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		public static IEnumerable<object[]> Solutions => [
			[typeof(Problems.Problem_01), "233168"],
			[typeof(Problems.Problem_02), "4613732"],
			[typeof(Problems.Problem_03), "6857"],
			[typeof(Problems.Problem_04), "906609"],
			[typeof(Problems.Problem_05), "232792560"],
			[typeof(Problems.Problem_06), "25164150"],
			[typeof(Problems.Problem_07), "104743"],
			[typeof(Problems.Problem_08), "23514624000"],
			[typeof(Problems.Problem_09), "31875000"],
			[typeof(Problems.Problem_10), "142913828922"],
		];

		[TestMethod]
		[DynamicData(nameof(Solutions))]
		public void CheckSolutions(Type type, string expected)
		{
			var problem = (Problem?)Activator.CreateInstance(type);
			Assert.AreEqual(expected, problem?.Solve());
		}
	}
}
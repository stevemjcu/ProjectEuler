namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		public static IEnumerable<object[]> Solutions_00 => [
			[typeof(Problems_00.Problem_01), "233168"],
			[typeof(Problems_00.Problem_02), "4613732"],
			[typeof(Problems_00.Problem_03), "6857"],
			[typeof(Problems_00.Problem_04), "906609"],
			[typeof(Problems_00.Problem_05), "232792560"],
			[typeof(Problems_00.Problem_06), "25164150"],
			[typeof(Problems_00.Problem_07), "104743"],
			[typeof(Problems_00.Problem_08), "23514624000"],
			[typeof(Problems_00.Problem_09), "31875000"],
			[typeof(Problems_00.Problem_10), "142913828922"],
		];

		[TestMethod]
		[DynamicData(nameof(Solutions_00))]
		public void CheckSolutions_00(Type type, string expected)
		{
			var problem = (Problem?)Activator.CreateInstance(type);
			Assert.AreEqual(expected, problem?.Solve());
		}
	}
}
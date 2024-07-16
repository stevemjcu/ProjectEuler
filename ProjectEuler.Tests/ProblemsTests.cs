namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		public static IEnumerable<object[]> Solutions => [
			[typeof(Problems.Problem_0001), "233168"],
			[typeof(Problems.Problem_0002), "4613732"],
			[typeof(Problems.Problem_0003), "6857"],
			[typeof(Problems.Problem_0004), "906609"],
			[typeof(Problems.Problem_0005), "232792560"],
			[typeof(Problems.Problem_0006), "25164150"],
			[typeof(Problems.Problem_0007), "104743"],
			[typeof(Problems.Problem_0008), "23514624000"],
			[typeof(Problems.Problem_0009), "31875000"],
			[typeof(Problems.Problem_0010), "142913828922"],
			[typeof(Problems.Problem_0011), "70600674"],
			[typeof(Problems.Problem_0012), "76576500"],
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
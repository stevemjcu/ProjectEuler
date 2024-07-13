namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		public static IEnumerable<object[]> Solutions => [
			[typeof(Problem01), 1000, 233168],
			[typeof(Problem02), 4000000, 4613732],
			[typeof(Problem03), 600851475143, 6857L],
			[typeof(Problem04), 3, 906609],
			[typeof(Problem05), 20, 232792560],
			[typeof(Problem06), 100, 25164150],
			[typeof(Problem07), 10001, 104743],
		];

		[TestMethod]
		[DynamicData(nameof(Solutions))]
		public void CheckSolutions(Type type, object n, object expected)
		{
			var problem = Activator.CreateInstance(type);
			var method = type.GetMethod("Solve");
			var actual = method?.Invoke(problem, [n]);

			Assert.AreEqual(expected, actual);
		}
	}
}
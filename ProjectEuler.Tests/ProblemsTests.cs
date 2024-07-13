namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		// TODO: Move to DataSource and slice arbitrarily.
		public static IEnumerable<object[]> Solutions00xx => [
			[typeof(Problems00xx.Problem01), 1000, 233168],
			[typeof(Problems00xx.Problem02), 4000000, 4613732],
			[typeof(Problems00xx.Problem03), 600851475143, 6857L],
			[typeof(Problems00xx.Problem04), 3, 906609],
			[typeof(Problems00xx.Problem05), 20, 232792560],
			[typeof(Problems00xx.Problem06), 100, 25164150],
			[typeof(Problems00xx.Problem07), 10001, 104743],
		];

		[TestMethod]
		[DynamicData(nameof(Solutions00xx))]
		public void CheckSolutions00xx(Type type, object n, object expected)
		{
			var problem = Activator.CreateInstance(type);
			var method = type.GetMethod("Solve");
			var actual = method?.Invoke(problem, [n]);

			Assert.AreEqual(expected, actual);
		}
	}
}
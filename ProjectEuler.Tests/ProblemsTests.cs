namespace ProjectEuler.Tests
{
	[TestClass]
	public class ProblemsTests
	{
		// TODO: Move to DataSource and slice arbitrarily.
		public static IEnumerable<object[]> Solutions_00 => [
			[typeof(Problems_00.Problem_01), 1000, 233168],
			[typeof(Problems_00.Problem_02), 4000000, 4613732],
			[typeof(Problems_00.Problem_03), 600851475143, 6857L],
			[typeof(Problems_00.Problem_04), 3, 906609],
			[typeof(Problems_00.Problem_05), 20, 232792560],
			[typeof(Problems_00.Problem_06), 100, 25164150],
			[typeof(Problems_00.Problem_07), 10001, 104743],
		];

		[TestMethod]
		[DynamicData(nameof(Solutions_00))]
		public void CheckSolutions_00(Type type, object n, object expected)
		{
			var problem = Activator.CreateInstance(type);
			var method = type.GetMethod("Solve");
			var actual = method?.Invoke(problem, [n]);

			Assert.AreEqual(expected, actual);
		}
	}
}
namespace ProjectEuler.Problems
{
	public class Problem_0067 : Problem
	{
		/// <returns>The maximum total from the top to the bottom of the triangle M.</returns>
		public override object Solve()
		{
			var problem = new Problem_0018() { Resource = Resource };
			return Problem_0018.GetMaxTotal(0, 0, problem.M, []);
		}
	}
}

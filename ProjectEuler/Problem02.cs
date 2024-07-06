namespace ProjectEuler
{
	internal class Problem02 : Problem
	{
		/// <returns>Sum of all even Fibonacci terms below N.</returns>
		public override int Solve()
		{
			// Enumerate terms
			var terms = new List<int>() { 1, 2 };
			while (true)
			{
				var x = terms[^1] + terms[^2];
				if (x >= N)
				{
					break;
				}
				terms.Add(x);
			}
			// Aggregate list
			return terms.FindAll(x => x % 2 == 0).Sum();
		}
	}
}

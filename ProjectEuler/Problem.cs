namespace ProjectEuler
{
	internal abstract class Problem
	{
		public int Index
		{
			get => int.Parse(GetType().Name.Replace("Problem_", string.Empty));
		}

		public abstract string Solve(string n);
	}
}

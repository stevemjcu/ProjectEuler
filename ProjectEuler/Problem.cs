namespace ProjectEuler
{
	internal abstract class Problem<T>
	{
		public int Index
		{
			get => int.Parse(GetType().Name.Replace("Problem", string.Empty));
		}

		public abstract T Solve(T n);
	}
}

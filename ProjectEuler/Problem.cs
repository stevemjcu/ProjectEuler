namespace ProjectEuler
{
	internal abstract class Problem<T>
	{
		protected virtual string ClassPrefix { get; } = "Problem";

		public int Index
		{
			get => int.Parse(GetType().Name.Replace(ClassPrefix, string.Empty));
		}

		public virtual T? N { get; set; }

		public abstract T Solve();
	}
}

namespace ProjectEuler
{
	internal abstract class Problem
	{
		protected virtual string ClassPrefix { get; } = typeof(Problem).Name;

		public int Index
		{
			get => int.Parse(GetType().Name.Replace(ClassPrefix, string.Empty));
		}

		public virtual int N { get; set; }

		public abstract int Solve();
	}
}

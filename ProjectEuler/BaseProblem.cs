namespace ProjectEuler
{
	internal abstract class BaseProblem
	{
		protected virtual string ClassPrefix { get; } = "Problem_";

		protected int Index { get => int.Parse(GetType().Name.Replace(ClassPrefix, string.Empty)); }

		public abstract string Solve();
	}
}

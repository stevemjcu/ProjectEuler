using ProjectEuler.Properties;
using System.Resources;

namespace ProjectEuler
{
	public abstract class Problem
	{
		public int Index;
		public string Resource = string.Empty;

		public Problem()
		{
			var name = GetType().Name;
			var resources = new ResourceManager(typeof(Resources));
			Index = int.Parse(name.Split("_").Last());
			Resource = resources.GetString(name) ?? string.Empty;
		}

		public abstract object Solve();
	}
}

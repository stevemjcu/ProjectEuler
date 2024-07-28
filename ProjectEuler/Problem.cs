using ProjectEuler.Properties;
using System.Resources;

namespace ProjectEuler;

public abstract class Problem
{
	protected Problem()
	{
		var name = GetType().Name;
		var resources = new ResourceManager(typeof(Resources));
		Index = int.Parse(name.Split("_").Last());
		Resource = resources.GetString(name) ?? string.Empty;
	}

	public int Index { get; init; }

	public string Resource { get; init; }

	public abstract object Solve();
}
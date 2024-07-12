using System.Numerics;

namespace ProjectEuler
{
	internal class Utilities
	{
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		public static IEnumerable<T> Range<T>(T start, T? count) where T : struct, INumber<T>
		{
			for (T l = start; count is null || l <= start + count; l++)
			{
				yield return l;
			}
		}
	}
}

using System.Numerics;

namespace ProjectEuler
{
	internal class Utilities
	{
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		public static IEnumerable<T> Range<T>(T start, T count) where T : INumber<T>
		{
			for (T l = start; l <= start + count; l++)
			{
				yield return l;
			}
		}

		/// <returns>A sequence that contains an infinite range of sequential numbers.</returns>
		public static IEnumerable<T> InfiniteRange<T>(T start) where T : INumber<T>
		{
			for (T i = start; ; i++)
			{
				yield return i;
			}
		}
	}
}

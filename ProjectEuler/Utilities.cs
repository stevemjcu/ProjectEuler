using System.Numerics;

namespace ProjectEuler
{
	internal static class Utilities
	{
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		public static IEnumerable<T> Range<T>(T start, T? count) where T : struct, INumber<T>
		{
			for (T l = start; count is null || l <= start + count; l++)
			{
				yield return l;
			}
		}

		/// <returns>A sequence that contains each consecutive sliding window within the source.</returns>
		public static IEnumerable<IEnumerable<T>> SlidingWindows<T>(this IEnumerable<T> source, int size) where T : struct, INumber<T>
		{
			while (true)
			{
				var window = source.Take(0..size);
				if (window.Count() < size)
				{
					break;
				}
				yield return window;
				source = source.Skip(1);
			}
		}
	}
}

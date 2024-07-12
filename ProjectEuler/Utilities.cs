namespace ProjectEuler
{
	internal class Utilities
	{
		/// <returns>A sequence that contains a range of sequential integral numbers.</returns>
		public static IEnumerable<long> LongRange(long start, long count)
		{
			for (long l = start; l <= start + count; l++)
			{
				yield return l;
			}
		}

		/// <returns>A sequence that contains an infinite range of sequential integral numbers.</returns>
		public static IEnumerable<int> InfiniteRange(int start)
		{
			for (int i = start; ; i++)
			{
				yield return i;
			}
		}
	}
}

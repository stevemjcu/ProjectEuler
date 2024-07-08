namespace ProjectEuler
{
	internal class Utilities
	{
		/// <returns>A sequence that contains a range of sequential integral numbers.</returns>
		public static IEnumerable<long> LongRange(long start, long count)
		{
			for (long l = start; l <= start + count; l += 1L)
			{
				yield return l;
			}
		}
	}
}

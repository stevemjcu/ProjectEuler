namespace ProjectEuler
{
	internal class Utilities
	{
		public static IEnumerable<int> Range(int from, int to)
		{
			for (int i = from; i <= to; i += 1)
			{
				yield return i;
			}
		}

		public static IEnumerable<long> Range(long from, long to)
		{
			for (long l = from; l <= to; l += 1L)
			{
				yield return l;
			}
		}
	}
}

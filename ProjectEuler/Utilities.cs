﻿using System.Numerics;

namespace ProjectEuler;

public static class Utilities
{
	/// <returns>A sequence that contains a range of sequential numbers.</returns>
	public static IEnumerable<T> Range<T>(T start, T? count) where T : struct, INumber<T>
	{
		for (var l = start; count is null || l < start + count; l++)
		{
			yield return l;
		}
	}

	/// <returns>A sequence that contains each consecutive sliding window within the source.</returns>
	public static IEnumerable<IEnumerable<T>> SlidingWindows<T>(this IEnumerable<T> source, int size)
		where T : struct, INumber<T>
	{
		while (true)
		{
			var window = source.Take(..size).ToList();
			if (window.Count() < size)
			{
				break;
			}
			yield return window;
			source = source.Skip(1);
		}
	}

	/// <returns>Computes the product of the sequence of values.</returns>
	public static T Product<T>(this IEnumerable<T> source) where T : struct, INumber<T>
	{
		return source.Aggregate(T.One, (acc, x) => acc * x);
	}

	/// <returns>A multidimensional array with n rows and m columns.</returns>
	public static T[,] ToRectangularArray<T>(this IEnumerable<T> source, int n, int m) where T : struct, INumber<T>
	{
		var target = new T[n, m];
		using var itr = source.GetEnumerator();
		for (var y = 0; y < n; y++)
		{
			for (var x = 0; x < m; x++)
			{
				if (!itr.MoveNext())
				{
					break;
				}
				target[y, x] = itr.Current;
			}
		}
		return target;
	}

	/// <returns>A multidimensional array whose rows are the reverse of the given array.</returns>
	public static T[,] ReverseRows<T>(this T[,] source) where T : struct, INumber<T>
	{
		var (n, m) = (source.GetLength(0), source.GetLength(1));
		var target = new T[n, m];
		for (var y = 0; y < n; y++)
		{
			for (var x = 0; x < m; x++)
			{
				target[y, x] = source[y, m - 1 - x];
			}
		}
		return target;
	}

	/// <returns>A positive value if a follows b lexicographically; otherwise, negative or zero.</returns>
	public static int CompareLexicographically<T>(T[] a, T[] b) where T : struct, IComparable
	{
		for (var i = 0; i < Math.Min(a.Length, b.Length); i++)
		{
			if (!a[i].Equals(b[i]))
			{
				return a[i].CompareTo(b[i]);
			}
		}
		return a.Length - b.Length;
	}
}
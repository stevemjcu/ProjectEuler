using System.Numerics;

namespace ProjectEuler;

public static class Utils
{
	/// <returns>A sequence that contains each consecutive sliding window within the source.</returns>
	public static IEnumerable<ArraySegment<T>> GetSlidingWindows<T>(this T[] source, int size)
	{
		for (var i = 0; i <= source.Length - size; i++)
		{
			yield return new ArraySegment<T>(source, i, size);
		}
	}

	/// <returns>Computes the product of the sequence of values.</returns>
	public static T Product<T>(this IEnumerable<T> source)
		where T : INumber<T>
	{
		return source.Aggregate(T.One, (acc, x) => acc * x);
	}

	/// <returns>A multidimensional array with n rows and m columns.</returns>
	public static T[,] ToRectangularArray<T>(this IEnumerable<T> source, int n, int m)
	{
		var target = new T[n, m];
		using var itr = source.GetEnumerator();
		for (var y = 0; y < n; y++)
		{
			for (var x = 0; x < m; x++)
			{
				if (!itr.MoveNext()) break;
				target[y, x] = itr.Current;
			}
		}
		return target;
	}

	/// <returns>A multidimensional array whose rows are the reverse of the given array.</returns>
	public static T[,] ReverseRows<T>(this T[,] source)
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
	public static int CompareLexicographically<T>(T[] a, T[] b)
		where T : IComparable
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

	/// <returns>A sequence that contains each digit in the number x.</returns>
	public static List<int> ToDigits<T>(T x)
		where T : IBinaryInteger<T>
	{
		var res = new List<int>();
		var ten = T.CreateTruncating(10);
		for (; x != T.Zero; x /= ten)
		{
			res.Add(int.CreateTruncating(x % ten));
		}
		res.Reverse();
		return res;
	}

	/// <returns>The number represented by the sequence x.</returns>
	public static T FromDigits<T>(IList<int> x)
		where T : IBinaryInteger<T>
	{
		var res = T.Zero;
		var place = T.CreateTruncating(Math.Pow(10, x.Count - 1));
		var ten = T.CreateTruncating(10);
		foreach (var i in x)
		{
			res += place * T.CreateTruncating(i);
			place /= ten;
		}
		return res;
	}

	/// <returns>The number of digits in the number x.</returns>
	public static int Length(this int x)
	{
		for (var i = 1; ; i++)
		{
			if (x < Math.Pow(10, i)) return i;
		}
	}

	/// <returns>A sequence that contains the factors of n in ascending order.</returns>
	public static IEnumerable<long> GetFactors(long n)
	{
		var factors = new Stack<long>();
		var limit = (long)Math.Sqrt(n);
		for (var i = 1L; i <= limit; i++)
		{
			if (n % i != 0) continue;
			if (n / i != i) factors.Push(i);
			yield return i;
		}
		foreach (var f in factors)
		{
			yield return n / f;
		}
	}

	/// <returns>A sequence that contains the prime factors of n.</returns>
	public static IList<long> GetPrimeFactors(long n)
	{
		var limit = (long)Math.Sqrt(n);
		for (var i = 2L; i <= limit; i++)
		{
			if (n % i != 0) continue;
			var a = GetPrimeFactors(i);
			var b = GetPrimeFactors(n / i);
			return [.. a, .. b];
		}
		return [n];
	}

	/// <returns>A sequence that contains the distinct prime factors of n.</returns>
	public static HashSet<long> GetDistinctPrimeFactors(long n)
	{
		var set = new HashSet<long>();
		GetDistinctPrimeFactors(n, set);
		return set;
	}

	private static void GetDistinctPrimeFactors(long n, HashSet<long> primes)
	{
		var limit = (long)Math.Sqrt(n);
		for (var i = 2L; i <= limit; i++)
		{
			if (n % i != 0) continue;
			GetDistinctPrimeFactors(i, primes);
			GetDistinctPrimeFactors(n / i, primes);
			return;
		}
		primes.Add(n);
	}

	/// <returns>The greatest common denominator of the numbers a and b.</returns>
	public static int GCD(int a, int b)
	{
		while (b > 0)
		{
			var r = a % b;
			(a, b) = (b, r);
		}
		return a;
	}

	/// <returns>The factorial of the number n.</returns>
	public static T Factorial<T>(T n)
		where T : IBinaryInteger<T>
	{
		var acc = T.One;
		for (var i = T.One; i <= n; i++)
		{
			acc *= i;
		}
		return acc;
	}

	/// <returns>True if the number n is prime; otherwise, false.</returns>
	public static bool IsPrime(int n) => IsPrime((long)n);

	/// <returns>True if the number n is prime; otherwise, false.</returns>
	public static bool IsPrime(long n)
	{
		var sqrt = (long)Math.Sqrt(n);
		for (var i = 2; i <= sqrt; i++)
		{
			if (n % i == 0) return false;
		}
		return n > 1;
	}

	/// <returns>True if the string s is a palindrome; otherwise, false.</returns>
	public static bool IsPalindrome(string s)
	{
		var idx = s.Length / 2; // truncates midpoint
		var a = s[..idx];
		var b = string.Concat(s.Reverse())[..idx];
		return string.CompareOrdinal(a, b) == 0;
	}

	/// <returns>True if x makes use of all digits a through b exactly once; otherwise, false.</returns>
	public static bool IsPandigital(int[] x, int a = 1, int b = 9)
	{
		var set = x.ToHashSet();
		if (set.Count != b) return false;
		for (var i = a; i <= b; i++)
		{
			if (!set.Contains(i)) return false;
		}
		return true;
	}

	/// <returns>A sequence that contains the ordered permutations of n.</returns>
	public static IEnumerable<T[]> GetPermutations<T>(T[] n)
	{
		if (n.Length == 1) yield return n;
		for (var i = 0; i < n.Length; i++)
		{
			// Move ith element to front, permute remainder
			var m = new List<T>(n);
			m.RemoveAt(i);
			foreach (var b in GetPermutations(m.ToArray()))
			{
				yield return [n[i], .. b];
			}
		}
	}

	/// <returns>The two roots of a second-order polynomial equation.</returns>
	public static (double, double) SolveQuadratic(double a, double b, double c)
	{
		var t1 = -b;
		var t2 = Math.Sqrt(b * b - (4 * a * c));
		var t3 = 2 * a;
		return ((t1 + t2) / t3, (t1 - t2) / t3);
	}
}

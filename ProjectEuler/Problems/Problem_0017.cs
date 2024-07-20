namespace ProjectEuler.Problems
{
	public class Problem_0017 : Problem
	{
		public static readonly Dictionary<int, string> Numbers = new() {
			{1, "one"},
			{2, "two"},
			{3, "three"},
			{4, "four"},
			{5, "five"},
			{6, "six"},
			{7, "seven"},
			{8, "eight"},
			{9, "nine"},
			{10, "ten"},
			{11, "eleven"},
			{12, "twelve"},
			{13, "thirteen"},
			{14, "fourteen"},
			{15, "fifteen"},
			{16, "sixteen"},
			{17, "seventeen"},
			{18, "eighteen"},
			{19, "nineteen"},
			{20, "twenty"},
			{30, "thirty"},
			{40, "forty"},
			{50, "fifty"},
			{60, "sixty"},
			{70, "seventy"},
			{80, "eighty"},
			{90, "ninety"},
		};

		public static readonly Dictionary<int, string> Places = new()
		{
			{2, "hundred"},
			{3, "thousand"},
			{6, "million"},
		};

		public int N = 1000;

		/// <returns>The number of letters needed to write out 1 through N.</returns>
		public override object Solve()
		{
			return Enumerable
				.Range(1, N)
				.Select(ToWords)
				.Select(s => s.Select(i => i.Length).Sum())
				.Sum();
		}

		public static IEnumerable<string> ToWords(int n)
		{
			var words = ToWordsRecursive(n).ToList();
			if (words.Any(Places.ContainsValue))
			{
				var i = words.LastIndexOf(words.Last(Places.ContainsValue));
				if (i < words.Count - 1)
				{
					words.Insert(i + 1, "and");
				}
			}
			//Console.WriteLine(string.Join(" ", words));
			return words;
		}

		public static IEnumerable<string> ToWordsRecursive(int n)
		{
			if (n == 0)
			{
				return [];
			}

			var place = n.ToString().Length - 1;
			var divisor = (int)Math.Pow(10, place);
			if (place % 3 == 1 && n / divisor == 1)
			{
				divisor /= 10;
			}

			var current = n / divisor;
			var remainder = n % divisor;
			if (place % 3 == 1 && current < 10)
			{
				current *= 10;
			}

			var words = new List<string>() { Numbers[current] };
			if (Places.TryGetValue(place, out var value))
			{
				words.Add(value);
			}
			words.AddRange(ToWordsRecursive(remainder));
			return words;
		}
	}
}

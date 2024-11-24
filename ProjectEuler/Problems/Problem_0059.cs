namespace ProjectEuler.Problems;

public class Problem_0059 : Problem
{
	public int N = 3;
	private static readonly string[] _words = ["that", "with", "this"];

	/// <returns>
	/// The sum of the decrypted ASCII values in the encrypted cipher, knowing that the encryption 
	/// key is N lower case characters long and that the message contains common English words.
	/// </returns>
	public override object Solve()
	{
		// Enumerate possible encryption keys
		// Select decrypted messages
		// Find message with common english words (?) <- split by spaces and look for words like "the"?
		// Summate message

		// each letter can be a..z (27 possibilities)
		// repeats are permissible, e.g., aaa

		// length n = 3
		// base b = 2
		// permutations p = 2^3 = 8

		// 000
		// 001
		// 010
		// 011
		// 100
		// 101
		// 110
		// 111

		// so if b = 27, p = 27^3 = 19,683 possible keys
		// permutations(abc) = permutations(a) x permutations(bc)
		// permutations(bc) = permtuations(b) x permutations(c)

		var cipher = Resource
			.Split(",")
			.Select(i => (char)int.Parse(i))
			.ToArray();

		foreach (var key in GenerateKeys(N))
		{
			var message = Decrypt(new(cipher), key);
			if (message.Split(" ").Any(word => _words.Contains(word)))
				return message.Select(c => (int)c).Sum();
		}
		return 0;
	}

	/// <returns>The sequence of possible n-length lower case encryption keys.</returns>
	public static IEnumerable<string> GenerateKeys(int n)
	{
		if (n == 1)
			for (var i = 0; i < 27; i++)
				yield return new([(char)('a' + i)]);
		else
			foreach (var a in GenerateKeys(1))
				foreach (var b in GenerateKeys(n - 1))
					yield return new([.. a, .. b]);
	}

	/// <returns>The decrypted message produced from the given cipher and key.</returns>
	public static string Decrypt(string cipher, string key)
	{
		var message = new char[cipher.Length];
		for (var i = 0; i < cipher.Length; i++)
		{
			var a = cipher[i];
			var b = key[i % key.Length];
			message[i] = (char)(a ^ b);
		}
		return new(message);
	}
}
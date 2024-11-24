namespace ProjectEuler.Problems;

public class Problem_0059 : Problem
{
	public int N = 3;

	/// <returns>
	/// The sum of the decrypted ASCII values in the encrypted cipher, knowing that the encryption 
	/// key is N lower case characters long and that the message contains common English words.
	/// </returns>
	public override object Solve()
	{
		var cipher = Resource
			.Split(",")
			.Select(i => (char)int.Parse(i))
			.ToArray();

		var message = Decrypt(new(cipher), GenerateKeys(N));
		return message.Select(c => (int)c).Sum();
	}

	/// <returns>The sequence of 27^n n-length lower case encryption keys.</returns>
	private static IEnumerable<string> GenerateKeys(int n)
	{
		if (n == 1)
			for (var i = 0; i < 27; i++)
				yield return new([(char)('a' + i)]);
		else
			foreach (var a in GenerateKeys(1))
				foreach (var b in GenerateKeys(n - 1))
					yield return new([.. a, .. b]);
	}

	/// <returns>The decrypted message produced from the given cipher and keys.</returns>
	private static string Decrypt(string cipher, IEnumerable<string> keys)
	{
		//foreach (var key in keys)
		//{
		//	var message = Decrypt(new(cipher), key);
		//	if (message
		//		.Split(" ")
		//		.Any(word => ["that", "with", "this"].Contains(word)))
		//		return message;
		//}
		//return string.Empty;

		// Worse best case but same worst case and better guarantee?
		var key = keys.MaxBy(k => Decrypt(cipher, k).Count(c => c == ' '));
		return key == null ? string.Empty : Decrypt(cipher, key);
	}

	/// <returns>The decrypted message produced from the given cipher and key.</returns>
	private static string Decrypt(string cipher, string key)
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
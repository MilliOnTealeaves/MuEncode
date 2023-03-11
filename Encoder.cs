using System.Security.Cryptography;

namespace MuEncode;
class Encoder
{
	/// <summary>
	/// Dictionary with alphanumeric characters mapped to morse code
	/// </summary>
	public static Dictionary<char, string> MorseF = new();

	/// <summary>
	/// Dictionary with morse code mapped to alphanumeric characters.
	/// Reverse of <c>MorseF</c>
	/// </summary>
	public static Dictionary<string, char> MorseT = new();

	/// <summary>
	/// List of available characters, filled using MorseF
	/// </summary>
	public static string aChr = "";


	/// <summary>
	/// Adds data to the <c>MorseT</c> and <c>MorseF</c> dictionaries
	/// </summary>
	/// 
	public static void InitializeMorse()
	{
		// Fill Morse dictionary
		// SPACE
		MorseF.Add(' ', "/");

		// LETTERS
		MorseF.Add('a', ".-");
		MorseF.Add('b', "-...");
		MorseF.Add('c', "-.-.");
		MorseF.Add('d', "-..");
		MorseF.Add('e', ".");
		MorseF.Add('f', "..-.");
		MorseF.Add('g', "--.");
		MorseF.Add('h', "....");
		MorseF.Add('i', "..");
		MorseF.Add('j', ".---");
		MorseF.Add('k', "-.-");
		MorseF.Add('l', ".-..");
		MorseF.Add('m', "--");
		MorseF.Add('n', "-.");
		MorseF.Add('o', "---");
		MorseF.Add('p', ".--.");
		MorseF.Add('q', "--.-");
		MorseF.Add('r', ".-.");
		MorseF.Add('s', "...");
		MorseF.Add('t', "-");
		MorseF.Add('u', "..-");
		MorseF.Add('v', "...-");
		MorseF.Add('w', ".--");
		MorseF.Add('x', "-..-");
		MorseF.Add('y', "-.--");
		MorseF.Add('z', "--..");

		// NUMBERS
		MorseF.Add('1', ".----");
		MorseF.Add('2', "..---");
		MorseF.Add('3', "...--");
		MorseF.Add('4', "....-");
		MorseF.Add('5', ".....");
		MorseF.Add('6', "-....");
		MorseF.Add('7', "--...");
		MorseF.Add('8', "---..");
		MorseF.Add('9', "----.");
		MorseF.Add('0', "-----");

		// PUNCTUATION
		MorseF.Add('.', ".-.-.-");
		MorseF.Add(',', "--..--");
		MorseF.Add('?', "..--..");
		MorseF.Add('\'', ".----.");
		MorseF.Add('!', "-.-.--");
		MorseF.Add('/', "-..-.");
		MorseF.Add('(', "-.--.");
		MorseF.Add(')', "-.--.-");
		MorseF.Add('&', ".-...");
		MorseF.Add(':', "---...");
		MorseF.Add(';', "-.-.-.");
		MorseF.Add('=', "-...-");
		MorseF.Add('+', ".-.-.");
		MorseF.Add('-', "-....-");
		MorseF.Add('_', "..--.-");
		MorseF.Add('\"', ".-..-.");
		MorseF.Add('$', "...-..-");
		MorseF.Add('@', ".--.-.");

		// Fill reverse dictionary (MorseT) and AvailableChars list
		// Add opposite key-value pair for each existing in MorseF
		// Add encodable keys to list of total available keys
		foreach (KeyValuePair<char, string> kvp in MorseF)
		{
			MorseT.Add(kvp.Value, kvp.Key);
			aChr += kvp.Key;
		}
	}

	/// <summary>
	/// Encrypts a string with AES encryption, given a key and IV.
	/// </summary>
	/// <param name="inStr">String to be encrypted</param>
	/// <param name="key">Encryption Key</param>
	/// <param name="IV">Initialization Vector</param>
	/// <returns>A cipher represenetd as a byte[]</returns>
	private static byte[] AesEncrypt(string inStr, byte[] key, byte[] IV)
	{
		using Aes a = Aes.Create();
		a.Key = key;
		a.IV = IV;
		ICryptoTransform encryptor = a.CreateEncryptor(a.Key, a.IV);

		using MemoryStream msEncrypt = new();
		using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
		using (StreamWriter swEncrypt = new(csEncrypt))
			swEncrypt.Write(inStr);
		return msEncrypt.ToArray();
	}

	/// <summary>
	/// Decrypts a string with AES encryption, given a key and IV.
	/// </summary>
	/// <param name="inText">Cipher to be decrypted</param>
	/// <param name="key">Encryption Key</param>
	/// <param name="IV">Initialization Vector</param>
	/// <returns>A string of decrypted text</returns>
	private static string AesDecrypt(byte[] inText, byte[] key, byte[] IV)
	{
		using Aes a = Aes.Create();
		a.Key = key;
		a.IV = IV;
		ICryptoTransform decryptor = a.CreateDecryptor(a.Key, a.IV);

		string output;
		using MemoryStream msDecrypt = new(inText);
		using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
		using (StreamReader srDecrypt = new(csDecrypt))
			output = srDecrypt.ReadToEnd();
		return output;
	}

	public static string AES(string inStr, byte[] key, byte[] IV, bool encode)
	{
		if (encode)
		{
			return Convert.ToBase64String(AesEncrypt(inStr, key, IV));
		}
		else
		{
			return AesDecrypt(Convert.FromBase64String(inStr), key, IV);
		}
	}

	public static string CharShift(string inStr, bool encode)
	{
		char[] input = inStr.ToLower().ToCharArray();
		int charIndex;
		int s;
		if (encode)
		{
			Random rand = new();
			s = rand.Next(1, aChr.Length);
		}
		else
		{
			try
			{
				s = int.Parse(inStr[0..2]) * -1;
			}
			catch
			{
				s = 0;
			}
		}
		for (int i = 0; i < input.Length; i++)
		{
			if (aChr.IndexOf(input[i]) != -1)
			{
				charIndex = aChr.IndexOf(input[i]) + s;
				if (aChr.IndexOf(input[i]) + s >= aChr.Length)
					charIndex -= aChr.Length;
				if (aChr.IndexOf(input[i]) + s < 0)
					charIndex += aChr.Length;
				input[i] = aChr[charIndex];
			}
		}
		inStr = "";
		foreach (char c in input)
		{
			inStr += c;
		}
		if (encode)
		{
			if (s >= 10)
				return inStr.Insert(0, "" + s);
			else
				return inStr.Insert(0, "0" + s);
		}
		else
		{
			return inStr[2..];
		}
	}

	public static string MultiShift(string inStr, bool encode)
	{
		for (int i = 0; i < 5; i++)
		{
			inStr = CharShift(inStr, encode);
		}
		return inStr;
	}

	/// <summary>
	/// Converts between Morse Code and plain text.
	/// </summary>
	/// <param name="encIn">Input</param>
	/// <param name="error">Indicades whether or not an error has occured</param>
	/// <param name="encode">Determines the mode of the encoder. True encodes, false decodes</param>
	/// <returns></returns>
	public static string MorseCode(string encIn, out bool error, bool encode)
	{
		encIn = encIn.ToLower();
		string encOut = "";
		error = false;

		// ENCODE
		if (encode)
		{
			for (int i = 0; i < encIn.Length; i++)
			{
				try
				{
					encOut += MorseF[encIn[i]] + " ";
				}
				catch (KeyNotFoundException)
				{
					// bypass this character, don't decode it
					encOut += encIn[i] + " ";
					// let Main know that an error has occured
					error = true;
				}
			}
		}
		// DECODE
		else
		{
			encIn = encIn.Trim() + " ";
			while (encIn.Length > 1)
			{
				// current morse code sequence, one character long.
				string currentChar = encIn[..encIn.IndexOf(' ')];
				try
				{
					encOut += MorseT[currentChar];
				}
				catch (KeyNotFoundException)
				{
					// bypass this character, don't decode it
					encOut += currentChar + " ";
				}
				encIn = encIn.Remove(0, encIn.IndexOf(' ') + 1);
			}
		}

		return encOut;
	}
}
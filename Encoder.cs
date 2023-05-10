using System.Security.Cryptography;

namespace MuEncode;
class Encoder : IDisposable
{
	private ErrorStream _errorStream;

	private static bool _loaded;

	/// <summary>
	/// Dictionary with alphanumeric characters mapped to morse code
	/// </summary>
	private static Dictionary<char, string> _toMorse = new();

	/// <summary>
	/// Dictionary with morse code mapped to alphanumeric characters.
	/// Reverse of <c>MorseF</c>
	/// </summary>
	private static Dictionary<string, char> _fromMorse = new();

	public Encoder(ErrorStream e)
	{
		_errorStream = e;
	}

	static Encoder()
	{
		InitializeMorse();
	}

	public void Dispose() { }

	/// <summary>
	/// Adds data to the <c>MorseT</c> and <c>MorseF</c> dictionaries
	/// </summary>
	///
	private static void InitializeMorse()
	{
		// Fill Morse dictionary
		// SPACE
		_toMorse.Add(' ', "/");

		// LETTERS
		_toMorse.Add('a', ".-");
		_toMorse.Add('b', "-...");
		_toMorse.Add('c', "-.-.");
		_toMorse.Add('d', "-..");
		_toMorse.Add('e', ".");
		_toMorse.Add('f', "..-.");
		_toMorse.Add('g', "--.");
		_toMorse.Add('h', "....");
		_toMorse.Add('i', "..");
		_toMorse.Add('j', ".---");
		_toMorse.Add('k', "-.-");
		_toMorse.Add('l', ".-..");
		_toMorse.Add('m', "--");
		_toMorse.Add('n', "-.");
		_toMorse.Add('o', "---");
		_toMorse.Add('p', ".--.");
		_toMorse.Add('q', "--.-");
		_toMorse.Add('r', ".-.");
		_toMorse.Add('s', "...");
		_toMorse.Add('t', "-");
		_toMorse.Add('u', "..-");
		_toMorse.Add('v', "...-");
		_toMorse.Add('w', ".--");
		_toMorse.Add('x', "-..-");
		_toMorse.Add('y', "-.--");
		_toMorse.Add('z', "--..");

		// NUMBERS
		_toMorse.Add('1', ".----");
		_toMorse.Add('2', "..---");
		_toMorse.Add('3', "...--");
		_toMorse.Add('4', "....-");
		_toMorse.Add('5', ".....");
		_toMorse.Add('6', "-....");
		_toMorse.Add('7', "--...");
		_toMorse.Add('8', "---..");
		_toMorse.Add('9', "----.");
		_toMorse.Add('0', "-----");

		// PUNCTUATION
		_toMorse.Add('.', ".-.-.-");
		_toMorse.Add(',', "--..--");
		_toMorse.Add('?', "..--..");
		_toMorse.Add('\'', ".----.");
		_toMorse.Add('!', "-.-.--");
		_toMorse.Add('/', "-..-.");
		_toMorse.Add('(', "-.--.");
		_toMorse.Add(')', "-.--.-");
		_toMorse.Add('&', ".-...");
		_toMorse.Add(':', "---...");
		_toMorse.Add(';', "-.-.-.");
		_toMorse.Add('=', "-...-");
		_toMorse.Add('+', ".-.-.");
		_toMorse.Add('-', "-....-");
		_toMorse.Add('_', "..--.-");
		_toMorse.Add('\"', ".-..-.");
		_toMorse.Add('$', "...-..-");
		_toMorse.Add('@', ".--.-.");

		// Fill reverse dictionary (MorseT) and AvailableChars list
		// Add opposite key-value pair for each existing in MorseF
		// Add encodable keys to list of total available keys
		foreach (KeyValuePair<char, string> kvp in _toMorse)
		{
			_fromMorse.Add(kvp.Value, kvp.Key);
		}
	}

	#region AES Methods

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

	public string AES(string inStr, byte[] key, byte[] IV, bool encode)
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

	#endregion

	#region Morse Code Methods

	public string CharShift(string inStr, bool encode)
	{
		char[] input = inStr.ToLower().ToCharArray();
		int charIndex;
		int s;
		if (encode)
		{
			Random rand = new();
			s = rand.Next(1, _toMorse.Count - 1);
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
		List<char> keys = new(_toMorse.Keys);

		for (int i = 0; i < input.Length; i++)
		{
			if (keys.Contains(input[i]))
			{
				charIndex = keys.IndexOf(input[i]) + s;

				if (keys.IndexOf(input[i]) + s >= keys.Count)
					charIndex -= keys.Count;
				if (keys.IndexOf(input[i]) + s < 0)
					charIndex += keys.Count;
				input[i] = keys[charIndex];
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

	public string MultiShift(string inStr, bool encode)
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
	/// <param name="encode">Determines the mode of the encoder. True encodes, false decodes</param>
	/// <param name="error">Indicades whether or not an error has occured</param>
	/// <returns></returns>
	public string MorseCode(string encIn, bool encode, out bool error)
	{
		List<string> illegalChars = new();
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
					encOut += _toMorse[encIn[i]] + " ";
				}
				catch (KeyNotFoundException)
				{
					if (encIn[i] == '\n' && encIn[i - 1] == '\r')
					{
						encOut += "\r\n";
					}
					else if (encIn[i] != '\r')
					{
						// bypass this character, don't decode it
						encOut += encIn[i] + " ";
						illegalChars.Add("" + encIn[i]);
						// let Main know that an error has occured
						error = true;
					}
				}
			}
		}
		// DECODE
		else
		{
			encIn = encIn.Trim() + " ";
			for (int i = 1; i < encIn.Length; i++)
			{
				if (encIn[i] == '\r' && encIn[i - 1] != ' ')
				{
					encIn = encIn.Insert(i, " ");
					i++;
				}
			}
			while (encIn.Length > 1)
			{
				// current morse code sequence, one character long.
				string currentChar;
				if (encIn[0] != '\r')
				{
					currentChar = encIn[..encIn.IndexOf(' ')];
					try
					{
						encOut += _fromMorse[currentChar];
					}
					catch (KeyNotFoundException)
					{
						if (currentChar == "\r\n")
						{
							encOut += "\r\n";
						}
						else
						{
							encOut += currentChar + " ";
							illegalChars.Add(currentChar);
							// bypass this character, don't decode it
							error = true;
						}
					}
					encIn = encIn.Remove(0, encIn.IndexOf(' ') + 1);
				}
				else
				{
					encOut += "\r\n";
					encIn = encIn.Remove(0, encIn.IndexOf('\n') + 1);
				}
			}
		}

		if (error == true) _errorStream.Write(new IllegalCharacterError(illegalChars));
		return encOut;
	}
	public string MorseCode(string encIn, bool encode)
	{
		return MorseCode(encIn, encode, out _);
	}

	#endregion
}
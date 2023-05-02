using System.Security.Cryptography;

namespace MuEncode;
class Encoder : IDisposable
{
	public void Dispose() { }

	private ErrorStream _errorStream;

	public Encoder(ErrorStream e) { _errorStream = e; }

	/// <summary>
	/// Dictionary with alphanumeric characters mapped to morse code
	/// </summary>
	private static Dictionary<char, string> _morseF = new();

	/// <summary>
	/// Dictionary with morse code mapped to alphanumeric characters.
	/// Reverse of <c>MorseF</c>
	/// </summary>
	private static Dictionary<string, char> _morseT = new();

	/// <summary>
	/// List of available characters, filled using MorseF
	/// </summary>
	private static string _aChr = "";


	/// <summary>
	/// Adds data to the <c>MorseT</c> and <c>MorseF</c> dictionaries
	/// </summary>
	/// 
	public static void InitializeMorse()
	{
		// Fill Morse dictionary
		// SPACE
		_morseF.Add(' ', "/");

		// LETTERS
		_morseF.Add('a', ".-");
		_morseF.Add('b', "-...");
		_morseF.Add('c', "-.-.");
		_morseF.Add('d', "-..");
		_morseF.Add('e', ".");
		_morseF.Add('f', "..-.");
		_morseF.Add('g', "--.");
		_morseF.Add('h', "....");
		_morseF.Add('i', "..");
		_morseF.Add('j', ".---");
		_morseF.Add('k', "-.-");
		_morseF.Add('l', ".-..");
		_morseF.Add('m', "--");
		_morseF.Add('n', "-.");
		_morseF.Add('o', "---");
		_morseF.Add('p', ".--.");
		_morseF.Add('q', "--.-");
		_morseF.Add('r', ".-.");
		_morseF.Add('s', "...");
		_morseF.Add('t', "-");
		_morseF.Add('u', "..-");
		_morseF.Add('v', "...-");
		_morseF.Add('w', ".--");
		_morseF.Add('x', "-..-");
		_morseF.Add('y', "-.--");
		_morseF.Add('z', "--..");

		// NUMBERS
		_morseF.Add('1', ".----");
		_morseF.Add('2', "..---");
		_morseF.Add('3', "...--");
		_morseF.Add('4', "....-");
		_morseF.Add('5', ".....");
		_morseF.Add('6', "-....");
		_morseF.Add('7', "--...");
		_morseF.Add('8', "---..");
		_morseF.Add('9', "----.");
		_morseF.Add('0', "-----");

		// PUNCTUATION
		_morseF.Add('.', ".-.-.-");
		_morseF.Add(',', "--..--");
		_morseF.Add('?', "..--..");
		_morseF.Add('\'', ".----.");
		_morseF.Add('!', "-.-.--");
		_morseF.Add('/', "-..-.");
		_morseF.Add('(', "-.--.");
		_morseF.Add(')', "-.--.-");
		_morseF.Add('&', ".-...");
		_morseF.Add(':', "---...");
		_morseF.Add(';', "-.-.-.");
		_morseF.Add('=', "-...-");
		_morseF.Add('+', ".-.-.");
		_morseF.Add('-', "-....-");
		_morseF.Add('_', "..--.-");
		_morseF.Add('\"', ".-..-.");
		_morseF.Add('$', "...-..-");
		_morseF.Add('@', ".--.-.");

		// Fill reverse dictionary (MorseT) and AvailableChars list
		// Add opposite key-value pair for each existing in MorseF
		// Add encodable keys to list of total available keys
		foreach (KeyValuePair<char, string> kvp in _morseF)
		{
			_morseT.Add(kvp.Value, kvp.Key);
			_aChr += kvp.Key;
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

	public string CharShift(string inStr, bool encode)
	{
		char[] input = inStr.ToLower().ToCharArray();
		int charIndex;
		int s;
		if (encode)
		{
			Random rand = new();
			s = rand.Next(1, _aChr.Length);
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
			if (_aChr.IndexOf(input[i]) != -1)
			{
				charIndex = _aChr.IndexOf(input[i]) + s;
				if (_aChr.IndexOf(input[i]) + s >= _aChr.Length)
					charIndex -= _aChr.Length;
				if (_aChr.IndexOf(input[i]) + s < 0)
					charIndex += _aChr.Length;
				input[i] = _aChr[charIndex];
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

	public string MorseCode(string encIn, bool encode)
	{
		return MorseCode(encIn, encode, out _);
	}

	/// <summary>
	/// Converts between Morse Code and plain text.
	/// </summary>
	/// <param name="encIn">Input</param>
	/// <param name="error">Indicades whether or not an error has occured</param>
	/// <param name="encode">Determines the mode of the encoder. True encodes, false decodes</param>
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
					encOut += _morseF[encIn[i]] + " ";
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
						encOut += _morseT[currentChar];
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
}
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
			return inStr.Substring(2);
		}
	}

	public static string MultiShift(string inStr, bool encode)
	{
		Random r = new();
		for (int i = 0; i < 5; i++)
		{
			inStr = CharShift(inStr, encode);
		}
		return inStr;
	}

	/// <summary>
	/// Convert Text to Morse code
	/// </summary>
	/// <param name="encIn">Text input to be converted</param>
	/// <param name="error">IO variable, provides info to <c>Main</c> about input errors encountered</param>
	/// <returns>Return is morse code converted from text</returns>
	public static string ToMorse(string encIn, out bool error)
	{
		string encOut = "";
		encIn = encIn.ToLower();
		error = false;
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
				// lets Main know that an error has occured
				error = true;
			}
		}
		return encOut;
	}

	/// <summary>
	/// Convert Morse code to Text
	/// </summary>
	/// <param name="encIn">Morse code input</param>
	/// <param name="error">IO variable, provides info to <c>Main</c> about illegal characters encountered in input</param>
	/// <returns>Return is alphanumeric text conveted from Morse</returns>
	public static string FromMorse(string encIn, out bool error)
	{

		error = false;
		encIn = encIn.ToLower();
		encIn = encIn.Trim() + " ";
		string encOut = "";
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
				error = true;
			}
			encIn = encIn.Remove(0, encIn.IndexOf(' ') + 1);
		}
		return encOut;
	}
}
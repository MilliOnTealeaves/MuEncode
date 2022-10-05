using System;
using System.Collections.Generic;

namespace EncodeDecode;

class Encoder
{
	public static Dictionary<char, string> MorseF = new Dictionary<char, string>();
	public static Dictionary<string, char> MorseT = new Dictionary<string, char>();

	public static void LoadMorse()
	{
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

		foreach ( KeyValuePair<char, string> kvp in MorseF)
		{
			MorseT.Add(kvp.Value, kvp.Key);
		}
	}	

	public static string ToMorse(string encIn)
	{
		encIn = encIn.ToLower();
		string encOut = "";
		for (int i = 0; i < encIn.Length; i++)
		{
			encOut += MorseF[encIn[i]] + " ";
		}
		return encOut;
	}
	public static string FromMorse(string encIn)
	{
		encIn = encIn.ToLower();
		encIn = encIn.Trim() + " ";
		string encOut = "";
		while (encIn.Length > 1)
		{
			try
			{
				string thisChar = encIn.Substring(0, encIn.IndexOf(' '));
				encOut += MorseT[thisChar];
				encIn = encIn.Remove(0, encIn.IndexOf(' ')+1);
			}
			catch {break;}
				
		}
		return encOut;
	}
}
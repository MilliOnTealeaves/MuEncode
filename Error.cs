namespace MuEncode;
public class Error
{
	private string _message;
	public string Message { get { return _message; } }

	public Error() { _message = ""; }

	public Error(string message)
	{
		_message = message;
	}

	public override string ToString()
	{
		return _message + " ";
	}
}

public class IllegalCharacterError : Error
{
	private List<string> _illegalChars;
	public List<string> IllegalChars { get { return _illegalChars; } }

	public IllegalCharacterError(List<string>? illegalChars) : this("", illegalChars) { }
	public IllegalCharacterError(string message, List<string>? illegalChars) : base(message)
	{
		if (illegalChars != null) _illegalChars = illegalChars; else _illegalChars = new List<string>();
	}

	public override string ToString()
	{
		string result = "Encountered Illegal Characters: ";
		for (int i = 0; i < _illegalChars.Count - 1; i++)
		{
			result += string.Format("[{0}], ", _illegalChars[i]);
		}
		result += string.Format("[{0}] ", _illegalChars[_illegalChars.Count - 1]);
		return result + Message;
	}
}

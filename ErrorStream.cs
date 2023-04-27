using System.Media;

namespace MuEncode;
public class ErrorStream
{
	public bool Beep { get; set; }

	private Control? _stream;
	public Control Stream { set { _stream = value; } }

	private List<Error> _errors;

	public ErrorStream(Control stream)
	{
		if (stream is Label || stream is TextBoxBase)
		{
			_stream = stream;
			_stream.Text = "";
		}
		else _stream = null;
		_errors = new();
	}

	public ErrorStream(Control stream, bool beep) : this(stream)
	{
		Beep = beep;
	}

	public void Write(Error error)
	{
		if (_stream != null) _stream.Text += error.ToString() + "; ";
		_errors.Add(error);
		if (Beep) SystemSounds.Beep.Play();
	}
	public void Write(string text)
	{
		if (_stream != null) _stream.Text += text + "; ";
		_errors.Add(new Error(text));
		if (Beep) SystemSounds.Beep.Play();
	}

	public void WriteLine(Error error)
	{
		if (_stream != null) _stream.Text += error.ToString() + "\n";
		_errors.Add(error);
		if (Beep) SystemSounds.Beep.Play();
	}
	public void WriteLine(string text)
	{
		if (_stream != null) _stream.Text += text + "\n";
		_errors.Add(new Error(text));
		if (Beep) SystemSounds.Beep.Play();
	}

	public override string ToString()
	{
		string result = "";
		foreach (Error e in _errors) result += e.ToString();
		return result;
	}
}


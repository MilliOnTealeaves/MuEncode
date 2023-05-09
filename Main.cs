using System.Security.Cryptography;

namespace MuEncode;
public partial class Main : Form
{
	public ErrorStream err;
	public Main()
	{
		InitializeComponent();
		WindowExpanded = false;
		err = new ErrorStream(label_Note);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		label_Note.Text = "";
		radio_Encode.Checked = true;
		textbox_Input.PlaceholderText = "Input message to be encoded";
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		label_Note.Text = "Easter Egg! ( )";
		System.Media.SystemSounds.Beep.Play();
	}

	// When either radio button is checked, change the placeholder text
	private void EncodeCheckedChanged(object sender, EventArgs e)
	{
		if (radio_Encode.Checked)
		{
			textbox_Input.PlaceholderText = "Type message to be encoded";
		}
	}

	private void DecodeCheckedChanged(object sender, EventArgs e)
	{
		if (radio_Decode.Checked)
		{
			textbox_Input.PlaceholderText = "Type message to be decoded";
			if (comboBox1.SelectedIndex == 3)
				ExpandWindow();
		}
	}

	/// <summary>
	/// Main part of the program, runs when the "Run" button is clicked
	/// </summary>
	private void RunClicked(object sender, EventArgs e)
	{
		bool encode = radio_Encode.Checked;
		label_Note.Text = "";
		string output = textbox_Input.Text;
		// check for empty input
		if (string.IsNullOrEmpty(output.Trim()))
		{
			label_Note.Text = "Input is empty, please try again";
			return;
		}
		if (comboBox1.SelectedIndex == -1)
		{
			label_Note.Text = "Please select a mode";
		}
		using (Encoder enc = new(err))
		{
			// if encode is checked
			if (encode)
			{
				// morse code operations
				if (comboBox1.SelectedIndex < 3)
				{
					if (comboBox1.SelectedIndex == 1)
						output = enc.CharShift(output, encode);
					if (comboBox1.SelectedIndex == 2)
						output = enc.MultiShift(output, encode);
					output = enc.MorseCode(output, encode, out bool invalidChar);
					if (invalidChar)
						InvalidCharError();
				}
				else
				{
					using Aes a = Aes.Create();
					if (string.IsNullOrEmpty(textBox_IV.Text) || string.IsNullOrEmpty(textBox_Key.Text))
					{
						textBox_IV.Text = Convert.ToBase64String(a.IV);
						textBox_Key.Text = Convert.ToBase64String(a.Key);
					}
					else
					{
						try
						{
							a.Key = Convert.FromBase64String(textBox_Key.Text);
							a.IV = Convert.FromBase64String(textBox_IV.Text);
						}
						catch
						{
							label_Note.Text = "Key or IV invalid, new pair generated.";
							textBox_IV.Text = Convert.ToBase64String(a.IV);
							textBox_Key.Text = Convert.ToBase64String(a.Key);
						}
					}

					output = enc.AES(output, a.Key, a.IV, encode);

				}

			}
			// if decode is checked
			else
			{
				if (comboBox1.SelectedIndex < 3)
				{
					output = enc.MorseCode(output, encode, out bool invalidChar);
					if (comboBox1.SelectedIndex == 1)
						output = enc.CharShift(output, encode);
					if (comboBox1.SelectedIndex == 2)
						output = enc.MultiShift(output, encode);
					if (invalidChar)
						InvalidCharError();
				}
				else
				{
					try
					{
						byte[] key = Convert.FromBase64String(textBox_Key.Text);
						byte[] IV = Convert.FromBase64String(textBox_IV.Text);
						output = enc.AES(output, key, IV, encode);
					}
					catch (FormatException)
					{
						label_Note.Text = "Incorrect cipher";

					}
				}
			}
		}
		textbox_Output.Text = output;
		if (checkBox_Clip.Checked)
			Clipboard.SetText(textbox_Output.Text);
	}

	// When the state of clipboard checkbox changes, if it is checked copy output to clipboard.
	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox_Clip.Checked && string.IsNullOrWhiteSpace(textbox_Output.Text) == false)
		{
			Clipboard.SetText(textbox_Output.Text);
			label_Note.Text = "Output copied!";
		}
	}

	// When 'clear' button is clicked, sets the output text to null.
	private void button_ClearClick(object sender, EventArgs e)
	{
		textbox_Output.Text = "";
	}

	/// <summary>
	/// Quick shorthand for when user has inputted invalid characters.
	/// Changes the 'note' to an error message and plays asterisk.
	/// </summary>
	private void InvalidCharError()
	{
		label_Note.Text = "Encountered invalid character(s)";
		System.Media.SystemSounds.Asterisk.Play();
	}
	private void link_ClearInput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		textbox_Input.Text = "";
	}


	#region Window Manipulation Functions

	private bool WindowExpanded;
	private void ExpandWindow()
	{
		if (!WindowExpanded)
		{
			this.Width += 245;
			textbox_Output.Width += 245;
			button_Run.Left += 245;
			comboBox1.Left += 245;
			button_ClearOutput.Left += 245;

			textBox_IV.Visible = true;
			textBox_IV.Left += 260;
			textBox_IV.Width += 100;

			textBox_Key.Visible = true;
			textBox_Key.Left += 260;
			textBox_Key.Width += 100;

			label_IV.Visible = true;
			label_IV.Left += 260;

			label_Key.Visible = true;
			label_Key.Left += 260;

			label_ClearPair.Visible = true;
			label_ClearPair.Left += 260;

			WindowExpanded = true;
		}
	}
	private void ShrinkWindow()
	{
		if (WindowExpanded)
		{
			this.Width -= 245;
			textbox_Output.Width -= 245;
			button_Run.Left -= 245;
			comboBox1.Left -= 245;
			button_ClearOutput.Left -= 245;

			textBox_IV.Visible = false;
			textBox_IV.Left -= 260;
			textBox_IV.Width -= 100;

			textBox_Key.Visible = false;
			textBox_Key.Left -= 260;
			textBox_Key.Width -= 100;

			label_IV.Visible = false;
			label_IV.Left -= 260;

			label_Key.Visible = false;
			label_Key.Left -= 260;

			label_ClearPair.Visible = false;
			label_ClearPair.Left -= 260;

			WindowExpanded = false;
		}
	}

	#endregion

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboBox1.SelectedIndex == 3)
		{
			ExpandWindow();
		}
		else if (this.Width > 500)
		{
			ShrinkWindow();
		}
	}

	private void label_Key_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(textBox_Key.Text))
		{
			Clipboard.SetText(textBox_Key.Text);
			label_Note.Text = "Key Copied!";
		}
	}

	private void label_IV_Click(object sender, EventArgs e)
	{
		if (!String.IsNullOrEmpty(textBox_IV.Text))
		{
			Clipboard.SetText(textBox_IV.Text);
			label_Note.Text = "IV Copied!";
		}
	}

	private void label_ClearPair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		textBox_IV.Text = ""; textBox_Key.Text = "";
	}

	private void textbox_Input_TextChanged(object sender, EventArgs e)
	{

	}
}
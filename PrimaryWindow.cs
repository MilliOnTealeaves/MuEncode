using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;

namespace MuEncode;

public partial class PrimaryWindow : Form
{
	private readonly ErrorStream _err;
	private readonly string _helpUrl;
	private readonly string? _exeUrl;

	public PrimaryWindow()
	{
		InitializeComponent();
		_err = new(Lbl_Errors, false);
		_err.Write("Error and notice stream: double-click to clear. For help, press the logo");
		AesWrapperHeight = Pnl_AesWrapper.Height;

		_helpUrl = "\\Help\\HelpPage.html";
		_exeUrl = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		ToolTip_Help.SetToolTip(Img_Logo, "Click for information about program");
	}

	#region Core Encoding Functionality

	private void Btn_Run_Click(object sender, EventArgs e)
	{
		if (TxtBx_Input.Text == "")
		{
			_err.Write("Input is empty, try again");
			return;
		}

		bool encode = Rdo_Encode.Checked;
		string result = TxtBx_Input.Text;
		int mode = DrpDn_Mode.SelectedIndex;
		using (Encoder enc = new(_err))
		{
			if (encode)
			{
				switch (mode)
				{
					case 1: result = enc.CharShift(result, encode); break;
					case 2: result = enc.MultiShift(result, encode); break;
				}
				if (mode != 3)
				{
					result = enc.MorseCode(result, encode, out bool charError);

					if (mode == -1) DrpDn_Mode.SelectedIndex = 0;
				}
				else
				{
					using Aes a = Aes.Create();
					if (string.IsNullOrEmpty(TxtBx_AesIV.Text) || string.IsNullOrEmpty(TxtBx_AesKey.Text))
					{
						TxtBx_AesIV.Text = Convert.ToBase64String(a.IV);
						TxtBx_AesKey.Text = Convert.ToBase64String(a.Key);
					}
					else
					{
						try
						{
							a.Key = Convert.FromBase64String(TxtBx_AesKey.Text);
							a.IV = Convert.FromBase64String(TxtBx_AesIV.Text);
						}
						catch
						{
							_err.Write("Key or IV invalid, new pair generated");
							TxtBx_AesIV.Text = Convert.ToBase64String(a.IV);
							TxtBx_AesKey.Text = Convert.ToBase64String(a.Key);
						}
					}

					result = enc.AES(result, a.Key, a.IV, encode);
				}
			}
			else
			{
				if (mode != 3)
				{
					result = enc.MorseCode(result, encode, out bool charError);
					switch (mode)
					{
						case 1: result = enc.CharShift(result, encode); break;
						case 2: result = enc.MultiShift(result, encode); break;
					}
				}

				else if (!string.IsNullOrEmpty(TxtBx_AesIV.Text) && !string.IsNullOrEmpty(TxtBx_AesKey.Text))
				{
					try
					{
						byte[] key = Convert.FromBase64String(TxtBx_AesKey.Text);
						byte[] IV = Convert.FromBase64String(TxtBx_AesIV.Text);
						result = enc.AES(result, key, IV, encode);
					}
					catch (FormatException)
					{
						_err.Write("Incorrect cipher");
					}
				}
			}

		}
		if (ChkBx_Copy.Checked) Clipboard.SetText(result);
		if (ChkBx_Switch.Checked)
		{
			bool b = Rdo_Encode.Checked;
			Rdo_Encode.Checked = !b;
			Rdo_Decode.Checked = b;
		}
		TxtBx_Output.Text = result;
	}

	#endregion

	#region Clear Button Methods

	private void Btn_ClearInput_Click(object sender, EventArgs e)
	{
		TxtBx_Input.Text = "";
	}

	private void Btn_ClearOutput_Click(object sender, EventArgs e)
	{
		TxtBx_Output.Text = "";
	}

	#endregion

	#region Copy and Paste Button Methods

	private void Btn_Copy_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(TxtBx_Output.Text)) Clipboard.SetText(TxtBx_Output.Text);
	}

	private void Btn_Paste_Click(object sender, EventArgs e)
	{
		TxtBx_Input.Text = Clipboard.GetText();
	}

	#endregion

	#region File Handling Methods

	private void Btn_Open_Click(object sender, EventArgs e)
	{
		OpenFile_Input.ShowDialog();
	}

	private void OpenFile_Input_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
	{
		using (Stream fs = OpenFile_Input.OpenFile())
		{
			using (StreamReader sr = new(fs))
			{
				string contents = sr.ReadToEnd();
				if (!string.IsNullOrEmpty(contents))
				{
					TxtBx_Input.Text = contents;
					sr.Close();
					_err.Write("File loaded successfully");
				}
				else
					_err.Write("File contents null or empty");
			}
		}
		OpenFile_Input.Dispose();
	}

	private void Btn_Save_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(TxtBx_Output.Text)) SaveFile_Output.ShowDialog();
		else _err.Write("Output empty");
	}

	private void SaveFile_Output_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
	{
		using (Stream fs = SaveFile_Output.OpenFile())
		{
			using (StreamWriter sr = new(fs))
			{
				if (!string.IsNullOrWhiteSpace(TxtBx_Output.Text))
					sr.Write(TxtBx_Output.Text);
				sr.Close();
			}
		}
		SaveFile_Output.Dispose();
	}

	#endregion

	#region AES Panel Resize Methods

	private int AesWrapperHeight;
	private void Lbl_AesOptions_Click(object sender, EventArgs e)
	{
		if (Pnl_AesWrapper.Height > Pnl_AesWrapper.Font.Height + 2)
		{
			Pnl_AesWrapper.Height = Pnl_AesWrapper.Font.Height + 2;
		}
		else
		{
			Pnl_AesWrapper.Height = AesWrapperHeight;
		}
	}

	private void PrimaryWindow_ResizeEnd(object sender, EventArgs e)
	{
		if (Pnl_AesWrapper.Location.Y + AesWrapperHeight > Btn_Run.Location.Y)
		{
			Pnl_AesWrapper.Height = Btn_Run.Location.Y - Pnl_AesWrapper.Location.Y - 5;
		}
		else Pnl_AesWrapper.Height = AesWrapperHeight;
	}

	private void DrpDn_Mode_Changed(object sender, EventArgs e)
	{
		if (DrpDn_Mode.SelectedIndex == 3) Pnl_AesWrapper.Show(); else Pnl_AesWrapper.Hide();
	}

	#endregion

	#region Textbox Scrollbar Generation Methods

	private void TxtBx_Input_TextChanged(object sender, EventArgs e) { AutoScrollBars(TxtBx_Input); }

	private void TxtBx_Output_TextChanged(object sender, EventArgs e) { AutoScrollBars(TxtBx_Output); }

	private static void AutoScrollBars(TextBox tb)
	{
		if (tb.Lines.Length * tb.Font.Height > tb.Height)
			tb.ScrollBars = ScrollBars.Vertical;
		else
			tb.ScrollBars = ScrollBars.None;
	}

	#endregion

	#region Miscellaneous Methods

	private void Img_Logo_Click(object sender, EventArgs e)
	{
		Process p = new() { StartInfo = new(_exeUrl + _helpUrl) { UseShellExecute = true } };
		p.Start();
	}

	private void Lbl_Errors_DoubleClick(object sender, EventArgs e)
	{
		Lbl_Errors.Text = "";
	}

	#endregion
}

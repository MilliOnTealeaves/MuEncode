using System.Security.Cryptography;

namespace MuEncode;

public partial class PrimaryWindow : Form
{
	private ErrorStream err;

	public PrimaryWindow()
	{
		InitializeComponent();
		Encoder.InitializeMorse();
		err = new(Lbl_Errors, true);
		err.Write("Error Stream. Double-click to clear errors");
		AesWrapperHeight = Pnl_AesWrapper.Height;
	}

	private void DrpDn_Mode_Changed(object sender, EventArgs e)
	{
		if (DrpDn_Mode.SelectedIndex == 3) Pnl_AesWrapper.Show(); else Pnl_AesWrapper.Hide();
	}

	private void Btn_Run_Click(object sender, EventArgs e)
	{
		if (TxtBx_Input.Text == "")
		{
			err.Write("Input is empty, try again");
			return;
		}

		bool encode = Rdo_Encode.Checked;
		string result = TxtBx_Input.Text;
		int mode = DrpDn_Mode.SelectedIndex;
		using (Encoder enc = new(err))
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
							err.Write("Key or IV invalid, new pair generated");
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
						err.Write("Incorrect cipher");
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

	private void Btn_ClearInput_Click(object sender, EventArgs e)
	{
		TxtBx_Input.Text = "";
	}

	private void Btn_ClearOutput_Click(object sender, EventArgs e)
	{
		TxtBx_Output.Text = "";
	}

	private int AesWrapperHeight;
	private void Lbl_AesOptions_Click(object sender, EventArgs e)
	{
		if (Pnl_AesWrapper.Height > 25)
		{
			Pnl_AesWrapper.Height = 25;
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

	private void Lbl_Errors_DoubleClick(object sender, EventArgs e)
	{
		Lbl_Errors.Text = "";
	}

	private void Btn_Paste_Click(object sender, EventArgs e)
	{
		TxtBx_Input.Text = Clipboard.GetText();
	}

	private void Btn_Copy_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(TxtBx_Output.Text);
	}

	private void Pnl_AesWrapper_Paint(object sender, PaintEventArgs e)
	{

	}

	private void Lbl_AesKey_Click(object sender, EventArgs e)
	{

	}

	private void ChkBx_Switch_CheckedChanged(object sender, EventArgs e)
	{

	}

	private void Rdo_Decode_CheckedChanged(object sender, EventArgs e)
	{

	}

	private void Pnl_Options_Paint(object sender, PaintEventArgs e)
	{

	}
}

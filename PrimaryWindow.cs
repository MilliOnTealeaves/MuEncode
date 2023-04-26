using System.Security.Cryptography;

namespace MuEncode;

public partial class PrimaryWindow : Form
{
	public PrimaryWindow()
	{
		InitializeComponent();
		Encoder.InitializeMorse();
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
			Lbl_Errors.Text += "\t\tInput is empty, try again\n";
			return;
		}

		bool encode = Rdo_Encode.Checked;
		string result = TxtBx_Input.Text;
		int mode = DrpDn_Mode.SelectedIndex;

		if (encode)
		{
			switch (mode)
			{
				case 1: result = Encoder.CharShift(result, encode); break;
				case 2: result = Encoder.MultiShift(result, encode); break;
			}
			if (mode != 3)
			{
				result = Encoder.MorseCode(result, encode, out bool charError, out List<string> illegalChars);
				if (charError) Lbl_Errors.Text += "Encountered Illegal Characters: ";
				foreach (string i in illegalChars)
					Lbl_Errors.Text += "[" + i + "], ";
				Lbl_Errors.Text += "\n";
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
						Lbl_Errors.Text = "Key or IV invalid, new pair generated.";
						TxtBx_AesIV.Text = Convert.ToBase64String(a.IV);
						TxtBx_AesKey.Text = Convert.ToBase64String(a.Key);
					}
				}

				result = Encoder.AES(result, a.Key, a.IV, encode);
			}
		}
		else
		{
			if (mode != 3)
			{
				result = Encoder.MorseCode(result, encode, out bool charError, out List<string> illegalChars);
				switch (mode)
				{
					case 1: result = Encoder.CharShift(result, encode); break;
					case 2: result = Encoder.MultiShift(result, encode); break;
				}
				if (charError) Lbl_Errors.Text += "Encountered Illegal Characters: ";
				foreach (string i in illegalChars)
					Lbl_Errors.Text += "[" + i + "], ";
				Lbl_Errors.Text += "\n";
			}

			else if (!string.IsNullOrEmpty(TxtBx_AesIV.Text) && !string.IsNullOrEmpty(TxtBx_AesKey.Text))
			{
				try
				{
					byte[] key = Convert.FromBase64String(TxtBx_AesKey.Text);
					byte[] IV = Convert.FromBase64String(TxtBx_AesIV.Text);
					result = Encoder.AES(result, key, IV, encode);
				}
				catch (FormatException)
				{
					Lbl_Errors.Text = "Incorrect cipher";
				}
			}
			if (ChkBx_Copy.Checked) Clipboard.SetText(result);
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
}

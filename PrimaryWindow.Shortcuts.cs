namespace MuEncode;

partial class PrimaryWindow : Form
{
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		switch (keyData)
		{
			// run
			case (Keys.Control | Keys.R):
			case (Keys.Control | Keys.Enter):
				Btn_Run_Click("CTRL+R_or_Enter", new());
				return true;

			// switch mode
			case (Keys.Control | Keys.M):
				SwitchMode();
				return true;

			// select encode
			case (Keys.Control | Keys.E):
				Rdo_Encode.Select();
				return true;

			// select decode
			case (Keys.Control | Keys.D):
				Rdo_Decode.Select();
				return true;

			// save file
			case (Keys.Control | Keys.S):
				Btn_Save_Click("CTRL+S", new());
				return true;

			// copy output
			case (Keys.Control | Keys.Shift | Keys.C):
				Btn_Copy_Click("CTRL+Shift+C", new());
				return true;

			case (Keys.Control | Keys.Shift | Keys.V):
				Btn_Paste_Click("CTRL+Shift+V", new());
				return true;

			// open file
			case (Keys.Control | Keys.O):
				Btn_Open_Click("CTRL+O", new());
				return true;

			// focus on input
			case (Keys.Control | Keys.I):
				this.ActiveControl = TxtBx_Input;
				return true;

			// open help page
			case (Keys.Control | Keys.H):
				Img_Logo_Click("CTRL+H", new());
				return true;

			case (Keys.Control | Keys.Tab):
				Btn_ClearInput_Click("CTRL+Escape", new());
				Btn_ClearOutput_Click("CTRL+Escape", new());
				return true;

			case (Keys.Control | Keys.D0):
				DrpDn_Mode.SelectedIndex = 0;
				return true;

			case (Keys.Control | Keys.D1):
				DrpDn_Mode.SelectedIndex = 1;
				return true;

			case (Keys.Control | Keys.D2):
				DrpDn_Mode.SelectedIndex = 2;
				return true;

			case (Keys.Control | Keys.D3):
				DrpDn_Mode.SelectedIndex = 3;
				return true;

			default: return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}

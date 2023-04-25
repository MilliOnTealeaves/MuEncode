namespace MuEncode;

public partial class PrimaryWindow : Form
{
	public PrimaryWindow()
	{
		InitializeComponent();
		Encoder.InitializeMorse();
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (DrpDn_Mode.SelectedIndex == 3) GrpBx_AesOptions.Show(); else GrpBx_AesOptions.Hide();
	}

	private void TxtBx_Input_TextChanged(object sender, EventArgs e)
	{

	}

	private void TxtBx_Output_TextChanged(object sender, EventArgs e)
	{

	}

	private void TxtBx_AesKey_TextChanged(object sender, EventArgs e)
	{

	}

	private void TxtBx_AesIV_TextChanged(object sender, EventArgs e)
	{

	}
}

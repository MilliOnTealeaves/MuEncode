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
}

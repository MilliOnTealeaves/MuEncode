using System.Windows.Forms;
using System.Media;
namespace EncodeDecode;
public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
        Encoder.InitializeMorse();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        label_Message.Text = "";
        radio_Encode.Checked = true;
        textbox_Input.PlaceholderText = "Input message to be encoded";
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        label_Message.Text = "Easter Egg! ( )";
        System.Media.SystemSounds.Beep.Play();
    }

    private void EncodeCheckedChanged(object sender, EventArgs e)
    {
        if (radio_Encode.Checked)
            textbox_Input.PlaceholderText = "Type message to be encoded";
    }

    private void DecodeCheckedChanged(object sender, EventArgs e)
    {
        if (radio_Decode.Checked)
            textbox_Input.PlaceholderText = "Type morse code to decode";
    }

    private void RunClicked(object sender, EventArgs e)
    {
        bool error;
        //so it doesn't run with empty input
        if (string.IsNullOrEmpty(textbox_Input.Text.Trim()))
        {
            label_Message.Text = "Input is empty, please try again";
            return;
        }
		label_Message.Text = "";
		//if encode is checked
		if (radio_Encode.Checked)
        {
            textbox_Output.Text = Encoder.ToMorse(textbox_Input.Text, out error);
            if (error)
				InvalidCharError();
		}
        //if decode is checked
        else if (radio_Decode.Checked)
        {
            textbox_Output.Text = Encoder.FromMorse(textbox_Input.Text, out error);
            if (error)
				InvalidCharError();
		}
        if (checkBox_Clip.Checked)
			Clipboard.SetText(textbox_Output.Text);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
		if (checkBox_Clip.Checked && string.IsNullOrWhiteSpace(textbox_Output.Text)==false)
		{
            Clipboard.SetText(textbox_Output.Text);
		}
	}

    private void button_ClearClick(object sender, EventArgs e)
    {
        textbox_Output.Text = "";
    }

    
	private void InvalidCharError()
	{
		label_Message.Text = "Encountered invalid character(s)";
		System.Media.SystemSounds.Asterisk.Play();
	}
}
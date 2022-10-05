using System.Windows.Forms.VisualStyles;

namespace EncodeDecode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Message.Text = "";
            radio_Encode.Checked = true;
			Encoder.LoadMorse();
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EncodeCheckedChanged(object sender, EventArgs e)
        {

        }

        private void DecodeCheckedChanged(object sender, EventArgs e)
        {

        }

        private void InputTextChanged(object sender, EventArgs e)
        {

        }

        private void RunClicked(object sender, EventArgs e)
        {
			//if encode is checked
			if (radio_Encode.Checked)
			{
                label_Message.Text = "* Input has been encoded";
                textbox_Output.Text = Encoder.ToMorse(textbox_Input.Text);
            }
            //if decode is checked
            else if (radio_Decode.Checked)
			{
                label_Message.Text = "* Input has been decoded";
                textbox_Output.Text = Encoder.FromMorse(textbox_Input.Text);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
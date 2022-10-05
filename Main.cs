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
            textbox_Input.PlaceholderText = "Input message to be encoded to morse";
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
            if (radio_Encode.Checked)
				textbox_Input.PlaceholderText = "Type message to be encoded to morse";
		}

        private void DecodeCheckedChanged(object sender, EventArgs e)
        {
            if (radio_Decode.Checked)
				textbox_Input.PlaceholderText = "Type morse code to be translated";
		}

        private void InputTextChanged(object sender, EventArgs e)
        {

        }

        private void RunClicked(object sender, EventArgs e)
        {
			bool error;
			if (string.IsNullOrEmpty(textbox_Input.Text))
            {
                label_Message.Text = "Input is empty, please try again";
                return;
            }
			//if encode is checked
			if (radio_Encode.Checked)
			{
                label_Message.Text = "";
                textbox_Output.Text = Encoder.ToMorse(textbox_Input.Text, out error);
				if (error)
				{
					label_Message.Text = "Encountered invalid character";
				}
			}
            //if decode is checked
            else if (radio_Decode.Checked)
			{
				label_Message.Text = "";
				textbox_Output.Text = Encoder.FromMorse(textbox_Input.Text, out error);
                if (error)
                {
                    label_Message.Text = "Encountered invalid character(s)";
                }
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
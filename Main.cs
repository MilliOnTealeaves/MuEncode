namespace MuEncode;
public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
        Encoder.InitializeMorse();
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
            textbox_Input.PlaceholderText = "Type message to be encoded";
    }

    private void DecodeCheckedChanged(object sender, EventArgs e)
    {
        if (radio_Decode.Checked)
            textbox_Input.PlaceholderText = "Type morse code to decode";
    }

    /// <summary>
    /// Main part of the program, runs when the "Run" button is clicked
    /// </summary>
    private void RunClicked(object sender, EventArgs e)
    {
        label_Note.Text = "";
        bool inputError;
        // so it doesn't run with empty input
        if (string.IsNullOrEmpty(textbox_Input.Text.Trim()))
        {
            label_Note.Text = "Input is empty, please try again";
            return;
        }

        // if encode is checked
        if (radio_Encode.Checked)
        {
            // regular morse code
            string input = "";
            if (comboBox1.SelectedIndex == 0)
            {
                input = textbox_Input.Text;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                input = Encoder.CharShift(textbox_Input.Text, true);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                input = Encoder.MultiShift(textbox_Input.Text, true);
            }
            else
            {
                label_Note.Text = "Please select a mode";
            }
            textbox_Output.Text = Encoder.ToMorse(input, out inputError);

            if (inputError)
                InvalidCharError();
        }
        // if decode is checked
        else if (radio_Decode.Checked)
        {
            string input = Encoder.FromMorse(textbox_Input.Text, out inputError);
            if (comboBox1.SelectedIndex == 0)
            {
                textbox_Output.Text = input;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textbox_Output.Text = Encoder.CharShift(input, false);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textbox_Output.Text = Encoder.MultiShift(input, false);
            }
            else
            {
                label_Note.Text = "Please select a mode";
            }

            if (inputError)
                InvalidCharError();
        }
        if (checkBox_Clip.Checked)
            Clipboard.SetText(textbox_Output.Text);
    }

    // When the state of clipboard checkbox changes, if it is checked copy output to clipboard.
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_Clip.Checked && string.IsNullOrWhiteSpace(textbox_Output.Text) == false)
        {
            Clipboard.SetText(textbox_Output.Text);
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
}
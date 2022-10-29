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
        bool inputError;
        // so it doesn't run with empty input
        if (string.IsNullOrEmpty(textbox_Input.Text.Trim()))
        {
            label_Note.Text = "Input is empty, please try again";
            return;
        }
        label_Note.Text = "";

        // if encode is checked
        if (radio_Encode.Checked)
        {
            textbox_Output.Text = Encoder.ToMorse(Encoder.MultiShift(textbox_Input.Text, true), out inputError);
            if (inputError)
                InvalidCharError();
        }
        // if decode is checked
        else if (radio_Decode.Checked)
        {
            textbox_Output.Text = Encoder.MultiShift(Encoder.FromMorse(textbox_Input.Text, out inputError), false);
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
}
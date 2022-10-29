namespace EncodeDecode
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.radio_Encode = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label_Title = new System.Windows.Forms.Label();
			this.button_Run = new System.Windows.Forms.Button();
			this.radio_Decode = new System.Windows.Forms.RadioButton();
			this.textbox_Input = new System.Windows.Forms.TextBox();
			this.label_Prompt = new System.Windows.Forms.Label();
			this.textbox_Output = new System.Windows.Forms.TextBox();
			this.label_Output = new System.Windows.Forms.Label();
			this.label_Note = new System.Windows.Forms.Label();
			this.checkBox_Clip = new System.Windows.Forms.CheckBox();
			this.button_Clear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// radio_Encode
			// 
			this.radio_Encode.AutoSize = true;
			this.radio_Encode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.radio_Encode.Location = new System.Drawing.Point(146, 195);
			this.radio_Encode.Name = "radio_Encode";
			this.radio_Encode.Size = new System.Drawing.Size(74, 23);
			this.radio_Encode.TabIndex = 1;
			this.radio_Encode.TabStop = true;
			this.radio_Encode.Text = "Encode";
			this.radio_Encode.UseVisualStyleBackColor = true;
			this.radio_Encode.CheckedChanged += new System.EventHandler(this.EncodeCheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 170);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label_Title
			// 
			this.label_Title.AutoSize = true;
			this.label_Title.Font = new System.Drawing.Font("EB Garamond 12", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(162)))));
			this.label_Title.Location = new System.Drawing.Point(136, 10);
			this.label_Title.Name = "label_Title";
			this.label_Title.Size = new System.Drawing.Size(255, 36);
			this.label_Title.TabIndex = 5;
			this.label_Title.Text = "Welcome to μEncode!";
			// 
			// button_Run
			// 
			this.button_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.button_Run.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Run.FlatAppearance.BorderSize = 0;
			this.button_Run.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Run.ForeColor = System.Drawing.Color.White;
			this.button_Run.Location = new System.Drawing.Point(305, 186);
			this.button_Run.Name = "button_Run";
			this.button_Run.Size = new System.Drawing.Size(86, 35);
			this.button_Run.TabIndex = 3;
			this.button_Run.Text = "RUN";
			this.button_Run.UseVisualStyleBackColor = false;
			this.button_Run.Click += new System.EventHandler(this.RunClicked);
			// 
			// radio_Decode
			// 
			this.radio_Decode.AutoSize = true;
			this.radio_Decode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.radio_Decode.Location = new System.Drawing.Point(226, 195);
			this.radio_Decode.Name = "radio_Decode";
			this.radio_Decode.Size = new System.Drawing.Size(76, 23);
			this.radio_Decode.TabIndex = 2;
			this.radio_Decode.TabStop = true;
			this.radio_Decode.Text = "Decode";
			this.radio_Decode.UseVisualStyleBackColor = true;
			this.radio_Decode.CheckedChanged += new System.EventHandler(this.DecodeCheckedChanged);
			// 
			// textbox_Input
			// 
			this.textbox_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.textbox_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textbox_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textbox_Input.Font = new System.Drawing.Font("NK57 Monospace Sc Bk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textbox_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.textbox_Input.Location = new System.Drawing.Point(140, 80);
			this.textbox_Input.Multiline = true;
			this.textbox_Input.Name = "textbox_Input";
			this.textbox_Input.Size = new System.Drawing.Size(252, 100);
			this.textbox_Input.TabIndex = 0;
			// 
			// label_Prompt
			// 
			this.label_Prompt.AutoEllipsis = true;
			this.label_Prompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Prompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(162)))));
			this.label_Prompt.Location = new System.Drawing.Point(140, 57);
			this.label_Prompt.Name = "label_Prompt";
			this.label_Prompt.Size = new System.Drawing.Size(150, 20);
			this.label_Prompt.TabIndex = 6;
			this.label_Prompt.Text = "Enter Message:";
			// 
			// textbox_Output
			// 
			this.textbox_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.textbox_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textbox_Output.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textbox_Output.Font = new System.Drawing.Font("NK57 Monospace Sc Bk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textbox_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.textbox_Output.Location = new System.Drawing.Point(12, 243);
			this.textbox_Output.Multiline = true;
			this.textbox_Output.Name = "textbox_Output";
			this.textbox_Output.ReadOnly = true;
			this.textbox_Output.Size = new System.Drawing.Size(380, 80);
			this.textbox_Output.TabIndex = 4;
			// 
			// label_Output
			// 
			this.label_Output.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(162)))));
			this.label_Output.Location = new System.Drawing.Point(12, 220);
			this.label_Output.Name = "label_Output";
			this.label_Output.Size = new System.Drawing.Size(100, 20);
			this.label_Output.TabIndex = 7;
			this.label_Output.Text = "Output:";
			// 
			// label_Note
			// 
			this.label_Note.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label_Note.Location = new System.Drawing.Point(140, 220);
			this.label_Note.Name = "label_Note";
			this.label_Note.Size = new System.Drawing.Size(240, 20);
			this.label_Note.TabIndex = 11;
			// 
			// checkBox_Clip
			// 
			this.checkBox_Clip.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBox_Clip.Location = new System.Drawing.Point(12, 332);
			this.checkBox_Clip.Name = "checkBox_Clip";
			this.checkBox_Clip.Size = new System.Drawing.Size(254, 30);
			this.checkBox_Clip.TabIndex = 5;
			this.checkBox_Clip.Text = "Copy Output to Clipboard";
			this.checkBox_Clip.UseVisualStyleBackColor = true;
			this.checkBox_Clip.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button_Clear
			// 
			this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Clear.FlatAppearance.BorderSize = 0;
			this.button_Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Clear.ForeColor = System.Drawing.Color.White;
			this.button_Clear.Location = new System.Drawing.Point(255, 330);
			this.button_Clear.Name = "button_Clear";
			this.button_Clear.Size = new System.Drawing.Size(136, 35);
			this.button_Clear.TabIndex = 6;
			this.button_Clear.Text = "Clear Output";
			this.button_Clear.UseVisualStyleBackColor = false;
			this.button_Clear.Click += new System.EventHandler(this.button_ClearClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.ClientSize = new System.Drawing.Size(404, 381);
			this.Controls.Add(this.button_Run);
			this.Controls.Add(this.button_Clear);
			this.Controls.Add(this.checkBox_Clip);
			this.Controls.Add(this.label_Note);
			this.Controls.Add(this.label_Output);
			this.Controls.Add(this.textbox_Output);
			this.Controls.Add(this.textbox_Input);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label_Prompt);
			this.Controls.Add(this.label_Title);
			this.Controls.Add(this.radio_Decode);
			this.Controls.Add(this.radio_Encode);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "μEncode";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private PictureBox pictureBox1;
		private Label label_Title;
		private Button button_Run;
		private RadioButton radio_Decode;
		private TextBox textbox_Input;
		private Label label_Prompt;
		private TextBox textbox_Output;
		private Label label_Output;
		private Label label_Note;
		private RadioButton radio_Encode;
		private CheckBox checkBox_Clip;
		private Button button_Clear;
	}
}
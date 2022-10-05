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
			this.label_Message = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// radio_Encode
			// 
			this.radio_Encode.AutoSize = true;
			this.radio_Encode.Location = new System.Drawing.Point(140, 193);
			this.radio_Encode.Name = "radio_Encode";
			this.radio_Encode.Size = new System.Drawing.Size(71, 23);
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
			this.label_Title.Size = new System.Drawing.Size(206, 29);
			this.label_Title.TabIndex = 5;
			this.label_Title.Text = "Welcome to μEncode!";
			this.label_Title.Click += new System.EventHandler(this.label1_Click);
			// 
			// button_Run
			// 
			this.button_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.button_Run.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Run.FlatAppearance.BorderSize = 0;
			this.button_Run.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Run.ForeColor = System.Drawing.Color.White;
			this.button_Run.Location = new System.Drawing.Point(305, 186);
			this.button_Run.Name = "button_Run";
			this.button_Run.Size = new System.Drawing.Size(75, 35);
			this.button_Run.TabIndex = 3;
			this.button_Run.Text = "RUN";
			this.button_Run.UseVisualStyleBackColor = false;
			this.button_Run.Click += new System.EventHandler(this.RunClicked);
			// 
			// radio_Decode
			// 
			this.radio_Decode.AutoSize = true;
			this.radio_Decode.Location = new System.Drawing.Point(217, 193);
			this.radio_Decode.Name = "radio_Decode";
			this.radio_Decode.Size = new System.Drawing.Size(73, 23);
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
			this.textbox_Input.Size = new System.Drawing.Size(240, 100);
			this.textbox_Input.TabIndex = 0;
			this.textbox_Input.TextChanged += new System.EventHandler(this.InputTextChanged);
			// 
			// label_Prompt
			// 
			this.label_Prompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Prompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(162)))));
			this.label_Prompt.Location = new System.Drawing.Point(140, 57);
			this.label_Prompt.Name = "label_Prompt";
			this.label_Prompt.Size = new System.Drawing.Size(110, 20);
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
			this.textbox_Output.Location = new System.Drawing.Point(10, 240);
			this.textbox_Output.Multiline = true;
			this.textbox_Output.Name = "textbox_Output";
			this.textbox_Output.ReadOnly = true;
			this.textbox_Output.Size = new System.Drawing.Size(370, 80);
			this.textbox_Output.TabIndex = 4;
			// 
			// label_Output
			// 
			this.label_Output.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(162)))));
			this.label_Output.Location = new System.Drawing.Point(10, 220);
			this.label_Output.Name = "label_Output";
			this.label_Output.Size = new System.Drawing.Size(60, 20);
			this.label_Output.TabIndex = 7;
			this.label_Output.Text = "Output:";
			// 
			// label_Message
			// 
			this.label_Message.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label_Message.Location = new System.Drawing.Point(140, 220);
			this.label_Message.Name = "label_Message";
			this.label_Message.Size = new System.Drawing.Size(240, 20);
			this.label_Message.TabIndex = 11;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.ClientSize = new System.Drawing.Size(390, 331);
			this.Controls.Add(this.label_Message);
			this.Controls.Add(this.label_Output);
			this.Controls.Add(this.textbox_Output);
			this.Controls.Add(this.textbox_Input);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label_Prompt);
			this.Controls.Add(this.label_Title);
			this.Controls.Add(this.button_Run);
			this.Controls.Add(this.radio_Decode);
			this.Controls.Add(this.radio_Encode);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private Label label_Message;
		private RadioButton radio_Encode;
	}
}
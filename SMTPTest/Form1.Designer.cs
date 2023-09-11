namespace SMTPTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txt_SMTPServer = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_TO = new System.Windows.Forms.TextBox();
            this.rtf_Body = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtf_output = new System.Windows.Forms.RichTextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_Show = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbConnection = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SMTPServer
            // 
            this.txt_SMTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SMTPServer.Location = new System.Drawing.Point(18, 62);
            this.txt_SMTPServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SMTPServer.Name = "txt_SMTPServer";
            this.txt_SMTPServer.Size = new System.Drawing.Size(396, 31);
            this.txt_SMTPServer.TabIndex = 0;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(20, 135);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(278, 31);
            this.txt_User.TabIndex = 3;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(309, 135);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(230, 31);
            this.txt_Pass.TabIndex = 4;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_port.Location = new System.Drawing.Point(424, 62);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(79, 31);
            this.txt_port.TabIndex = 1;
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(142, 20);
            this.txt_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(190, 26);
            this.txt_From.TabIndex = 5;
            // 
            // txt_TO
            // 
            this.txt_TO.Location = new System.Drawing.Point(436, 20);
            this.txt_TO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TO.Name = "txt_TO";
            this.txt_TO.Size = new System.Drawing.Size(218, 26);
            this.txt_TO.TabIndex = 6;
            // 
            // rtf_Body
            // 
            this.rtf_Body.Location = new System.Drawing.Point(15, 103);
            this.rtf_Body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtf_Body.Name = "rtf_Body";
            this.rtf_Body.Size = new System.Drawing.Size(638, 115);
            this.rtf_Body.TabIndex = 7;
            this.rtf_Body.Text = "Test body text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "From Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "SMTP Servername";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auth Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Auth Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGreen;
            this.btnSend.Location = new System.Drawing.Point(15, 226);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(162, 35);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send Test Email";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtf_output
            // 
            this.rtf_output.Location = new System.Drawing.Point(33, 508);
            this.rtf_output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtf_output.Name = "rtf_output";
            this.rtf_output.Size = new System.Drawing.Size(667, 112);
            this.rtf_output.TabIndex = 15;
            this.rtf_output.Text = "";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(142, 58);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(512, 26);
            this.txt_Subject.TabIndex = 7;
            this.txt_Subject.Text = "Test SMTP Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Subject:";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(44, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Google";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Auto fill SMTP settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "from popular providers";
            // 
            // chk_Show
            // 
            this.chk_Show.AutoSize = true;
            this.chk_Show.Location = new System.Drawing.Point(549, 143);
            this.chk_Show.Name = "chk_Show";
            this.chk_Show.Size = new System.Drawing.Size(141, 24);
            this.chk_Show.TabIndex = 37;
            this.chk_Show.Text = "Hide Password";
            this.chk_Show.UseVisualStyleBackColor = true;
            this.chk_Show.CheckedChanged += new System.EventHandler(this.chk_Show_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(44, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 48;
            this.button1.Text = "Office 365";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(33, 642);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(198, 186);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbConnection);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_SMTPServer);
            this.groupBox2.Controls.Add(this.txt_User);
            this.groupBox2.Controls.Add(this.txt_Pass);
            this.groupBox2.Controls.Add(this.chk_Show);
            this.groupBox2.Controls.Add(this.txt_port);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(705, 186);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVER INFO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.Location = new System.Drawing.Point(510, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "Security";
            // 
            // cmbConnection
            // 
            this.cmbConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbConnection.FormattingEnabled = true;
            this.cmbConnection.Items.AddRange(new object[] {
            "None",
            "SSL",
            "TLS"});
            this.cmbConnection.Location = new System.Drawing.Point(514, 62);
            this.cmbConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbConnection.Name = "cmbConnection";
            this.cmbConnection.Size = new System.Drawing.Size(124, 30);
            this.cmbConnection.TabIndex = 53;
            this.cmbConnection.Text = "None";
            this.cmbConnection.SelectedIndexChanged += new System.EventHandler(this.cmbConnection_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_From);
            this.groupBox3.Controls.Add(this.txt_TO);
            this.groupBox3.Controls.Add(this.rtf_Body);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_Subject);
            this.groupBox3.Location = new System.Drawing.Point(18, 217);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(686, 271);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compose Email";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "Clear log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 844);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtf_output);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SMTP Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txt_SMTPServer;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.TextBox txt_Pass;
		private System.Windows.Forms.TextBox txt_port;
		private System.Windows.Forms.TextBox txt_From;
		private System.Windows.Forms.TextBox txt_TO;
		private System.Windows.Forms.RichTextBox rtf_Body;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.RichTextBox rtf_output;
		private System.Windows.Forms.TextBox txt_Subject;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox chk_Show;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cmbConnection;
		private System.Windows.Forms.Label label10;
	}
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;


namespace SMTPTest
{
	public partial class Form1 : Form
	{
		public string SMTPserver;
		public int SMTPport;
		public bool SMTPssl;
		public bool useAuth;

		public Form1(){InitializeComponent();}
		private void Form1_Load(object sender, EventArgs e)	{
			chk_Show.Checked = true;
			txt_Pass.PasswordChar =  '*';
			useAuth = false;
		}

		private void btnSend_Click(object sender, EventArgs e) {
			rtf_output.Text = "";

			SMTPserver = txt_SMTPServer.Text.Trim();
			if (SMTPport.ToString().Length > 0)
			{
				SMTPport = Convert.ToInt32(txt_port.Text);
			}

			if (txt_User.TextLength > 0) { useAuth = true; }
		
			
			try
			{   // email Setup
				var eMail = new MimeMessage();
				eMail.From.Add(new MailboxAddress("", txt_From.Text));
				eMail.To.Add(new MailboxAddress("", txt_TO.Text));
				eMail.Subject = txt_Subject.Text;
				var builder = new BodyBuilder{					
					HtmlBody = rtf_Body.Text
		   	    };
				builder.Attachments.Add("TestEmail.Doc");
				eMail.Body = builder.ToMessageBody();

				using (var client = new SmtpClient())
				{
					if (cmbConnection.Text == "TLS" && useAuth == false)
					{
						client.Connect(txt_SMTPServer.Text, Convert.ToInt32(txt_port.Text), MailKit.Security.SecureSocketOptions.StartTls);
						client.Send(eMail);
					}
					if (cmbConnection.Text == "TLS" && useAuth == true)
					{
						client.Connect(txt_SMTPServer.Text, Convert.ToInt32(txt_port.Text), MailKit.Security.SecureSocketOptions.StartTls);
						client.Authenticate(txt_User.Text, txt_Pass.Text);
						client.Send(eMail);
					}
					if (cmbConnection.Text == "SSL" && useAuth == false)
					{
						client.Connect(txt_SMTPServer.Text, Convert.ToInt32(txt_port.Text), MailKit.Security.SecureSocketOptions.SslOnConnect);						
						client.Send(eMail);
					}
					if (cmbConnection.Text == "SSL" && useAuth == true)
					{
						client.Connect(txt_SMTPServer.Text, Convert.ToInt32(txt_port.Text), MailKit.Security.SecureSocketOptions.SslOnConnect);
						client.Authenticate(txt_User.Text, txt_Pass.Text);
						client.Send(eMail);
					}
					if (cmbConnection.Text == "None" && useAuth == false)
					{
						client.Connect(txt_SMTPServer.Text, Convert.ToInt32(txt_port.Text), MailKit.Security.SecureSocketOptions.None);
						client.Send(eMail);
					}
					if (cmbConnection.Text == "None" && useAuth == true)
					{
						client.Connect(txt_SMTPServer.Text, Convert.ToInt32(txt_port.Text), MailKit.Security.SecureSocketOptions.None);
						client.Authenticate(txt_User.Text, txt_Pass.Text);
						client.Send(eMail);
					}					
					
					rtf_output.Text = "Email was successfully sent";
					btnSend.BackColor = Color.LightGreen;
				}
			}
			catch (Exception ep)
			{
				btnSend.BackColor = Color.LightSalmon;
				rtf_output.Text = ep.Message;			}	
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txt_SMTPServer.Text = "SMTP.gmail.com";
			txt_port.Text = "587";
			cmbConnection.SelectedIndex = 2;

		}

		private void chk_Show_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_Show.Checked == true) {
				txt_Pass.PasswordChar = '*'; }
			else
				txt_Pass.PasswordChar = '\0';

		}

		private void txt_Pass_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			txt_SMTPServer.Text = "yourDNS-com.mail.protection.outlook.com";
			txt_port.Text = "465";
			cmbConnection.SelectedIndex = 1;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			rtf_output.Text = "";
		}

		private void cmbConnection_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
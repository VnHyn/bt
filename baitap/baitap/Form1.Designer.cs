
namespace baitap
{
	partial class Form1
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
			this.txtusername = new System.Windows.Forms.TextBox();
			this.lblusername = new System.Windows.Forms.Label();
			this.lblpassword = new System.Windows.Forms.Label();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtusername
			// 
			this.txtusername.Location = new System.Drawing.Point(398, 116);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(125, 27);
			this.txtusername.TabIndex = 0;
			// 
			// lblusername
			// 
			this.lblusername.AutoSize = true;
			this.lblusername.Location = new System.Drawing.Point(264, 116);
			this.lblusername.Name = "lblusername";
			this.lblusername.Size = new System.Drawing.Size(112, 20);
			this.lblusername.TabIndex = 1;
			this.lblusername.Text = "Ten Dang Nhap";
			this.lblusername.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblpassword
			// 
			this.lblpassword.AutoSize = true;
			this.lblpassword.Location = new System.Drawing.Point(277, 225);
			this.lblpassword.Name = "lblpassword";
			this.lblpassword.Size = new System.Drawing.Size(72, 20);
			this.lblpassword.TabIndex = 3;
			this.lblpassword.Text = "Mật Khẩu";
			this.lblpassword.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtpassword
			// 
			this.txtpassword.Location = new System.Drawing.Point(398, 207);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(125, 27);
			this.txtpassword.TabIndex = 2;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(398, 266);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(94, 29);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 451);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblpassword);
			this.Controls.Add(this.txtpassword);
			this.Controls.Add(this.lblusername);
			this.Controls.Add(this.txtusername);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.Button btnLogin;
	}
}


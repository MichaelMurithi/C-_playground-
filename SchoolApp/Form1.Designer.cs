namespace SchoolApp
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
			this.schoolName = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.Label();
			this.zip = new System.Windows.Forms.Label();
			this.state = new System.Windows.Forms.Label();
			this.phone = new System.Windows.Forms.Label();
			this.twitter = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.pushToText = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// schoolName
			// 
			this.schoolName.AutoSize = true;
			this.schoolName.Location = new System.Drawing.Point(121, 47);
			this.schoolName.Name = "schoolName";
			this.schoolName.Size = new System.Drawing.Size(78, 15);
			this.schoolName.TabIndex = 0;
			this.schoolName.Text = "School Name";
			// 
			// city
			// 
			this.city.AutoSize = true;
			this.city.Location = new System.Drawing.Point(121, 81);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(28, 15);
			this.city.TabIndex = 1;
			this.city.Text = "City";
			// 
			// address
			// 
			this.address.AutoSize = true;
			this.address.Location = new System.Drawing.Point(121, 123);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(49, 15);
			this.address.TabIndex = 2;
			this.address.Text = "Address";
			// 
			// zip
			// 
			this.zip.AutoSize = true;
			this.zip.Location = new System.Drawing.Point(121, 165);
			this.zip.Name = "zip";
			this.zip.Size = new System.Drawing.Size(24, 15);
			this.zip.TabIndex = 3;
			this.zip.Text = "Zip";
			// 
			// state
			// 
			this.state.AutoSize = true;
			this.state.Location = new System.Drawing.Point(121, 202);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(33, 15);
			this.state.TabIndex = 4;
			this.state.Text = "State";
			// 
			// phone
			// 
			this.phone.AutoSize = true;
			this.phone.Location = new System.Drawing.Point(121, 252);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(41, 15);
			this.phone.TabIndex = 5;
			this.phone.Text = "Phone";
			// 
			// twitter
			// 
			this.twitter.AutoSize = true;
			this.twitter.Location = new System.Drawing.Point(121, 284);
			this.twitter.Name = "twitter";
			this.twitter.Size = new System.Drawing.Size(42, 15);
			this.twitter.TabIndex = 6;
			this.twitter.Text = "Twitter";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(224, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(170, 23);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(224, 73);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(170, 23);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(224, 115);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(170, 23);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(224, 157);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(170, 23);
			this.textBox4.TabIndex = 10;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(224, 202);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(170, 23);
			this.textBox5.TabIndex = 11;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(224, 244);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(170, 23);
			this.textBox6.TabIndex = 12;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(224, 276);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(170, 23);
			this.textBox7.TabIndex = 13;
			// 
			// pushToText
			// 
			this.pushToText.Location = new System.Drawing.Point(121, 325);
			this.pushToText.Name = "pushToText";
			this.pushToText.Size = new System.Drawing.Size(273, 23);
			this.pushToText.TabIndex = 14;
			this.pushToText.Text = "Push To Text";
			this.pushToText.UseVisualStyleBackColor = true;
			this.pushToText.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 495);
			this.Controls.Add(this.pushToText);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.twitter);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.state);
			this.Controls.Add(this.zip);
			this.Controls.Add(this.address);
			this.Controls.Add(this.city);
			this.Controls.Add(this.schoolName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label schoolName;
		private System.Windows.Forms.Label city;
		private System.Windows.Forms.Label address;
		private System.Windows.Forms.Label zip;
		private System.Windows.Forms.Label state;
		private System.Windows.Forms.Label phone;
		private System.Windows.Forms.Label twitter;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button pushToText;
	}
}


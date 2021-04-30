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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtTwitter = new System.Windows.Forms.TextBox();
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
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(224, 39);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(170, 23);
			this.txtName.TabIndex = 7;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(224, 73);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(170, 23);
			this.txtCity.TabIndex = 8;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(224, 115);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(170, 23);
			this.txtAddress.TabIndex = 9;
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(224, 157);
			this.txtZip.Name = "txtZip";
			this.txtZip.Size = new System.Drawing.Size(170, 23);
			this.txtZip.TabIndex = 10;
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(224, 202);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(170, 23);
			this.txtState.TabIndex = 11;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(224, 244);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(170, 23);
			this.txtPhone.TabIndex = 12;
			// 
			// txtTwitter
			// 
			this.txtTwitter.Location = new System.Drawing.Point(224, 276);
			this.txtTwitter.Name = "txtTwitter";
			this.txtTwitter.Size = new System.Drawing.Size(170, 23);
			this.txtTwitter.TabIndex = 13;
			// 
			// pushToText
			// 
			this.pushToText.Location = new System.Drawing.Point(121, 323);
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
			this.Controls.Add(this.txtTwitter);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtState);
			this.Controls.Add(this.txtZip);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtName);
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
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtTwitter;
		private System.Windows.Forms.Button pushToText;
	}
}


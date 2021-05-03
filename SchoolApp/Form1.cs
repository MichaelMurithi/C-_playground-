using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var testSchool = new School();

			testSchool.Name = "Central City High";
			testSchool.Address = txtAddress.Text;
			testSchool.City = txtCity.Text;
			testSchool.State = txtState.Text;
			testSchool.Zip = txtZip.Text;
			testSchool.PhoneNumber = txtPhone.Text;
			try
			{
				testSchool.TwitterAddress = txtTwitter.Text;
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			MessageBox.Show(testSchool.ToString());
		}

		private void testTeacher_Click(object sender, EventArgs e)
		{
			var teacher = new Teacher();
			var gp = teacher.ComputeGradeAverage();
			MessageBox.Show("The grade average is " + gp);

		}

		private void btnTestStudent_Click(object sender, EventArgs e)
		{
			var student = new Student();
			var gp = student.ComputeGradeAverage();
			MessageBox.Show("The student grade average is " + gp);
		}
	}
}

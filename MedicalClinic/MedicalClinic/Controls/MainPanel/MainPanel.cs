using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Admin;
using MedicalClinic.Doctor;
using MedicalClinic.Controls.Doctor;
using MedicalClinic.Controls.Registration;
using MedicalClinic.Controls.Laboratory;

namespace MedicalClinic.MainPanel
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
               InitializeComponent();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public string ROLE
        {
            set { LoginText.Text = value; }
            get { return LoginText.Text; }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {


            var result = SqlQuerry.CheckLog(LoginText.Text.ToString(), PassText.Text.ToString());


            if (result.Any())
            {

                 Panel P = new Panel();
                /* P.Controls.Clear();
                 this.Hide();*/


                this.Controls.Clear();


                if (result.First().Role.ToString() == "Admin")

                {   //P.Controls.Add(new Admincs());
                    this.Controls.Add(new Admincs());

                }

                if (result.First().Role.ToString() == "Doc")

                {
                    P.Controls.Clear();
                    this.Hide();
                    this.Parent.Controls.Add(new Doctor.Doctor());
                }
                if (result.First().Role.ToString() == "Rec")

                {
                    P.Controls.Clear();
                    this.Hide();
                    this.Parent.Controls.Add(new Reg());
                }
                if (result.First().Role.ToString() == "Lab")

                {
                    P.Controls.Clear();
                    this.Hide();
                    this.Parent.Controls.Add(new Lab());
                }


            }




            else
                MessageBox.Show("User not found","Error");

        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

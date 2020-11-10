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
             /*  DataClassesDataContext db = new DataClassesDataContext();
               var g = from s in db.Staff
                       //where s.Id_Staff >= 1
                       select s;
               var r = g.AsEnumerable().ElementAtOrDefault(0);
               LoginText.Text = r.Login.ToString();

              // PassText.Text = g.Last().ToString();
               */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public string ROLE
        {
            set { LoginText.Text = value; }
            get { return LoginText.Text; }
        }

        AdminForm ad = null;
        private void button1_Click(object sender, EventArgs e)
        {
           
            DataClassesDataContext db = new DataClassesDataContext();
            var result = from s in db.Staff
                         where s.Login == LoginText.Text.ToString() &&
                               s.Password == PassText.Text.ToString()
                         select s;


            if (result.Any())
            {    

                Panel P = new Panel();
                P.Controls.Clear();
                this.Hide();


                if (result.First().Role.ToString() == "Admin")

                {
                    this.Parent.Controls.Add(new Admincs());
                }

                if (result.First().Role.ToString() == "Doc")

                {
                    this.Parent.Controls.Add(new Doctor.Doctor());
                }
                if (result.First().Role.ToString() == "Rec")

                {
                    this.Parent.Controls.Add(new Reg());
                }
                if (result.First().Role.ToString() == "Lab")

                {
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

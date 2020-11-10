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

        
        private void button1_Click(object sender, EventArgs e)
        {
           
            DataClassesDataContext db = new DataClassesDataContext();
            var result = from s in db.Staff
                         where s.Login == LoginText.Text.ToString() &&
                               s.Password == PassText.Text.ToString()
                         select s;


            if (result.Any())
            {    textBox1.Text = result.First().Role.ToString();
                
                Panel P = new Panel();
                P.Controls.Clear();
                this.Hide();
                

                if (result.First().Role.ToString()=="Admin")

                {
                    this.Parent.Controls.Add(new Admincs());
                }

                if (result.First().Role.ToString() == "Doc")

                {
                    this.Parent.Controls.Add(new Doctor.Doctor());
                }
                if (result.First().Role.ToString() == "Rec")

                {
                    this.Parent.Controls.Add(new Registration.Registration());
                }
                if (result.First().Role.ToString() == "Lab")

                {
                    this.Parent.Controls.Add(new Laboratory.Laboratory());
                }


            }




            else
                MessageBox.Show("User not found","Error");

        }
    }
}

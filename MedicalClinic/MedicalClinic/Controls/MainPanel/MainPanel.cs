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


       
        private void button1_Click(object sender, EventArgs e)
        {


            var result = SqlQuerry.CheckLog(LoginText.Text.ToString(), PassText.Text.ToString());


            if (result.Any())
            {


                this.Controls.Clear();


                if (result.First().Role.ToString() == "Admin")

                {   
                    this.Controls.Add(new Admincs());

                }

                if (result.First().Role.ToString() == "Doc")

                {
                    
                    this.Controls.Add(new Doctor.Doctor(result.First().Id_Staff));
                    
                }
                if (result.First().Role.ToString() == "Rec")

                {
                    
                    this.Controls.Add(new Reg(result.FirstOrDefault().Id_Staff));
                }
                if (result.First().Role.ToString() == "Lab"|| result.First().Role.ToString() == "MLab")

                {
                    
                    this.Controls.Add(new Lab(result.First().Id_Staff, result.First().Role));
                        
                }
                //brakuje mlab dokładamy go do laba i przekazujemy role i na jej podstawie robimy ograniczenia czy jakoś inaczej??

            }

            else
                MessageBox.Show("User not found","Error");

        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Controls.Registration;
using MedicalClinic.Registration;

namespace MedicalClinic.Controls.Registration
{
    public partial class Show : UserControl
    {
        public Show()
        {
            InitializeComponent();
        }

        private int apoid;
        private TextBox textb;
       
       
        public Show(int ID, TextBox text) : this()
        {
            apoid = ID;
            textb = text;
            monthCalendar1.Enabled = false;
            var a = SQLRec.GetApoSE(apoid);


            var res = SQLLab.GetPatientData(a.First().Id_Patient);
            foreach (var order in res)
            {
                textBox1.Text = order.Name;
                textBox2.Text = order.Surname;
                textBox3.Text = order.PESEL;

            }
            var doc = SQLAdm.GetStaff(a.First().Id_Doctor);
            textBox4.Text = doc.First().Name.ToString();//lekarz
            monthCalendar1.SetDate(a.First().Date_Appointment);//data
            textBox6.Text = a.First().State.ToString();//stan
            string time = a.First().Date_Appointment.TimeOfDay.ToString();
            textBox5.Text =time;//godzina
            
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

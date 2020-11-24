using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Registration;
using System.Threading;
using System.Globalization;

namespace MedicalClinic.Controls.Registration
{
    public partial class VisitRegistration : UserControl
    {
        private int patid;
        private TextBox textb;
        public VisitRegistration()
        {
            InitializeComponent();
          

        }
           public VisitRegistration(int ID,TextBox text):this ()
        {
            patid = ID;
            textb = text;
            var res = SqlQuerry.GetPatientData(patid);
            foreach (var order in res)
            {
                textBox1.Text = order.Name;
                textBox2.Text = order.Surname;
                textBox3.Text = order.PESEL;

            }
            var docs = SqlQuerry.GetStaff("", "", "", "doc");
            foreach (var order in docs)
            {
                comboBox1.Items.Add(order.Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string culture = "mn-MN";
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
            string datetosql= monthCalendar1.SelectionStart.ToShortDateString();
            datetosql += " " + comboBox2.Text;
            

            DateTime dt = DateTime.Parse(datetosql);
            SqlQuerry.ExecuteAppointment(dt, 1, Int16.Parse(textb.Text), "", "", patid);
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            textb.Text = "changed";
        }
    }
}

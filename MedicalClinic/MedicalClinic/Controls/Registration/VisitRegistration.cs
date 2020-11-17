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

namespace MedicalClinic.Controls.Registration
{
    public partial class VisitRegistration : UserControl
    {
        private int patid;
        public VisitRegistration()
        {
            InitializeComponent();
          

        }
           public VisitRegistration(int ID):this ()
        {
            patid = ID;
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

            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Reg());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datetosql = monthCalendar1.SelectionStart.ToShortDateString();
                datetosql =datetosql+ " "+comboBox2.Text;
            var dateTime = DateTime.Parse(datetosql);
            MessageBox.Show("Stworzono wizyte na date :" + dateTime.ToString());
             //SqlQuerry.ExecAppointment(dateTime,)
        }
    }
}

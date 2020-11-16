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
        public VisitRegistration()
        {
            InitializeComponent();
            int tmp = GlobalVar.SetPatientId;
            var res =SqlQuerry.GetPatientData(tmp);
            foreach (var order in res)
            {
                textBox1.Text = order.Name;
                textBox2.Text = order.Surname;
                textBox3.Text = order.PESEL;
          
            }
            var docs = SqlQuerry.GetStaff("", "", "", "doc");
            foreach(var order in docs)
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

             //SqlQuerry.ExecAppointment(dateTime,)
        }
    }
}

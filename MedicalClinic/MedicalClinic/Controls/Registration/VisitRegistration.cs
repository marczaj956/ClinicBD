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
        private int idrec;
        private TextBox textb;
        private IQueryable<Staff> docs;
        public VisitRegistration()
        {
            InitializeComponent();
          

        }
           public VisitRegistration(int ID,TextBox text,int whoami):this ()
        {
            patid = ID;
            textb = text;
            idrec = whoami;
            var res = SQLLab.GetPatientData(patid);
            foreach (var order in res)
            {
                textBox1.Text = order.Name;
                textBox2.Text = order.Surname;
                textBox3.Text = order.PESEL;

            }
            docs = SQLAdm.GetStaff("", "", "", "doc");
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

            var doc = docs.AsEnumerable<Staff>();
            
            int docid = doc.ElementAt<Staff>(comboBox1.SelectedIndex).Id_Staff;

            DateTime dt = DateTime.Parse(datetosql);
          
            SQLRec.ExecuteAppointment(dt, docid, idrec, "", "", patid,"ZLE");//zamiast 1 idrec
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            textb.Text = "changed";
        }

        private void VisitRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}

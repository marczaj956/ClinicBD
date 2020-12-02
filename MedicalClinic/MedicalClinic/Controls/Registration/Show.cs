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

        private int patid;
        private TextBox textb;
        private IQueryable<Staff> docs;
       
        public Show(int ID, TextBox text) : this()
        {
            patid = ID;
            textb = text;
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
                //comboBox1.Items.Add(order.Surname);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Reg());

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
    }
}

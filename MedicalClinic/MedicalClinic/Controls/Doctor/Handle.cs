using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Controls.Doctor;

namespace MedicalClinic.Doctor
{
    public partial class Handle : UserControl
    {
        public Handle()
        {
            InitializeComponent();

            var res = SQLDoc.GetPatient(1);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;
                textBox6.Text = order.patientTable.Id_Patient.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e) //show phisical
        {
            ShowPhisicExamList f2 = new ShowPhisicExamList();

            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //show labo
        {
            ShowLabExamList f2 = new ShowLabExamList();

            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Doctor());
        }

        private void button9_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(textBox6.Text.ToString()); 
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new HistoryVisits(id));
        }

        private void Handle_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new HistoryLaboratoryExamination());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new HistoryPhysicalExamination());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

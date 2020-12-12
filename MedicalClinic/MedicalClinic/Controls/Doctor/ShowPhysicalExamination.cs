using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Doctor;

namespace MedicalClinic.Controls.Doctor
{
    public partial class ShowPhysicalExamination : UserControl
    {
        private string IDVis;
        private int idpat;
        public ShowPhysicalExamination(int IDP, string IDV)
        {
            InitializeComponent();

            IDVis = IDV;
            idpat = IDP;

            PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            searchCriteria.setPatientId(IDP);

            var res = SQLDoc.GetPatient(searchCriteria);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;


            }
            //var res = SQLDoc.GetPatient(1);
            //foreach (var order in res)
            //{
            //    textBox1.Text = order.patientTable.Name;
            //    textBox2.Text = order.patientTable.Surname;
            //    textBox3.Text = order.patientTable.PESEL;

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            //this.Parent.Controls.Add(new Show(1));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPhysicalExamination_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }
    }
}

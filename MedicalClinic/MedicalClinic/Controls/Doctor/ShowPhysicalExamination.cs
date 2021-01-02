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
        public ShowPhysicalExamination(int IDPatient, string IDVisit, string IDExamination)  
        {
            InitializeComponent();

            IDVis = IDVisit;
            idpat = IDPatient;
            textBox4.Text = IDExamination;
           PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            searchCriteria.setPatientId(IDPatient);

            var res = SQLDoc.GetPatient(searchCriteria);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;


            }

            // textBox6 rodzaj badania
            // textBox5 wynik

            ExaminationsSearchCriteria examSearchCriteria = new ExaminationsSearchCriteria();
            examSearchCriteria.setAppointmentId(Int32.Parse(IDVisit));
            examSearchCriteria.setPatientId(IDPatient);
            var a = SQLDoc.GetPhysicalExamination(examSearchCriteria);
            textBox6.Text = a.First().examDictionaryTable.Name;
            textBox5.Text = a.First().physicalExaminationTable.Result;

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
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new PhysicalExamination(idpat, IDVis,1));
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

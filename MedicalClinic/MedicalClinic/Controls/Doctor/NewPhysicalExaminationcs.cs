using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Doctor
{
    public partial class NewPhysicalExaminationcs : UserControl
    {
        private string IDVis;
        private int idpat;
        private int procedure;
        public NewPhysicalExaminationcs(int IDP, string IDV, int procedure1) //procedure- ogarnia kiedy pokazujemy wizyte a kiedy obsługujemy - 1 -> pokazujemy 
        {
            InitializeComponent();

            IDVis = IDV;
            idpat = IDP;
            procedure = procedure1;

            PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            searchCriteria.setPatientId(IDP);

            var res = SQLDoc.GetPatient(searchCriteria);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;


            }

            var result = SQLDoc.GetPhysicalExamination();
            foreach (var order in result)
            {
                comboBox1.Items.Add(order.Name);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new PhysicalExamination(idpat, IDVis,procedure));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string examCode = "";

            ExaminationsSearchCriteria examinationSearchCriteria = new ExaminationsSearchCriteria();
            examinationSearchCriteria.setExaminationName(comboBox1.Text);
            var resExa = SQLDoc.GetPhysicalExamination(examinationSearchCriteria);
            foreach (var order in resExa)
            {
                examCode = order.examDictionaryTable.Exam_Code;

            }
            int idAppointment = Int32.Parse(IDVis);
            if (examCode != "" && textBox5.Text != "")
            {
                SQLDoc.insertPhysicalExamination(idAppointment, examCode, textBox5.Text);
                Panel P = new Panel();
                P.Controls.Clear();
                this.Hide();
                this.Parent.Controls.Add(new PhysicalExamination(idpat, IDVis, procedure));
            }
            else
            {
                MessageBox.Show("Wymagane dane: rodzaj badania, wynik oraz numer badania");
            }
        }

        private void NewPhysicalExaminationcs_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Controls.Doctor
{
    public partial class NewLabolatoryExaminationcs : UserControl
    {
        private string IDVis;
        private int idpat;
        private int procedure;
        public NewLabolatoryExaminationcs(int IDP, string IDV, int procedure1, int idexamination) // procedure = 2 -> edytuj, procedure = 1 -> nowe
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

            if (idexamination != -1)
            {
                textBox10.Text = idexamination.ToString(); ;

                ExaminationsSearchCriteria examinationSearchCriteria = new ExaminationsSearchCriteria();
                examinationSearchCriteria.setExaminationId(idexamination);
                var resExa = SQLDoc.GetLaboratoryExamination(examinationSearchCriteria);
                foreach (var order in resExa)
                {
                    comboBox1.Text = order.examDictionaryTable.Name;
                    textBox5.Text = order.laboratoryExaminationTable.Comments_Doctor;
                }

            }

            var result = SQLDoc.GetLabolatoryExamination();
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
            this.Parent.Controls.Add(new LabolatoryExaminantion(idpat, IDVis, procedure));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewLabolatoryExaminationcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string examCode = "";

            ExaminationsSearchCriteria examinationSearchCriteria = new ExaminationsSearchCriteria();
            examinationSearchCriteria.setExaminationName(comboBox1.Text);
            var resExa = SQLDoc.GetLaboratoryExamination(examinationSearchCriteria);
            foreach (var order in resExa)
            {
                examCode = order.examDictionaryTable.Exam_Code;

            }
            int idAppointment = Int32.Parse(IDVis);

            {
                if (examCode != "" && textBox5.Text != "")
                {
                    if (procedure == 1)
                    {
                        SQLDoc.insertLabolatoryExamination(idAppointment, examCode, textBox5.Text);
                        Panel P = new Panel();
                        P.Controls.Clear();
                        this.Hide();
                        this.Parent.Controls.Add(new LabolatoryExaminantion(idpat, IDVis, 2));
                    }
                    else if (procedure == 2)
                    {
                        int idExamination = Int32.Parse(textBox10.Text);
                        SQLDoc.updateLabolatoryExamination(idExamination, examCode, textBox5.Text);
                        Panel P = new Panel();
                        P.Controls.Clear();
                        this.Hide();
                        this.Parent.Controls.Add(new LabolatoryExaminantion(idpat, IDVis, procedure));
                    }
                }
                else
                {
                    MessageBox.Show("Wymagane dane: rodzaj badania, wynik.");
                }
            }
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

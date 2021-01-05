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
    public partial class ShowLabExamination : UserControl
    {
        private string IDVis;
        private int IDPat;
        private int procedure;
        public ShowLabExamination(int IDPatient, string IDVisit, string IDExamination, int procedure1) // procedura jeśłi 1 - wchodzi dla popatrzenia sobie z "pokaż" wizyty
        {
            InitializeComponent();


            IDVis = IDVisit;
            IDPat = IDPatient;
            procedure = procedure1;

            PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            searchCriteria.setPatientId(IDPatient);

            var res = SQLDoc.GetPatient(searchCriteria);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;


            }

            textBox10.Text = IDExamination;

            //if (procedure == 1)
            //{
            //    button1.Visible = true;
            //}
            //else
            //{
            //    button1.Visible = false;
            //}

            int idVisitInt = int.Parse(IDVisit);

            ExaminationsSearchCriteria examSearchCriteria = new ExaminationsSearchCriteria();
            examSearchCriteria.setAppointmentId(idVisitInt);
            examSearchCriteria.setPatientId(IDPatient);
            var a = SQLDoc.GetLaboratoryExamination(examSearchCriteria);
            
            foreach (var order in a)
            {
                textBox10.Text = order.laboratoryExaminationTable.Id_Examination.ToString();
                textBox6.Text = order.examDictionaryTable.Name; //typ badania
                textBox8.Text = order.laboratoryExaminationTable.State; //stan badania
                textBox5.Text = order.laboratoryExaminationTable.Result; //wynik badania
                textBox9.Text = order.laboratoryExaminationTable.Comments_Doctor; //uwagi doktora
                textBox7.Text = order.laboratoryExaminationTable.Comments_Man_Lab; //uwagi kierownika


            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
           // this.Parent.Controls.Add(new Show("1",));
        }

        private void ShowLabExamination_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new LabolatoryExaminantion(IDPat, IDVis, procedure));
        }
    }
}

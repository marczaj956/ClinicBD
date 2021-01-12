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
    public partial class EditPhysicalExamination : UserControl
    {
        private string IDVis;
        private int idpat;
        private int procedure;
        private int idExamination;
        public EditPhysicalExamination(int IDP, string IDV, int procedure1, int idexamination) // proce4dura ułatwia ogarniecie kiedy można edytować powiazane formatki - 1 -> oglądamy
        {
            InitializeComponent();
            IDVis = IDV;
            idpat = IDP;
            procedure = procedure1;
            idExamination = idexamination;
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
                textBox4.Text = idexamination.ToString(); 

                ExaminationsSearchCriteria examinationSearchCriteria = new ExaminationsSearchCriteria();
                examinationSearchCriteria.setExaminationId(idexamination);
                var resExa = SQLDoc.GetPhysicalExamination(examinationSearchCriteria);
                foreach (var order in resExa)
                {
                    comboBox1.Text = order.examDictionaryTable.Name;
                    textBox5.Text = order.physicalExaminationTable.Result;
                }

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
           


            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new PhysicalExamination(idpat, IDVis,procedure));
        }

        private void EditPhysicalExamination_Load(object sender, EventArgs e)
        {

        }
    }
}

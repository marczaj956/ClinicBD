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

namespace MedicalClinic.Controls.Doctor
{
    public partial class LabolatoryExaminantion : UserControl
    {
        private string IDVis;
        private int idpat;
        private int procedure;

        public LabolatoryExaminantion(int IdPatient, string IdVisit, int procedure1) // procedure informuje o trybie formatki czy edytowalna (zlec badanie )- "2" czy tylko pokazujemy badanka - "1"
        {
            InitializeComponent();
            if (procedure1 == 1)
            {
                button2.Visible = false;
                button3.Visible = false;
                
            }
            else
            {
                button1.Visible = false;
            }

            IDVis = IdVisit;
            idpat = IdPatient;
            procedure = procedure1;

            PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            searchCriteria.setPatientId(IdPatient);

            var res = SQLDoc.GetPatient(searchCriteria);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;


            }

           
            Mainlist.FullRowSelect = true;
            Mainlist.GridLines = true;

            
            int idVisitInt = int.Parse(IdVisit);

            ExaminationsSearchCriteria examSearchCriteria = new ExaminationsSearchCriteria();
            examSearchCriteria.setAppointmentId(idVisitInt);
            examSearchCriteria.setPatientId(IdPatient);
            var a = SQLDoc.GetLaboratoryExamination(examSearchCriteria);
            
            Mainlist.Items.Clear();

            foreach (var order in a)
            {
                ListViewItem lvi = new ListViewItem(order.laboratoryExaminationTable.Id_Examination.ToString());
                lvi.SubItems.Add(order.examDictionaryTable.Name); //typ badania
                lvi.SubItems.Add(order.laboratoryExaminationTable.State); //stan badania
                lvi.SubItems.Add(order.laboratoryExaminationTable.Result); //wynik badania
                lvi.SubItems.Add(order.laboratoryExaminationTable.Date_Exec_Cancel.ToString()); //data wykonania

                Mainlist.Items.Add(lvi);
              
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new NewLabolatoryExaminationcs());

        }

        private void button3_Click(object sender, EventArgs e)   // TO DO: jeśli przechodzi przed edycje badania to wpisać id badania, jeśli nowy to id puste
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new NewLabolatoryExaminationcs());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idexam = "";

            if (Mainlist.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Nie wybrano badania");
            }
            else
            {
                ListViewItem item = Mainlist.SelectedItems[0];

                idexam = (item.SubItems[0].Text.TrimEnd());
                Panel P = new Panel();
                P.Controls.Clear();
                this.Hide();
                this.Parent.Controls.Add(new ShowLabExamination(idpat, IDVis, idexam, procedure));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabolatoryExaminantion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Hide();
            this.Controls.Add(new MedicalClinic.Doctor.Show(idpat, IDVis));
            this.Visible = true;
            this.Dock = DockStyle.Fill;
            this.BringToFront();
        }

        private void Mainlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

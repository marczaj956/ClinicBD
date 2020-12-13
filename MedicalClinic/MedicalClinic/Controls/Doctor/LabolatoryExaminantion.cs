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
    public partial class LabolatoryExaminantion : UserControl
    {
        private string IDVis;
        private int idpat;

        public LabolatoryExaminantion(int IdPatient, string IdVisit, int procedure) // procedure informuje o trybie formatki czy edytowalna (zlec badanie )- "2" czy tylko pokazujemy badanka - "1"
        {
            InitializeComponent();
            if (procedure == 1)
            {
                button2.Visible = false;
                button3.Visible = false;
            }
            IDVis = IdVisit;
            idpat = IdPatient;
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
            showExaminationLab f2 = new showExaminationLab();
            
            f2.ShowDialog();
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
    }
}

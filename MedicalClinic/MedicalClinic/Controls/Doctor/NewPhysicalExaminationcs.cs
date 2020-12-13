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
        public NewPhysicalExaminationcs(int IDP, string IDV)
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

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int procedure = 1;
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

        }
    }
}

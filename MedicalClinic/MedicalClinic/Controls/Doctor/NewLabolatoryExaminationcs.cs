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
        public NewLabolatoryExaminationcs(int IDP, string IDV)
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
            this.Parent.Controls.Add(new LabolatoryExaminantion(0,"0",2)); //spr czy git
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewLabolatoryExaminationcs_Load(object sender, EventArgs e)
        {

        }
    }
}

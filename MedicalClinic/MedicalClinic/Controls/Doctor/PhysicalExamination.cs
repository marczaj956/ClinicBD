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

namespace MedicalClinic.Doctor
{
    public partial class PhysicalExamination : UserControl
    {
        private string IDVis;
        private int idpat;
        public PhysicalExamination(int IDP, string IDV)
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

            Mainlist.FullRowSelect = true;
            Mainlist.GridLines = true;

            var a = SQLDoc.GetPhyVis(IDP);
            Mainlist.Items.Clear();

            foreach (var order in a)
            {

                if (order.appointmentTable.Id_Appointment.ToString() == IDV)
                {
                    ListViewItem lvi = new ListViewItem(order.PhyTab.Id_Examination.ToString());
                    lvi.SubItems.Add(order.DicTab.Type.ToString()); //typ badania
                    lvi.SubItems.Add(order.PhyTab.Result); //wynik badania


                    Mainlist.Items.Add(lvi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new NewPhysicalExaminationcs(idpat, IDVis));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new ShowPhysicalExamination(idpat, IDVis));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new EditPhysicalExamination(idpat, IDVis));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mainlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }
    }
}

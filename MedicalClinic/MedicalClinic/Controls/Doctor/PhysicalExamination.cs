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
        public PhysicalExamination(int IdPatient, string IdVisit, int procedure)  // procedure informuje o trybie formatki czy edytowalna (zlec badanie)- "2" czy tylko pokazujemy badanka - "1"
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

            int idVisitInt = int.Parse(IdVisit);

            ExaminationsSearchCriteria examSearchCriteria = new ExaminationsSearchCriteria();
            examSearchCriteria.setAppointmentId(idVisitInt);
            examSearchCriteria.setPatientId(IdPatient);
            var a = SQLDoc.GetPhysicalExamination(examSearchCriteria);

           // var a = SQLDoc.GetPhyVis(idVisitInt);
            Mainlist.Items.Clear();

            foreach (var order in a)
            {

               // if (order.appointmentTable.Id_Appointment.ToString() == IdVisit)
              //  {
                    ListViewItem lvi = new ListViewItem(order.physicalExaminationTable.Id_Examination.ToString());
                    lvi.SubItems.Add(order.examDictionaryTable.Name); //typ badania
                    lvi.SubItems.Add(order.physicalExaminationTable.Result); //wynik badania


                    Mainlist.Items.Add(lvi);
               // }
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
            string idexam="";
            if (Mainlist.SelectedItems.Count > 0)
            {
                ListViewItem item = Mainlist.SelectedItems[0];

                idexam = (item.SubItems[0].Text.TrimEnd());
                    
            }
            else
            {
                MessageBox.Show("Nie wybrano badania");
            }

            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new ShowPhysicalExamination(idpat, IDVis, idexam));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

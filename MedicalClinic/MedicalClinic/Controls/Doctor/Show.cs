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
    public partial class Show : UserControl
    {
        private string IdVisit;
        private int IdPatient;
        public Show(int IDPatient, string IDVisit)
        {
            InitializeComponent();

            IdVisit = IDVisit;
            IdPatient = IDPatient;

            PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            searchCriteria.setPatientId(IDPatient);
            
            var res = SQLDoc.GetPatient(searchCriteria);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;


            }

            
            int x = Int32.Parse(IDVisit);
            var res1 = SQLDoc.GetAppointment(x);
            foreach (var order in res1)
            {
                textBox4.Text = order.Descirption;
                textBox5.Text = order.Diagnosis;
                

            }

        }

        private void button2_Click(object sender, EventArgs e) //return
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//show physical
        {
            int procedure = 1;
            int IdVisitInt = Int32.Parse(IdVisit);
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new PhysicalExamination(IdPatient, IdVisit,procedure));
        }

        private void button3_Click(object sender, EventArgs e) //show labo
        {
            int procedure = 1;
            int IdVisitInt = Int32.Parse(IdVisit);
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new LabolatoryExaminantion(IdPatient, IdVisit, procedure));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //var res = SQLDoc.GetPatient(IDP);
            //foreach (var order in res)
            //{
            //    textBox6.Text = order.patientTable.Id_Patient;
               

            //}
        }
    }
}

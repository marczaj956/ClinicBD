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
        private string IDVis;
        private int idpat;
        public Show(int IDP, string IDV)
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

            
            int x = Int32.Parse(IDV);
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
            // PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
            // long pesel = long.Parse(textBox3.Text.ToString());
            // //searchCriteria.setName(textBox1.Text.ToString());
            //// searchCriteria.setSurname(textBox2.Text.ToString());
            // searchCriteria.setPesel(pesel);
            // var res = SQLDoc.GetPatient(searchCriteria);
            // int id =-1;
            // foreach(var order in res)
            // {
            //     id = order.patientTable.Id_Patient;
            // }
            // if (id != -1)
            // {
            //     ShowPhisicExamList f2 = new ShowPhisicExamList(id);
            //     f2.ShowDialog();
            // }

            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new ShowPhysicalExamination(idpat, IDVis));
        }

        private void button3_Click(object sender, EventArgs e) //show labo
        {
            ShowLabExamList f2 = new ShowLabExamList();
            
            f2.ShowDialog();
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

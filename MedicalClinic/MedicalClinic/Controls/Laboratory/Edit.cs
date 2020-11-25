using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Controls.Laboratory
{
    public partial class Edit : UserControl
    {
        int idappo = 0;
        public Edit()
        {
            InitializeComponent();
           
        }
        public Edit(string role,int t) : this()
        {
            idappo = t;
            var temp = SqlQuerry.GetExamination_Laboratories_ID(t);
            textBox6.Text = temp.First().Table2.Type.ToString();
            textBox4.Text = temp.First().Table2.Exam_Code.ToString();
            
            textBox5.Text = temp.First().Table1.Result.ToString();
            textBox9.Text = temp.First().Table1.Comments_Doctor.ToString();
            textBox7.Text = temp.First().Table1.Comments_Man_Lab.ToString();
            var temp2 = SqlQuerry.GetPacjentID(temp.First().Table1.Id_Appointment);
            var temp3 = SqlQuerry.GetPatientData(temp2.First().Id_Patient);
            textBox1.Text = temp3.First().Name.ToString();
            textBox2.Text = temp3.First().Surname.ToString();
            textBox3.Text = temp3.First().PESEL.ToString();
            textBox10.Text= temp.First().Table1.State.ToString();
            if (role =="Lab")
            {
                textBox7.Enabled = false;
                button4.Enabled = false;
            }
            

        }
            private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Lab());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlQuerry.updateLabExam(idappo, "ANU", textBox5.Text, textBox7.Text);
            MessageBox.Show("Zmieniono dane badania");
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Lab());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlQuerry.updateLabExam(idappo, "ZAT", textBox5.Text, textBox7.Text);
            MessageBox.Show("Zmieniono stan badania");
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Lab());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlQuerry.updateLabExam(idappo, "ZAK", textBox5.Text, textBox7.Text);
            MessageBox.Show("Zmieniono stan badania");
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Lab());
        }
    }
}

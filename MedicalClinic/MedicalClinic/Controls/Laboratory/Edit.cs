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
        private TextBox text;
        private string roll;
        public Edit()
        {
            InitializeComponent();
           
        }
        public Edit(string role,int t, TextBox textb) : this()
        {
            text = textb;
            idappo = t;
            var temp = SQLLab.GetExamination_Laboratories_ID(t);
            textBox6.Text = temp.First().Table2.Name.ToString();
            textBox4.Text = temp.First().Table2.Exam_Code.ToString();
            
            textBox5.Text = temp.First().Table1.Result;
            textBox9.Text = temp.First().Table1.Comments_Doctor.ToString();
            textBox7.Text = temp.First().Table1.Comments_Man_Lab;
            var temp2 = SQLLab.GetPacjentID(temp.First().Table1.Id_Appointment);
            var temp3 = SQLLab.GetPatientData(temp2.First().Id_Patient);
            textBox1.Text = temp3.First().Name.ToString();
            textBox2.Text = temp3.First().Surname.ToString();
            textBox3.Text = temp3.First().PESEL.ToString();
            textBox10.Text= SQLLab.translateRolePL(temp.First().Table1.State.ToString());
            roll = role;
            if (role =="Lab")
            {
                textBox7.Enabled = false;
                button4.Enabled = false;
            }
            if (role=="MLab")
            {
                button3.Enabled = false;
            }

        }
            private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            text.Text = "changed";
            //Panel P = new Panel();
            //P.Controls.Clear();
            //this.Hide();
            //this.Parent.Controls.Add(new Lab());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roll == "MLab")
            {
                if (textBox7.Text != "")
                {
                    SQLLab.updateLabExam(idappo, "ANU", textBox5.Text, textBox7.Text);
                    MessageBox.Show("Zmieniono dane badania");
                    this.Controls.Clear();
                    this.Visible = false;
                    this.Parent.Hide();

                    text.Text = "changed";
                }
                else
                {
                    MessageBox.Show("Podaj przyczyne anulowania");
                }
            }
            else
            {
                if (textBox5.Text != "")
                {
                    SQLLab.updateLabExam(idappo, "ANU", textBox5.Text, textBox7.Text);
                    MessageBox.Show("Zmieniono dane badania");
                    this.Controls.Clear();
                    this.Visible = false;
                    this.Parent.Hide();

                    text.Text = "changed";
                }
                else
                {
                    MessageBox.Show("Podaj przyczyne anulowania");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLLab.updateLabExam(idappo, "ZAT", textBox5.Text, textBox7.Text, 1);
            MessageBox.Show("Zmieniono stan badania");
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            text.Text = "changed";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                SQLLab.updateLabExam(idappo, "ZAK", textBox5.Text, textBox7.Text);
                MessageBox.Show("Zmieniono stan badania");
                this.Controls.Clear();
                this.Visible = false;
                this.Parent.Hide();

                text.Text = "changed";
            }
            else
            {
                MessageBox.Show("Podaj wynik badania");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace MedicalClinic.Controls.Registration
{
    public partial class PatientEdit : UserControl
    {
        private int id = 0;
        private TextBox textb;
        public PatientEdit()
        {
            InitializeComponent();
        }

        public PatientEdit(int patid, TextBox text) : this()
        {
            textb = text;
            id = patid;
            var res = SQLLab.GetPatientData(patid);
            textBox1.Text = res.First().Name.ToString();
            textBox2.Text = res.First().Surname.ToString();
            textBox3.Text = res.First().PESEL.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e) //edit
        {

            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0 && Regex.IsMatch(textBox3.Text.ToString(), @"^(\d{11})$"))
            {
                SQLRec.EditPatient(id, textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Zmieniono dane pacjenta");
                this.Controls.Clear();
                this.Visible = false;
                this.Parent.Hide();

                textb.Text = "changed";
            }
            else MessageBox.Show("Brak Danych lub błędny pesel");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            textb.Text = "changed";
        }
    }
    
}

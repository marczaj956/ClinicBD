using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Registration;
using System.Text.RegularExpressions;

namespace MedicalClinic.Controls.Registration
{
    public partial class New : UserControl
    {
        private TextBox textb;
        public New()
        {
            InitializeComponent();
        }
        public New(TextBox text) : this()
        {
            textb = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            textb.Text = "changed";
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0 && Regex.IsMatch(textBox3.Text.ToString(), @"^(\d{11})$")) 
            {
                SQLRec.insertPatient(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Dodano pacjenta");
                this.Controls.Clear();
                this.Visible = false;
                this.Parent.Hide();

                textb.Text = "changed";
            }
            else MessageBox.Show("Brak Danych lub błędny pesel");
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

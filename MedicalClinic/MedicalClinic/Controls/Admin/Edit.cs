using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Doctor;

namespace MedicalClinic.Admin
{
    public partial class Edit : UserControl
    {
        private TextBox text;
        private int Id;
        public Edit()
        {
            InitializeComponent();
        }
        public Edit(TextBox textb,int id) : this()
        {
            text = textb;
            Id = id;


            
            var result = SQLAdm.GetStaff(Id);
            textBox1.Text = result.First().Name.ToString();
            textBox2.Text = result.First().Login.ToString();
            Name1.Text = result.First().Name.ToString();
            Surname.Text = Surname2.Text = result.First().Surname.ToString();
            Login.Text = result.First().Login.ToString();
            Password.Text = result.First().Password.ToString();
            Role.Text = SQLAdm.translateRolePL(result.First().Role.ToString());
            if (result.First().Active.ToString() == "T")
                Activ.Checked = true;
            else Activ.Checked = false;



        }


        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            //zapis do bazy
            char act = 'F';
            if (Activ.Checked)
            {
                act = 'T';
            }
            if (Name1.TextLength != 0 && Surname2.TextLength != 0 && Password.TextLength != 0)
            {
                SQLAdm.updatestaff(Name1.Text.ToString(), Surname2.Text.ToString(), Password.Text.ToString(), SQLAdm.translateRoleDB(Role.Text.ToString()), act, Id);
                this.Controls.Clear();
                this.Visible = false;
                this.Parent.Hide();

                text.Text = "changed";
            }
            else MessageBox.Show("Brak Danych");

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
            
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

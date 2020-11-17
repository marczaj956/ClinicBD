using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Admin
{
    public partial class AddNew : UserControl
    {
        private TextBox text;
        public AddNew()
        {
            InitializeComponent();
            

        }


        public AddNew(TextBox textb) : this()
        {
            text = textb;
        }



    private void SaveAndClose_Click(object sender, EventArgs e)
        {  //zapis
            char act = 'F';
            if (Activ.Checked)
            {
                act = 'T';
            }


            if (Name.TextLength != 0 && Surname.TextLength != 0 && Login.TextLength != 0 && Password.TextLength != 0)
            {
                SqlQuerry.insertstaff(Name.Text.ToString(), Surname.Text.ToString(), Login.Text.ToString(), Password.Text.ToString(), SqlQuerry.translateRoleDB(Role.Text.ToString()), act);
            }
            else MessageBox.Show("Brak Danych");


            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

            text.Text = "changed";

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }
    }
}

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

        public string CreateMD5Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {    // Step 1, calculate MD5 hash from input
                 // MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Step 2, convert byte array to hex string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }

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
                //SQLAdm.insertstaff(Name.Text.ToString(), Surname.Text.ToString(), Login.Text.ToString(), Password.Text.ToString(), SQLAdm.translateRoleDB(Role.Text.ToString()), act);
                SQLAdm.insertstaff(Name.Text.ToString(), Surname.Text.ToString(), Login.Text.ToString(), CreateMD5Hash(Password.Text.ToString()), SQLAdm.translateRoleDB(Role.Text.ToString()), act);


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
    }
}

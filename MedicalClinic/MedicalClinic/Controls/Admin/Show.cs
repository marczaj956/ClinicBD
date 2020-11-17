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
    public partial class Show : UserControl
    {
        private int Id = 1;
        public Show()
        {
            InitializeComponent();
        }

        public Show(int id):this()
        {
            
            
            
            
            var result= SqlQuerry.GetStaff(id);
            Name.Text = result.First().Name.ToString();
            Name1.Text = result.First().Name.ToString();
            Surname.Text=Surname2.Text= result.First().Surname.ToString();
            Login.Text= result.First().Login.ToString();
            Password.Text = result.First().Password.ToString();
            Role.Text =SqlQuerry.translateRolePL (result.First().Role.ToString());
            if (result.First().Active.ToString() == "T")
                Activ.Checked = true;
            else Activ.Checked = false;
            

        }


        private void Back_Click(object sender, EventArgs e)
        {
            /*Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Admincs());*/

            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();

        }
    }
}

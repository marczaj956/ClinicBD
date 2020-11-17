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
        public Edit()
        {
            InitializeComponent();
        }
        public Edit(TextBox textb) : this()
        {
            text = textb;
        }


        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            //zapis do bazy
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
            //this.Parent.Parent.Refresh();
            //text.Text = "changed";
        }
    }
}

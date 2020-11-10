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
        public AddNew()
        {
            InitializeComponent();
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {  //zapis
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Admincs());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Admincs());
        }
    }
}

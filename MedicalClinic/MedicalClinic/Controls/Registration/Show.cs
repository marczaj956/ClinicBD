using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Controls.Registration;
using MedicalClinic.Registration;

namespace MedicalClinic.Controls.Registration
{
    public partial class Show : UserControl
    {
        public Show()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Reg());

        }
    }
}

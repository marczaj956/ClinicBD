using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Controls.Doctor;

namespace MedicalClinic.Doctor
{
    public partial class Handle : UserControl
    {
        public Handle()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //show phisical
        {
          
        }

        private void button3_Click(object sender, EventArgs e) //show labo
        {
           
        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Doctor());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Controls.Doctor
{
    public partial class LabolatoryExaminantion : UserControl
    {
        public LabolatoryExaminantion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new NewLabolatoryExaminationcs());

        }

        private void button3_Click(object sender, EventArgs e)   // TO DO: jeśli przechodzi przed edycje badania to wpisać id badania, jeśli nowy to id puste
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new NewLabolatoryExaminationcs());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showExaminationLab f2 = new showExaminationLab();
            
            f2.ShowDialog();
        }
    }
}

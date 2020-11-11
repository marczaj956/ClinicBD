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
    public partial class Show : UserControl
    {
        public Show()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //return
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Doctor());
        }

        private void button4_Click(object sender, EventArgs e)//show physical
        {
            ShowPhisicExamList f2 = new ShowPhisicExamList();
            
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //show labo
        {
            ShowLabExamList f2 = new ShowLabExamList();
            
            f2.ShowDialog();
        }
    }
}

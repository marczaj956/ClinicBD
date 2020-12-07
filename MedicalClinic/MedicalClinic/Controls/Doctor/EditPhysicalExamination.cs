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

namespace MedicalClinic.Controls.Doctor
{
    public partial class EditPhysicalExamination : UserControl
    {
        public EditPhysicalExamination()
        {
            InitializeComponent();

            var res = SQLDoc.GetPatient(1);
            foreach (var order in res)
            {
                textBox1.Text = order.patientTable.Name;
                textBox2.Text = order.patientTable.Surname;
                textBox3.Text = order.patientTable.PESEL;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new PhysicalExamination());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

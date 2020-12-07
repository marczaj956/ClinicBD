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
    public partial class EditLabExamination : UserControl
    {
        public EditLabExamination()
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
            this.Parent.Controls.Add(new LabolatoryExaminantion());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

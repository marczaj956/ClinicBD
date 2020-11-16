using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Doctor
{
    public partial class Doctor : UserControl
    {
        public Doctor()
        {
            InitializeComponent();


            var res = SqlQuerry.pacjent("", "", "");

            /* foreach (var order in res)
             {
                 ListViewItem lvi = new ListViewItem(order.Table1.Id_Appointment.ToString());
                 lvi.SubItems.Add(order.Table2.Name);
                 lvi.SubItems.Add(order.Table2.Surname);
                 listView1.Items.Add(lvi);

             }*/

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //logout
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new MainPanel.MainPanel());
        }

        private void button2_Click(object sender, EventArgs e) //show
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Show());
        }

        private void button3_Click(object sender, EventArgs e) //handle
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Handle());
        }
    }
}

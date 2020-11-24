using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Controls.Laboratory
{
    public partial class Lab : UserControl
    {
        private int whoami;
        private string myrole;
        public Lab()
        {
            InitializeComponent();
            var temp = SqlQuerry.GetExamination_Laboratories("", "", "");
            listView1.Items.Clear();
            foreach (var order in temp)
            {
                ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                lvi.SubItems.Add(order.Table2.Type.ToString()); 
                lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                lvi.SubItems.Add(order.Table1.State.ToString());
              
                listView1.Items.Add(lvi);

            }
        }

        public Lab(int id, string role):this()
        {
            whoami = id;
            myrole = role;
            textBox1.Text = myrole;
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Panel P = new Panel();
                P.Controls.Clear();
                this.Hide();
                this.Parent.Controls.Add(new Edit(myrole,Int16.Parse(item.SubItems[0].Text.TrimEnd())));
            }
            else
            {
                MessageBox.Show("Nie wybrano badania");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Panel P = new Panel();
                P.Controls.Clear();
                this.Hide();
                this.Parent.Controls.Add(new Show(Int16.Parse(item.SubItems[0].Text.TrimEnd())));
            }
            else
            {
                MessageBox.Show("Nie wybrano badania");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new MainPanel.MainPanel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = SqlQuerry.GetExamination_Laboratories(textBox2.Text, comboBox1.Text, "");
            listView1.Items.Clear();
            foreach (var order in temp)
            {
                ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                lvi.SubItems.Add(order.Table2.Type.ToString());
                lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                lvi.SubItems.Add(order.Table1.State.ToString());

                listView1.Items.Add(lvi);

            }
        }
    }
}

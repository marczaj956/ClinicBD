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
            
            string startowadata = dateTimePicker1.Value.Year.ToString();
            startowadata += "-";
            startowadata += dateTimePicker1.Value.Month.ToString();
            startowadata += "-";
            startowadata += dateTimePicker1.Value.Day.ToString();
            startowadata += " 00:00:00.000";
            listView1.Items.Clear();
           
            
               var temp = SQLLab.GetExamination_Laboratories("", "PRZET", startowadata);
                foreach (var order in temp)
                {
                    ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                    lvi.SubItems.Add(order.Table2.Type.ToString());
                    lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                    lvi.SubItems.Add(order.Table1.State.ToString());

                    listView1.Items.Add(lvi);

                }
            
           
            
           
            comboBox1.Text = "PRZET";
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
            listView1.Items.Clear();
            if (dateTimePicker1.Checked == true)
            {
                string tmp = dateTimePicker1.Text;
                tmp+= " 00:00:00.000";
                var temp = SQLLab.GetExamination_Laboratories(textBox2.Text, comboBox1.Text, tmp);


                foreach (var order in temp)
                {
                    ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                    lvi.SubItems.Add(order.Table2.Type.ToString());
                    lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                    lvi.SubItems.Add(order.Table1.State.ToString());

                    listView1.Items.Add(lvi);

                }
            }
            else
            {
                var temp = SQLLab.GetExamination_Laboratories2(textBox2.Text, comboBox1.Text);
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
}

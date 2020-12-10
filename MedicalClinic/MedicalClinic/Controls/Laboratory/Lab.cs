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
            
            
           
            
        }

        public Lab(int id, string role):this()
        {
            whoami = id;
            myrole = role;
            textBox1.Text = myrole;
            string startowadata = dateTimePicker1.Value.Year.ToString();
            startowadata += "-";
            startowadata += dateTimePicker1.Value.Month.ToString();
            startowadata += "-";
            startowadata += dateTimePicker1.Value.Day.ToString();
            startowadata += " 00:00:00.000";
            listView1.Items.Clear();

            if (myrole == "Lab")
            {
                var temp = SQLLab.GetExamination_Laboratories("", "ZLE", startowadata);


                foreach (var order in temp)
                {
                    ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                    lvi.SubItems.Add(order.Table2.Type.ToString());
                    lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                    lvi.SubItems.Add(order.Table1.State.ToString());

                    listView1.Items.Add(lvi);

                }
                comboBox1.Text = "Zlecone";
            }
            if (myrole == "MLab")
            {
                var temp = SQLLab.GetExamination_Laboratories("", "ZAT", startowadata);


                foreach (var order in temp)
                {
                    ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                    lvi.SubItems.Add(order.Table2.Type.ToString());
                    lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                    lvi.SubItems.Add(order.Table1.State.ToString());

                    listView1.Items.Add(lvi);

                }
                comboBox1.Text = "Zatwierdzone";
            }
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem item = listView1.SelectedItems[0];
                WindowPanel.Controls.Add(new Edit(myrole, Int16.Parse(item.SubItems[0].Text.TrimEnd()),connector));
                WindowPanel.Visible = true;
                WindowPanel.Dock = DockStyle.Fill;
                WindowPanel.BringToFront();

                //ListViewItem item = listView1.SelectedItems[0];
                //Panel P = new Panel();
                //P.Controls.Clear();
                //this.Hide();
                //this.Parent.Controls.Add(new Edit(myrole,Int16.Parse(item.SubItems[0].Text.TrimEnd())));
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
                WindowPanel.Controls.Add(new Show(Int16.Parse(item.SubItems[0].Text.TrimEnd()),connector));
                WindowPanel.Visible = true;
                WindowPanel.Dock = DockStyle.Fill;
                WindowPanel.BringToFront();

                //ListViewItem item = listView1.SelectedItems[0];
                //Panel P = new Panel();
                //P.Controls.Clear();
                //this.Hide();
                //this.Parent.Controls.Add(new Show(Int16.Parse(item.SubItems[0].Text.TrimEnd())));
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
            refreshlistview();
        }
        private void connector_TextChanged(object sender, EventArgs e)
        {
            refreshlistview();

            connector.Text = "";
        }
        private void connector_TextChanged_1(object sender, EventArgs e)
        {
            refreshlistview();

            connector.Text = "";
        }
        private void refreshlistview()
        {
            listView1.Items.Clear();
            if (dateTimePicker1.Checked == true)
            {
                string tmp = dateTimePicker1.Text;
                tmp += " 00:00:00.000";
                var temp = SQLLab.GetExamination_Laboratories(textBox2.Text, SQLLab.translateRoleDB(comboBox1.Text), tmp);


                foreach (var order in temp)
                {
                    ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                    lvi.SubItems.Add(order.Table2.Type.ToString());
                    lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                    lvi.SubItems.Add(SQLLab.translateRolePL(order.Table1.State.ToString()));

                    listView1.Items.Add(lvi);

                }
            }
            else
            {
                var temp = SQLLab.GetExamination_Laboratories2(textBox2.Text, SQLLab.translateRoleDB(comboBox1.Text));
                foreach (var order in temp)
                {
                    ListViewItem lvi = new ListViewItem(order.Table1.Id_Examination.ToString());
                    lvi.SubItems.Add(order.Table2.Type.ToString());
                    lvi.SubItems.Add(order.Table1.Date_Of_Order.ToString());
                    lvi.SubItems.Add(SQLLab.translateRolePL(order.Table1.State.ToString()));

                    listView1.Items.Add(lvi);

                }
            }
        }

        private void connector_TextChanged_2(object sender, EventArgs e)
        {
            refreshlistview();

            connector.Text = "";
        }
    }
}

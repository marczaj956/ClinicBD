using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic.Controls.Registration
{
    public partial class Reg : UserControl
    {
        private int whoami;
        public Reg()
        {
            InitializeComponent();
            listView1.Items.Clear();
            var res = SQLRec.GetPatientsList("", "", "");
            foreach (var order in res)
            {
                ListViewItem lvi = new ListViewItem(order.Name.ToString());
                lvi.SubItems.Add(order.Surname);
                lvi.SubItems.Add(order.PESEL);
                listView1.Items.Add(lvi);

            }
            //dataGridView1.DataSource = 

        }
        public Reg(int id):this()
        {
           
            whoami = id;
            connector.Text = whoami.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e) //logout
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new MainPanel.MainPanel());
        }

        private void button2_Click(object sender, EventArgs e) //new
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new New());
        }

        private void button3_Click(object sender, EventArgs e)//visit registarion
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

               
                var res = SQLRec.GetPatientsList(item.SubItems[0].Text.TrimEnd(), item.SubItems[1].Text.TrimEnd(),item.SubItems[2].Text.TrimEnd());
                foreach(var x in res)
                {

                    /*Panel P = new Panel();
                    P.Controls.Clear();
                    this.Hide();
                    this.Parent.Controls.Add(new VisitRegistration(x.Id_Patient));*/

                    WindowPanel.Controls.Add(new VisitRegistration(x.Id_Patient,connector));
                    WindowPanel.Visible = true;
                    WindowPanel.Dock = DockStyle.Fill;
                    WindowPanel.BringToFront();


                }
                
                
                

               
            }
            else
            {
                MessageBox.Show("Nie wybrano pacjenta");
            }

              
        }

        private void button6_Click(object sender, EventArgs e)//edit
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Edit());
        }

        private void button4_Click(object sender, EventArgs e)//show
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Show());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new MainPanel.MainPanel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var res = SQLRec.GetPatientsList(textBox1.Text,textBox2.Text ,textBox3.Text );
            foreach (var order in res)
            {
                ListViewItem lvi = new ListViewItem(order.Name.ToString());
                lvi.SubItems.Add(order.Surname);
                lvi.SubItems.Add(order.PESEL);
                listView1.Items.Add(lvi);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void refresh()
        {
            listView1.Items.Clear();
            var res = SQLRec.GetPatientsList(textBox1.Text, textBox2.Text, textBox3.Text);
            foreach (var order in res)
            {
                ListViewItem lvi = new ListViewItem(order.Name.ToString());
                lvi.SubItems.Add(order.Surname);
                lvi.SubItems.Add(order.PESEL);
                listView1.Items.Add(lvi);

            }
        }

        private void connector_TextChanged(object sender, EventArgs e)
        {
            refresh();
            connector.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void przegladWizytToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void przegladWizytToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void przegladarkaWizytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new VisitViewercs());
        }
    }
}

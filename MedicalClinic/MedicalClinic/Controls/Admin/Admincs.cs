using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.MainPanel;

namespace MedicalClinic.Admin
{
    public partial class Admincs : UserControl
    {
        public Admincs()
        {
            InitializeComponent();

            dataGridView1.DataSource = SqlQuerry.GetStaff("", "", "", "");

            //na liste 
            /*foreach (var order in res)
            {
                ListViewItem lvi = new ListViewItem(order.Id_Staff.ToString());
                lvi.SubItems.Add(order.Name);
                lvi.SubItems.Add(order.Surname);
                listView1.Items.Add(lvi);
                
            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOut_Click(object sender, EventArgs e)
        {

            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new MainPanel.MainPanel());
                      
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new AddNew());
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Edit());
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Show());
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}

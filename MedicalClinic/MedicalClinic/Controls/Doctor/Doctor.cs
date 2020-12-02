using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MedicalClinic.SQLDoc;

namespace MedicalClinic.Doctor
{
    public partial class Doctor : UserControl
    {
        private int whoami;
        public Doctor()
        {
            InitializeComponent();

        }

        public Doctor(int id) : this()
        {

            var res = SQLAdm.pacjent("", "", "");
            /* foreach (var order in res)
             {
                 ListViewItem lvi = new ListViewItem(order.Table1.Id_Appointment.ToString());
                 lvi.SubItems.Add(order.Table2.Name);
                 lvi.SubItems.Add(order.Table2.Surname);
                 listView1.Items.Add(lvi);

             }*/
            whoami = id;
            connector.Text = whoami.ToString();
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


        private void Refresh(IQueryable<TableJoinResult3> a)
        {
            listView1.Items.Clear();
            foreach (var order in a)
            {
                ListViewItem lvi = new ListViewItem(order.Table1.Id_Appointment.ToString());
                lvi.SubItems.Add(order.Table1.State); //stan
                lvi.SubItems.Add(order.Table3.Name); //imie
                lvi.SubItems.Add(order.Table3.Surname); //nazwisko 
                lvi.SubItems.Add(order.Table3.PESEL); //pesel
                lvi.SubItems.Add(order.Table1.Date_Appointment.ToString()); //data
                lvi.SubItems.Add(order.Table2.Surname.ToString()); //nazwisko
                
                listView1.Items.Add(lvi);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Refresh(SQLDoc.GetVisit(comboBox2.Text.ToString(), dateTimePicker1.Value.Date));
            }
            else
            {
                Refresh(SQLDoc.GetAllVisit(comboBox2.Text.ToString(), dateTimePicker1.Value.Date));
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

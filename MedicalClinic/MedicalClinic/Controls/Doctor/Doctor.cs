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

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        public Doctor(int id) : this()
        {

         //   var res = SQLAdm.pacjent("", "", "");
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
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];



                PatientsSearchCriteria searchCriteria = new PatientsSearchCriteria();
                long pesel = long.Parse(item.SubItems[4].Text.TrimEnd());
                searchCriteria.setPesel(pesel);
               // Refresh(SQLDoc.GetPatient(searchCriteria));

                var res = SQLDoc.GetPatient(searchCriteria);
                foreach (var x in res)
                {
                    panel1.Controls.Add(new Show(x.patientTable.Id_Patient,item.SubItems[0].Text.TrimEnd()));
                    panel1.Visible = true;
                    panel1.Dock = DockStyle.Fill;
                    panel1.BringToFront();


                }





            }
            else
            {
                MessageBox.Show("Nie wybrano pacjenta");
            }


          //  Panel P = new Panel();
           // P.Controls.Clear();
           // this.Hide();
          //  this.Parent.Controls.Add(new Show());
        }

        private void button3_Click(object sender, EventArgs e) //handle
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Handle());
        }


        private void Refresh(IQueryable<TableJoinResult> a)
        {
            listView1.Items.Clear();
            foreach (var order in a)
            {
                ListViewItem lvi = new ListViewItem(order.appointmentTable.Id_Appointment.ToString());
                char st = char.Parse(order.appointmentTable.State);
                string state = Enum.GetName(typeof(State), st);
                lvi.SubItems.Add(state); //stan
                lvi.SubItems.Add(order.patientTable.Name); //imie
                lvi.SubItems.Add(order.patientTable.Surname); //nazwisko 
                lvi.SubItems.Add(order.patientTable.PESEL); //pesel
                lvi.SubItems.Add(order.appointmentTable.Date_Appointment.ToString()); //data
                lvi.SubItems.Add(order.staffTable.Surname.ToString()); //nazwisko
                
                listView1.Items.Add(lvi);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            State stateTemp = (State)Enum.Parse(typeof(State), comboBox2.Text);

            VisitsSearchCriteria searchCriteria = new VisitsSearchCriteria();
            searchCriteria.setDate(dateTimePicker1.Value.Date, dateTimePicker1.Checked);
            searchCriteria.setState(stateTemp);
            searchCriteria.setOnlyVisitsForDoctor(checkBox1.Checked);
            searchCriteria.setDoctorId(this.whoami);
            Refresh(SQLDoc.GetVisits(searchCriteria));


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

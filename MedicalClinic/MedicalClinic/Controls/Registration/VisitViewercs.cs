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
    public partial class VisitViewercs : UserControl
    {
        public VisitViewercs()
        {
            InitializeComponent();
        }



        private int patid;
        private TextBox textb;
        private IQueryable<Staff> docs;
        private string startowadata;
        public VisitViewercs(int ID, TextBox text) : this()
        {
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            patid = ID;
            textb = text;
            var res = SQLLab.GetPatientData(patid);
            foreach (var order in res)
            {
               textBox1.Text = order.PESEL;

            }

            docs = SQLAdm.GetStaff("", "", "", "doc");
            foreach (var order in docs)
            {
                comboBox3.Items.Add(order.Surname);
            }
            
            listView1.Items.Clear();

            var temp = SQLRec.GetApo(patid);
            foreach (var order in temp)
            {
                ListViewItem lvi = new ListViewItem(order.Id_Appointment.ToString());
                var tmp =SQLRec.GetDocData(order.Id_Doctor);
                string name = tmp.FirstOrDefault().Name + " " + tmp.FirstOrDefault().Surname;
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(order.Date_Appointment.ToString());
                lvi.SubItems.Add(SQLRec.translateRolePL( order.State.ToString()));

                listView1.Items.Add(lvi);

            }




        }

        

        private void VisitViewercs_Load(object sender, EventArgs e)
        {

        }

        private void przegladarkaPacjentowToolStripMenuItem_Click(object sender, EventArgs e)
        {//edytuj
           
        }

        private void button2_Click(object sender, EventArgs e)
        {//edytuj
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];


                {



                    WindowPanel.Controls.Add(new Registration.Edit(Int32.Parse(item.Text), connector));
                    WindowPanel.Visible = true;
                    WindowPanel.Dock = DockStyle.Fill;
                    WindowPanel.BringToFront();


                }
                listView1.SelectedItems.Clear();

            }
            else MessageBox.Show("Wybierz wizytę");
        }

        private void button5_Click(object sender, EventArgs e)
        {//pokaż


            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];


                {

                  

                    WindowPanel.Controls.Add(new Registration.Show(Int32.Parse(item.Text), connector));
                    WindowPanel.Visible = true;
                    WindowPanel.Dock = DockStyle.Fill;
                    WindowPanel.BringToFront();


                }
                listView1.SelectedItems.Clear();
            }
            else MessageBox.Show("Wybierz wizytę");
        }

        private void button7_Click(object sender, EventArgs e)
        {//wyloguj
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new MainPanel.MainPanel());
        }
        private string datetostring()
        {
            startowadata = dateTimePicker1.Value.Year.ToString();
            startowadata += "-";
            startowadata += dateTimePicker1.Value.Month.ToString();
            startowadata += "-";
            startowadata += dateTimePicker1.Value.Day.ToString();
           // startowadata += " 00:00:00.000";
            return startowadata;
        }

        private void listupdate(IQueryable<Appointment> temp)
        {
            listView1.Items.Clear();
           
            foreach (var order in temp)
            {
                ListViewItem lvi = new ListViewItem(order.Id_Appointment.ToString());
                var tmp = SQLRec.GetDocData(order.Id_Doctor);
                string name = tmp.FirstOrDefault().Name + " " + tmp.FirstOrDefault().Surname;
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(order.Date_Appointment.ToString());
                lvi.SubItems.Add(SQLRec.translateRolePL(order.State.ToString()));

                listView1.Items.Add(lvi); ;

            }
        }


        private void reload()
        { 
            var doc = docs.AsEnumerable<Staff>();
            if (dateTimePicker1.Checked == true)
            {
                if (comboBox3.SelectedIndex >= 0)
                {
                    int docid = doc.ElementAt<Staff>(comboBox3.SelectedIndex).Id_Staff;
                    var temp = SQLRec.GetApo(patid, SQLRec.translateRoleDB(comboBox1.Text.ToString()), docid, datetostring());
                    listupdate(temp);
                }
                else
                {
                    var temp = SQLRec.GetApo(patid,SQLRec.translateRoleDB( comboBox1.Text.ToString()), datetostring());
                    listupdate(temp);
                }
               

            }

            else 
            {
                if (comboBox3.SelectedIndex >= 0)
                {
                    int docid = doc.ElementAt<Staff>(comboBox3.SelectedIndex).Id_Staff;
                    var temp = SQLRec.GetApo(patid, SQLRec.translateRoleDB(comboBox1.Text.ToString()), docid);
                    listupdate(temp);
                }
                else
                {
                    var temp = SQLRec.GetApo(patid, SQLRec.translateRoleDB(comboBox1.Text.ToString()));
                    listupdate(temp);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            reload();




            }

        private void connector_TextChanged(object sender, EventArgs e)
        {
            reload();
            connector.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }
    }
    }
    


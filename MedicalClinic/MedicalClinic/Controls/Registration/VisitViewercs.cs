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
                ListViewItem lvi = new ListViewItem(order.Id_Patient.ToString());
                lvi.SubItems.Add(order.Id_Doctor.ToString());
                lvi.SubItems.Add(order.Date_Appointment.ToString());
                lvi.SubItems.Add(order.State.ToString());

                listView1.Items.Add(lvi);

            }




        }

        

        private void VisitViewercs_Load(object sender, EventArgs e)
        {

        }

        private void przegladarkaPacjentowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Reg());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Edit());
        }

        private void button5_Click(object sender, EventArgs e)
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
        {   if (dateTimePicker1.Checked == true)
            {
                var doc = docs.AsEnumerable<Staff>();
                if (comboBox3.SelectedIndex >= 0)
                {
                    int docid = doc.ElementAt<Staff>(comboBox3.SelectedIndex).Id_Staff;

                    startowadata = dateTimePicker1.Value.Year.ToString();
                    startowadata += "-";
                    startowadata += dateTimePicker1.Value.Month.ToString();
                    startowadata += "-";
                    startowadata += dateTimePicker1.Value.Day.ToString();
                    startowadata += " 00:00:00.000";
                    listView1.Items.Clear();
                    var temp = SQLRec.GetApo(patid, comboBox1.Text.ToString(), docid, startowadata);
                    foreach (var order in temp)
                    {
                        ListViewItem lvi = new ListViewItem(order.Id_Patient.ToString());
                        lvi.SubItems.Add(order.Id_Doctor.ToString());
                        lvi.SubItems.Add(order.Date_Appointment.ToString());
                        lvi.SubItems.Add(order.State.ToString());

                        listView1.Items.Add(lvi);

                    }
                }
                else
                {
                    listView1.Items.Clear();
                    var temp = SQLRec.GetApo(patid, comboBox1.Text.ToString());
                    foreach (var order in temp)
                    {
                        ListViewItem lvi = new ListViewItem(order.Id_Patient.ToString());
                        lvi.SubItems.Add(order.Id_Doctor.ToString());
                        lvi.SubItems.Add(order.Date_Appointment.ToString());
                        lvi.SubItems.Add(order.State.ToString());

                        listView1.Items.Add(lvi);

                    }
                }
            }
            else
            {
                var doc = docs.AsEnumerable<Staff>();
                if (comboBox3.SelectedIndex >= 0)
                {
                    int docid = doc.ElementAt<Staff>(comboBox3.SelectedIndex).Id_Staff;

                    listView1.Items.Clear();
                    var temp = SQLRec.GetApo(patid, comboBox1.Text.ToString(), docid);
                    foreach (var order in temp)
                    {
                        ListViewItem lvi = new ListViewItem(order.Id_Patient.ToString());
                        lvi.SubItems.Add(order.Id_Doctor.ToString());
                        lvi.SubItems.Add(order.Date_Appointment.ToString());
                        lvi.SubItems.Add(order.State.ToString());

                        listView1.Items.Add(lvi);

                    }
                }
                
            }

        }
    }
    }


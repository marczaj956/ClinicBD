using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Controls.Doctor;
using MedicalClinic.Doctor;

namespace MedicalClinic.Controls.Doctor
{
    public partial class HistoryLaboratoryExamination : UserControl
    {
        private int idpat;
        public HistoryLaboratoryExamination()
        {
            InitializeComponent();
        }


        public HistoryLaboratoryExamination(int IDP)
        {
            idpat = IDP;
            InitializeComponent();


            var a = SQLDoc.GetLab(IDP);
            Mainlist.Items.Clear();

            foreach (var order in a)
            {


                ListViewItem lvi = new ListViewItem(order.LabTab.Id_Examination.ToString());
                lvi.SubItems.Add(order.appointmentTable.Date_Appointment.ToString()); //data
                lvi.SubItems.Add(order.staffTable.Surname); //nazwisko lekarza
                lvi.SubItems.Add(order.LabTab.State); //stan


                Mainlist.Items.Add(lvi);

            }
            Mainlist.FullRowSelect = true;
            Mainlist.GridLines = true;
        }


        private void Mainlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mainlist.SelectedItems.Count > 0)
            {
                ListViewItem item = Mainlist.SelectedItems[0];


                var vis = SQLDoc.GetHisL(Int32.Parse(item.SubItems[0].Text));

                {

                    textBox1.Text = vis.First().Result;//wyn
                    textBox2.Text = vis.First().Comments_Man_Lab;//kom m
                    textBox9.Text = vis.First().Comments_Doctor;//kom l



                }
            }
        }
    }
}

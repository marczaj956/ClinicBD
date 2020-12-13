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
    public partial class HistoryPhysicalExamination : UserControl
    {
        private int idpat;
        public HistoryPhysicalExamination()
        {
            InitializeComponent();
        }


        public HistoryPhysicalExamination(int IDP)
        {
            idpat = IDP;
            InitializeComponent();


            var a = SQLDoc.GetPhy(IDP);
            Mainlist.Items.Clear();

            foreach (var order in a)
            {


                ListViewItem lvi = new ListViewItem(order.physicalExaminationTable.Id_Examination.ToString());
                lvi.SubItems.Add(order.appointmentTable.Date_Appointment.ToString()); //data
                lvi.SubItems.Add(order.staffTable.Surname); //nazwisko lekarza
               // lvi.SubItems.Add(order.PhyTab.); //stan


                Mainlist.Items.Add(lvi);

            }
            Mainlist.FullRowSelect = true;
            Mainlist.GridLines = true;
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


                var vis = SQLDoc.GetHisP(Int32.Parse(item.SubItems[0].Text));

                {

                    textBox6.Text = vis.First().Exam_Code;//rodzaj
                    
                    textBox9.Text = vis.First().Result;//wyn



                }
            }
        
    }
    }
}

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
using static MedicalClinic.SQLDoc;


namespace MedicalClinic.Controls.Doctor
{
    public partial class HistoryVisits : UserControl
    {
        public HistoryVisits(int id)
        {
            InitializeComponent();

            Refresh(SQLDoc.GetAppointmentP(id));
        }
        private void Refresh(IQueryable<TableJoinResult> a)
        {
            Mainlist.Items.Clear();
            foreach (var order in a)
            {
                ListViewItem lvi = new ListViewItem(order.appointmentTable.Id_Appointment.ToString());
                lvi.SubItems.Add(order.appointmentTable.Date_Appointment.ToString()); //data
                lvi.SubItems.Add(order.staffTable.Surname); //nazwisko lekarza
                lvi.SubItems.Add(order.appointmentTable.State); //stan
               

                Mainlist.Items.Add(lvi);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Mainlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Handle());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

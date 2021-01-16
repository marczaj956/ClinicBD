using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace MedicalClinic.Controls.Registration
{
    public partial class Edit : UserControl
    {
        private int apoid;
        private TextBox textb;
        private IQueryable<Staff> docs;
        public Edit()
        {
            InitializeComponent();
        }



        public Edit(int ID, TextBox text) : this()
        {
            apoid = ID;
            textb = text;
            
            var a = SQLRec.GetApoSE(apoid);
            //comboBox4.drop

            var res = SQLLab.GetPatientData(a.First().Id_Patient);
            foreach (var order in res)
            {
                textBox1.Text = order.Name;
                textBox2.Text = order.Surname;
                textBox3.Text = order.PESEL;

            }
            docs = SQLAdm.GetStaff("", "", "", "doc");
            foreach (var order in docs)
            {
                comboBox1.Items.Add(order.Surname);
            }

            var doc = SQLAdm.GetStaff(a.First().Id_Doctor);
            comboBox1.Text = doc.First().Name.ToString();//lekarz
            monthCalendar1.SetDate(a.First().Date_Appointment);//data
            comboBox3.Text = SQLRec.translateRolePL( a.First().State.ToString());//stan
            //string time = a.First().Date_Appointment.Hour.ToString()+":" + a.First().Date_Appointment.Minute.ToString();
           string time= a.First().Date_Appointment.ToString("HH:mm");
            comboBox2.Text = time;//godzina
            comboBox4.Text = time;
            // comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            // comboBox2.Text = a.First().Date_Appointment.TimeOfDay.ToString();


        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.Parent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {//zapisz i zamknij
            if (comboBox1.Text != ""&&comboBox2.Text!="")
            {
                var doc = docs.AsEnumerable<Staff>();

                int docid = doc.ElementAt<Staff>(comboBox1.SelectedIndex).Id_Staff;
                string culture = "mn-MN";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);

                string datetosql = monthCalendar1.SelectionStart.ToShortDateString();
                datetosql += " " + comboBox2.Text;
                DateTime dt = DateTime.Parse(datetosql);
                {

                    SQLRec.updateApo(apoid, SQLRec.translateRoleDB(comboBox3.Text.ToString()), docid, dt);
                }

                this.Controls.Clear();
                this.Visible = false;
                this.Parent.Hide();

                textb.Text = "changed";
            }
            else
            {
                MessageBox.Show("Wprowadz poprawne informacje");
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //usun i zamknij
        //    var a = SQLRec.GetApoSE(apoid);
        //    if (a.First().State != "ZLE")//to może trzeba będzie poprawić jak ustalimy stany
        //        SQLRec.deleteApo(apoid);
        //    else MessageBox.Show("Nie można usunąć rozpoczętej lub historycznej wizyty");
        //    this.Controls.Clear();
        //    this.Visible = false;
        //    this.Parent.Hide();

        //    textb.Text = "changed";
        //}
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalClinic.Laboratory;

namespace MedicalClinic.Controls.Laboratory
{
    public partial class Show : UserControl
    {
        
        public Show()
        {
            InitializeComponent();
        }
        public Show(int t) : this()
        {

            
            var temp = SQLLab.GetExamination_Laboratories_ID(t);
            textBox6.Text = temp.First().Table2.Type.ToString();
            textBox4.Text = temp.First().Table2.Exam_Code.ToString();
            textBox8.Text = temp.First().Table1.State.ToString();
            textBox5.Text = temp.First().Table1.Result.ToString();
            textBox9.Text = temp.First().Table1.Comments_Doctor.ToString();
            textBox7.Text = temp.First().Table1.Comments_Man_Lab.ToString();
            var temp2 = SQLLab.GetPacjentID(temp.First().Table1.Id_Appointment);
            var temp3 = SQLLab.GetPatientData(temp2.First().Id_Patient);
            textBox1.Text = temp3.First().Name.ToString();
            textBox2.Text = temp3.First().Surname.ToString();
            textBox3.Text = temp3.First().PESEL.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.Controls.Clear();
            this.Hide();
            this.Parent.Controls.Add(new Lab());
        }
    }
}

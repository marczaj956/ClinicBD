using System;

namespace MedicalClinic.Doctor
{
    partial class Doctor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.connector = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_wizyty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stan_wizyty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie_pacjenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko_pacjenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pesel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_wizyty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko_lekarza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1917, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 216);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(453, 35);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 7, 20, 46, 35, 244);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1732, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "Wyloguj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1184, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(86, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(264, 37);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            comboBox2.DataSource = Enum.GetValues(typeof(State));


            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(86, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stan";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(689, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Tylko moje wizyty";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(1354, 886);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pokaż";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(1542, 886);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Obsłuż";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // connector
            // 
            this.connector.Location = new System.Drawing.Point(489, 897);
            this.connector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connector.Name = "connector";
            this.connector.Size = new System.Drawing.Size(148, 26);
            this.connector.TabIndex = 8;
            this.connector.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(114, 809);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 154);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_wizyty,
            this.stan_wizyty,
            this.Imie_pacjenta,
            this.Nazwisko_pacjenta,
            this.Pesel,
            this.Data_wizyty,
            this.Nazwisko_lekarza});
            this.listView1.Location = new System.Drawing.Point(3, 331);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1917, 470);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID_wizyty
            // 
            this.ID_wizyty.Text = "Identyfikator wizyty";
            // 
            // stan_wizyty
            // 
            this.stan_wizyty.Text = "Stan";
            this.stan_wizyty.Width = 123;
            // 
            // Imie_pacjenta
            // 
            this.Imie_pacjenta.Text = "Imie";
            this.Imie_pacjenta.Width = 145;
            // 
            // Nazwisko_pacjenta
            // 
            this.Nazwisko_pacjenta.Text = "Nazwisko";
            this.Nazwisko_pacjenta.Width = 127;
            // 
            // Pesel
            // 
            this.Pesel.Text = "Pesel";
            this.Pesel.Width = 169;
            // 
            // Data_wizyty
            // 
            this.Data_wizyty.Text = "Data wizyty";
            this.Data_wizyty.Width = 144;
            // 
            // Nazwisko_lekarza
            // 
            this.Nazwisko_lekarza.Text = "Nazwisko lekarza";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connector);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(1920, 1000);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox connector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_wizyty;
        private System.Windows.Forms.ColumnHeader stan_wizyty;
        private System.Windows.Forms.ColumnHeader Imie_pacjenta;
        private System.Windows.Forms.ColumnHeader Nazwisko_pacjenta;
        private System.Windows.Forms.ColumnHeader Pesel;
        private System.Windows.Forms.ColumnHeader Data_wizyty;
        private System.Windows.Forms.ColumnHeader Nazwisko_lekarza;
    }
}

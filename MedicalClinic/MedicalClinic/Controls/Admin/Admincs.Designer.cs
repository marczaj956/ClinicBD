namespace MedicalClinic.Admin
{
    partial class Admincs
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
            this.SignOut = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Rola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerPracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.connector = new System.Windows.Forms.TextBox();
            this.Mainlist = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namelist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surnamelist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loginlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rolelist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SignOut);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.Role);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1280, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SignOut
            // 
            this.SignOut.Location = new System.Drawing.Point(1155, 16);
            this.SignOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(94, 31);
            this.SignOut.TabIndex = 9;
            this.SignOut.Text = "Wyloguj";
            this.SignOut.UseVisualStyleBackColor = true;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Search.Location = new System.Drawing.Point(819, 81);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(95, 32);
            this.Search.TabIndex = 8;
            this.Search.Text = "Szukaj";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Role
            // 
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "brak",
            "Rejestrator",
            "Lekarz",
            "Laborant",
            "Kierownik labolatorium",
            "Administrator"});
            this.Role.Location = new System.Drawing.Point(527, 81);
            this.Role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(192, 28);
            this.Role.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(450, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rola";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(527, 40);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(192, 26);
            this.Login.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(450, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Surname.Location = new System.Drawing.Point(151, 81);
            this.Surname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(192, 26);
            this.Surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name.Location = new System.Drawing.Point(151, 40);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(192, 26);
            this.Name.TabIndex = 1;
            this.Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add.Location = new System.Drawing.Point(863, 579);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 32);
            this.Add.TabIndex = 9;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit.Location = new System.Drawing.Point(999, 579);
            this.Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(95, 32);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edytuj";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Show.Location = new System.Drawing.Point(1129, 579);
            this.Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(95, 32);
            this.Show.TabIndex = 11;
            this.Show.Text = "Pokaż";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Rola
            // 
            this.Rola.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rola.HeaderText = "Rola";
            this.Rola.Name = "Rola";
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // Imie
            // 
            this.Imie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // NumerPracownika
            // 
            this.NumerPracownika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumerPracownika.HeaderText = "Numer pracownika";
            this.NumerPracownika.Name = "NumerPracownika";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumerPracownika,
            this.Imie,
            this.Nazwisko,
            this.Rola});
            this.dataGridView1.Location = new System.Drawing.Point(1043, 394);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(235, 138);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // WindowPanel
            // 
            this.WindowPanel.Location = new System.Drawing.Point(48, 521);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(200, 100);
            this.WindowPanel.TabIndex = 1;
            this.WindowPanel.Visible = false;
            // 
            // connector
            // 
            this.connector.Location = new System.Drawing.Point(420, 590);
            this.connector.Name = "connector";
            this.connector.Size = new System.Drawing.Size(100, 20);
            this.connector.TabIndex = 13;
            this.connector.Visible = false;
            this.connector.TextChanged += new System.EventHandler(this.connector_TextChanged_1);
            // 
            // Mainlist
            // 
            this.Mainlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Namelist,
            this.Surnamelist,
            this.Loginlist,
            this.Rolelist});
            this.Mainlist.HideSelection = false;
            this.Mainlist.Location = new System.Drawing.Point(67, 156);
            this.Mainlist.Name = "Mainlist";
            this.Mainlist.Size = new System.Drawing.Size(879, 376);
            this.Mainlist.TabIndex = 12;
            this.Mainlist.UseCompatibleStateImageBehavior = false;
            this.Mainlist.View = System.Windows.Forms.View.Details;
            this.Mainlist.SelectedIndexChanged += new System.EventHandler(this.Mainlist_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Numer Pracownika";
            this.Id.Width = 98;
            // 
            // Namelist
            // 
            this.Namelist.Text = "Imię";
            this.Namelist.Width = 178;
            // 
            // Surnamelist
            // 
            this.Surnamelist.Text = "Nazwisko";
            this.Surnamelist.Width = 167;
            // 
            // Loginlist
            // 
            this.Loginlist.Text = "Login";
            this.Loginlist.Width = 213;
            // 
            // Rolelist
            // 
            this.Rolelist.Text = "Rola";
            this.Rolelist.Width = 108;
            // 
            // Admincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mainlist);
            this.Controls.Add(this.connector);
            this.Controls.Add(this.WindowPanel);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
           // this.Name = "Admincs";
            this.Size = new System.Drawing.Size(1280, 650);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerPracownika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.TextBox connector;
        private System.Windows.Forms.ListView Mainlist;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Namelist;
        private System.Windows.Forms.ColumnHeader Surnamelist;
        private System.Windows.Forms.ColumnHeader Loginlist;
        private System.Windows.Forms.ColumnHeader Rolelist;
    }
}

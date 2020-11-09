using MedicalClinic.MainPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedicalClinic
{
    public partial class MainForm : Form
    {
        string role;
        
        public MainForm()
        {
            InitializeComponent();
            Init();
            
        }
        private void Init()
        {   
           // MPanel.Controls.Clear();            
            //MPanel.Controls.Add(new MainPanel.MainPanel());
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }


       

        public void ClearPanelControls()
        {
            //MPanel.Controls.Clear();
        }

        public void AddControlToPanel(Control c)
        {
            //MPanel.Controls.Add(c);
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {
           
        }
    }




}


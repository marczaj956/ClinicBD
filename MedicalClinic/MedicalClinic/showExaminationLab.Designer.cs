namespace MedicalClinic
{
    partial class showExaminationLab
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           // this.showLabExamination1 = new MedicalClinic.Controls.Doctor.ShowLabExamination();
            this.SuspendLayout();
            // 
            // showLabExamination1
            // 
            this.showLabExamination1.Location = new System.Drawing.Point(-2, 2);
            this.showLabExamination1.Margin = new System.Windows.Forms.Padding(2);
            this.showLabExamination1.Name = "showLabExamination1";
            this.showLabExamination1.Size = new System.Drawing.Size(1281, 650);
            this.showLabExamination1.TabIndex = 0;
            // 
            // showExaminationLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 666);
            this.Controls.Add(this.showLabExamination1);
            this.Name = "showExaminationLab";
            this.Text = "showExaminationLab";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Doctor.ShowLabExamination showLabExamination1;
    }
}
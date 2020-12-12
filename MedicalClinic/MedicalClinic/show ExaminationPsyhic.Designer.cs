namespace MedicalClinic
{
    partial class show_ExaminationPsyhic
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
            this.showPhysicalExamination1 = new MedicalClinic.Controls.Doctor.ShowPhysicalExamination();
            this.SuspendLayout();
            // 
            // showPhysicalExamination1
            // 
            this.showPhysicalExamination1.Location = new System.Drawing.Point(0, 5);
            this.showPhysicalExamination1.Margin = new System.Windows.Forms.Padding(2);
            this.showPhysicalExamination1.Name = "showPhysicalExamination1";
            this.showPhysicalExamination1.Size = new System.Drawing.Size(1280, 650);
            this.showPhysicalExamination1.TabIndex = 0;
            // 
            // show_ExaminationPsyhic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 476);
            this.Controls.Add(this.showPhysicalExamination1);
            this.Name = "show_ExaminationPsyhic";
            this.Text = "show_ExaminationPsyhic";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Doctor.ShowPhysicalExamination showPhysicalExamination1;
    }
}
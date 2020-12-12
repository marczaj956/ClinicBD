namespace MedicalClinic
{
    partial class ShowPhisicExamList
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
            this.physicalExamination1 = new MedicalClinic.Doctor.PhysicalExamination();
            this.SuspendLayout();
            // 
            // physicalExamination1
            // 
            this.physicalExamination1.Location = new System.Drawing.Point(-4, 2);
            this.physicalExamination1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physicalExamination1.Name = "physicalExamination1";
            this.physicalExamination1.Size = new System.Drawing.Size(1280, 650);
            this.physicalExamination1.TabIndex = 0;
            // 
            // ShowPhisicExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 666);
            this.Controls.Add(this.physicalExamination1);
            this.Name = "ShowPhisicExamList";
            this.Text = "ShowPhisicExamList";
            this.ResumeLayout(false);

        }

        #endregion

        private Doctor.PhysicalExamination physicalExamination1;
    }
}
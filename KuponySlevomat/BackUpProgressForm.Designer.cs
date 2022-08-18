
namespace KuponySlevomat
{
    partial class BackUpProgressForm
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
            this.pgBackUpDB = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgBackUpDB
            // 
            this.pgBackUpDB.Location = new System.Drawing.Point(46, 66);
            this.pgBackUpDB.Name = "pgBackUpDB";
            this.pgBackUpDB.Size = new System.Drawing.Size(557, 29);
            this.pgBackUpDB.Step = 1;
            this.pgBackUpDB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgBackUpDB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Záloha Databáze";
            // 
            // BackUpProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgBackUpDB);
            this.Name = "BackUpProgressForm";
            this.Text = "BackUpProgressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgBackUpDB;
        private System.Windows.Forms.Label label1;
    }
}
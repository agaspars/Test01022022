
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Gaspars1 = new System.Windows.Forms.Label();
            this.Gaspars2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gaspars1
            // 
            this.Gaspars1.AutoSize = true;
            this.Gaspars1.Location = new System.Drawing.Point(63, 64);
            this.Gaspars1.Name = "Gaspars1";
            this.Gaspars1.Size = new System.Drawing.Size(116, 17);
            this.Gaspars1.TabIndex = 0;
            this.Gaspars1.Text = "1 februaris 20:40";
            // 
            // Gaspars2
            // 
            this.Gaspars2.AutoSize = true;
            this.Gaspars2.Location = new System.Drawing.Point(109, 150);
            this.Gaspars2.Name = "Gaspars2";
            this.Gaspars2.Size = new System.Drawing.Size(138, 17);
            this.Gaspars2.TabIndex = 1;
            this.Gaspars2.Text = "change No.1 - 20:45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 423);
            this.Controls.Add(this.Gaspars2);
            this.Controls.Add(this.Gaspars1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gaspars1;
        private System.Windows.Forms.Label Gaspars2;
    }
}


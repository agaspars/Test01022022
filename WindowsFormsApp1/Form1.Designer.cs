
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
            this.Roliks1 = new System.Windows.Forms.Label();
            this.Gaspars2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Roliks1
            // 
            this.Roliks1.AutoSize = true;
            this.Roliks1.Location = new System.Drawing.Point(47, 52);
            this.Roliks1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Roliks1.Name = "Roliks1";
            this.Roliks1.Size = new System.Drawing.Size(86, 13);
            this.Roliks1.TabIndex = 0;
            this.Roliks1.Text = "1 februaris 20:40";
            this.Roliks1.Click += new System.EventHandler(this.Gaspars1_Click);
            // 
            // Gaspars2
            // 
            this.Gaspars2.AutoSize = true;
            this.Gaspars2.Location = new System.Drawing.Point(47, 230);
            this.Gaspars2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gaspars2.Name = "Gaspars2";
            this.Gaspars2.Size = new System.Drawing.Size(105, 13);
            this.Gaspars2.TabIndex = 1;
            this.Gaspars2.Text = "change No.1 - 20:45";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "testststs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "change No.1 - 20:45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gaspars2);
            this.Controls.Add(this.Roliks1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Roliks1;
        private System.Windows.Forms.Label Gaspars2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


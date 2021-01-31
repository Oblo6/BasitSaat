namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.grpSaat = new System.Windows.Forms.GroupBox();
            this.grpSaniye = new System.Windows.Forms.GroupBox();
            this.grpDakika = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpSaat
            // 
            this.grpSaat.Location = new System.Drawing.Point(12, 12);
            this.grpSaat.Name = "grpSaat";
            this.grpSaat.Size = new System.Drawing.Size(642, 75);
            this.grpSaat.TabIndex = 0;
            this.grpSaat.TabStop = false;
            this.grpSaat.Text = "Saat";
            this.grpSaat.Enter += new System.EventHandler(this.grpSaat_Enter);
            // 
            // grpSaniye
            // 
            this.grpSaniye.Location = new System.Drawing.Point(12, 267);
            this.grpSaniye.Name = "grpSaniye";
            this.grpSaniye.Size = new System.Drawing.Size(642, 168);
            this.grpSaniye.TabIndex = 0;
            this.grpSaniye.TabStop = false;
            this.grpSaniye.Text = "Saniye";
            // 
            // grpDakika
            // 
            this.grpDakika.Location = new System.Drawing.Point(12, 93);
            this.grpDakika.Name = "grpDakika";
            this.grpDakika.Size = new System.Drawing.Size(642, 168);
            this.grpDakika.TabIndex = 0;
            this.grpDakika.TabStop = false;
            this.grpDakika.Text = "Dakika";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(120, 457);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 13);
            this.lblSaat.TabIndex = 1;
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Location = new System.Drawing.Point(231, 457);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(0, 13);
            this.lblDakika.TabIndex = 2;
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Location = new System.Drawing.Point(404, 457);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(0, 13);
            this.lblSaniye.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 493);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.grpSaniye);
            this.Controls.Add(this.grpDakika);
            this.Controls.Add(this.grpSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSaat;
        private System.Windows.Forms.GroupBox grpSaniye;
        private System.Windows.Forms.GroupBox grpDakika;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
    }
}



namespace ContactTracingForm
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.lbtemp = new System.Windows.Forms.Label();
            this.tbtemp = new System.Windows.Forms.TextBox();
            this.lbage = new System.Windows.Forms.Label();
            this.tbage = new System.Windows.Forms.TextBox();
            this.btsub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(12, 38);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(258, 20);
            this.tbname.TabIndex = 0;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(9, 22);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(135, 13);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name (First, Middle I., Last)";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(9, 61);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(189, 13);
            this.lbaddress.TabIndex = 2;
            this.lbaddress.Text = "Address, In Words (Barangay and City)";
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(12, 77);
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(258, 20);
            this.tbadd.TabIndex = 3;
            // 
            // lbtemp
            // 
            this.lbtemp.AutoSize = true;
            this.lbtemp.Location = new System.Drawing.Point(9, 100);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(67, 13);
            this.lbtemp.TabIndex = 4;
            this.lbtemp.Text = "Temperature";
            // 
            // tbtemp
            // 
            this.tbtemp.Location = new System.Drawing.Point(12, 116);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.Size = new System.Drawing.Size(67, 20);
            this.tbtemp.TabIndex = 5;
            // 
            // lbage
            // 
            this.lbage.AutoSize = true;
            this.lbage.Location = new System.Drawing.Point(85, 100);
            this.lbage.Name = "lbage";
            this.lbage.Size = new System.Drawing.Size(26, 13);
            this.lbage.TabIndex = 6;
            this.lbage.Text = "Age";
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(88, 116);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(67, 20);
            this.tbage.TabIndex = 7;
            // 
            // btsub
            // 
            this.btsub.Location = new System.Drawing.Point(195, 113);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(75, 23);
            this.btsub.TabIndex = 8;
            this.btsub.Text = "&Submit";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.btsub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(317, 195);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.lbage);
            this.Controls.Add(this.tbtemp);
            this.Controls.Add(this.lbtemp);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.tbname);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.Label lbage;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.Button btsub;
    }
}


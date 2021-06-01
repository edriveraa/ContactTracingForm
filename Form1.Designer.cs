
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegionBox1 = new System.Windows.Forms.ComboBox();
            this.ProvinceBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(258, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name (First, Middle I., Last)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // RegionBox1
            // 
            this.RegionBox1.FormattingEnabled = true;
            this.RegionBox1.Items.AddRange(new object[] {
            "NCR",
            "CAR",
            "Region 1",
            "Region 2",
            "Region 3",
            "Region 4A",
            "Region 4B",
            "Region 5",
            "Region 6",
            "Region 7",
            "Region 8",
            "Region 9",
            "Region 10",
            "Region 11",
            "Region 12",
            "Region 13",
            "BARMM"});
            this.RegionBox1.Location = new System.Drawing.Point(12, 77);
            this.RegionBox1.Name = "RegionBox1";
            this.RegionBox1.Size = new System.Drawing.Size(82, 21);
            this.RegionBox1.TabIndex = 3;
            this.RegionBox1.Text = "Region";
            // 
            // ProvinceBox1
            // 
            this.ProvinceBox1.DisplayMember = "RegionBox1";
            this.ProvinceBox1.FormattingEnabled = true;
            this.ProvinceBox1.Items.AddRange(new object[] {
            "NCR",
            "CAR",
            "Region 1",
            "Region 2",
            "Region 3",
            "Region 4A",
            "Region 4B",
            "Region 5",
            "Region 6",
            "Region 7",
            "Region 8",
            "Region 9",
            "Region 10",
            "Region 11",
            "Region 12",
            "Region 13",
            "BARMM"});
            this.ProvinceBox1.Location = new System.Drawing.Point(100, 77);
            this.ProvinceBox1.Name = "ProvinceBox1";
            this.ProvinceBox1.Size = new System.Drawing.Size(82, 21);
            this.ProvinceBox1.TabIndex = 4;
            this.ProvinceBox1.Text = "Province";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 304);
            this.Controls.Add(this.ProvinceBox1);
            this.Controls.Add(this.RegionBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RegionBox1;
        private System.Windows.Forms.ComboBox ProvinceBox1;
    }
}


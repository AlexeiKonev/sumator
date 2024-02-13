namespace sumator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCombine = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinesPerFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // btnCombine
            this.btnCombine.Location = new System.Drawing.Point(35, 30);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(120, 40);
            this.btnCombine.Text = "Combine Files";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);

            // btnSplit
            this.btnSplit.Location = new System.Drawing.Point(35, 90);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(120, 40);
            this.btnSplit.Text = "Split File";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.Text = "Lines Per File:";

            // txtLinesPerFile
            this.txtLinesPerFile.Location = new System.Drawing.Point(155, 160);
            this.txtLinesPerFile.Name = "txtLinesPerFile";
            this.txtLinesPerFile.Size = new System.Drawing.Size(60, 26);
            this.txtLinesPerFile.Text = "1000";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLinesPerFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Manipulation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinesPerFile;
    }
}


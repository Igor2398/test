namespace PPLPApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTheor = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przyjmowana wielkość głebokości: ";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(210, 12);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(496, 23);
            this.txtDepth.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(653, 267);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Dalej";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTheor
            // 
            this.lblTheor.AutoSize = true;
            this.lblTheor.Location = new System.Drawing.Point(12, 72);
            this.lblTheor.Name = "lblTheor";
            this.lblTheor.Size = new System.Drawing.Size(319, 15);
            this.lblTheor.TabIndex = 3;
            this.lblTheor.Text = "Srednica kapieli na poziomie progu obliczona teoretycznie: ";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(12, 108);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(319, 15);
            this.lblEmp.TabIndex = 4;
            this.lblEmp.Text = "Srednica kapieli na poziomie progu obliczona empirycznie: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 302);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblTheor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDepth;
        private Button btnNext;
        private Label lblTheor;
        private Label lblEmp;
    }
}
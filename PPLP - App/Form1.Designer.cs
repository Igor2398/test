namespace PPLPApp
{
    partial class ArcFurnanceDesign
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.execButton = new System.Windows.Forms.Button();
            this.steelMass = new System.Windows.Forms.TextBox();
            this.additionalVol = new System.Windows.Forms.TextBox();
            this.slagToSteelParticipation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tiltAngle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.diamToDepthRatio = new System.Windows.Forms.TextBox();
            this.theorMetalBath = new System.Windows.Forms.Label();
            this.empMetalBath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj masę ciekłej stali: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj kąt nachylenia częsci stozklowej alfa (40-50):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Podaj udział dodatkowej objetosci (0.05 - 0.15):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podaj udział zuzla w stosunku do masy stali:";
            // 
            // execButton
            // 
            this.execButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.execButton.Location = new System.Drawing.Point(215, 176);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(164, 46);
            this.execButton.TabIndex = 4;
            this.execButton.Text = "Oblicz";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // steelMass
            // 
            this.steelMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.steelMass.Location = new System.Drawing.Point(291, 6);
            this.steelMass.Name = "steelMass";
            this.steelMass.Size = new System.Drawing.Size(234, 23);
            this.steelMass.TabIndex = 5;
            // 
            // additionalVol
            // 
            this.additionalVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalVol.Location = new System.Drawing.Point(291, 67);
            this.additionalVol.Name = "additionalVol";
            this.additionalVol.Size = new System.Drawing.Size(234, 23);
            this.additionalVol.TabIndex = 8;
            // 
            // slagToSteelParticipation
            // 
            this.slagToSteelParticipation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slagToSteelParticipation.Location = new System.Drawing.Point(291, 38);
            this.slagToSteelParticipation.Name = "slagToSteelParticipation";
            this.slagToSteelParticipation.Size = new System.Drawing.Size(234, 23);
            this.slagToSteelParticipation.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "[Mg]";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "[%]";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "[%]";
            // 
            // tiltAngle
            // 
            this.tiltAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiltAngle.Location = new System.Drawing.Point(291, 96);
            this.tiltAngle.Name = "tiltAngle";
            this.tiltAngle.Size = new System.Drawing.Size(234, 23);
            this.tiltAngle.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Podaj stosunek średnicy do głębokości (4-7):";
            // 
            // diamToDepthRatio
            // 
            this.diamToDepthRatio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diamToDepthRatio.Location = new System.Drawing.Point(291, 125);
            this.diamToDepthRatio.Name = "diamToDepthRatio";
            this.diamToDepthRatio.Size = new System.Drawing.Size(234, 23);
            this.diamToDepthRatio.TabIndex = 13;
            // 
            // theorMetalBath
            // 
            this.theorMetalBath.AutoSize = true;
            this.theorMetalBath.Location = new System.Drawing.Point(12, 261);
            this.theorMetalBath.Name = "theorMetalBath";
            this.theorMetalBath.Size = new System.Drawing.Size(287, 15);
            this.theorMetalBath.TabIndex = 14;
            this.theorMetalBath.Text = "Głębokość kąpieli metalowej obliczona teoretycznie:  ";
            this.theorMetalBath.Visible = false;
            // 
            // empMetalBath
            // 
            this.empMetalBath.AutoSize = true;
            this.empMetalBath.Location = new System.Drawing.Point(12, 286);
            this.empMetalBath.Name = "empMetalBath";
            this.empMetalBath.Size = new System.Drawing.Size(287, 15);
            this.empMetalBath.TabIndex = 15;
            this.empMetalBath.Text = "Głębokość kąpieli metalowej obliczona empirycznie:  ";
            this.empMetalBath.Visible = false;
            // 
            // ArcFurnanceDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 328);
            this.Controls.Add(this.empMetalBath);
            this.Controls.Add(this.theorMetalBath);
            this.Controls.Add(this.diamToDepthRatio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tiltAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.slagToSteelParticipation);
            this.Controls.Add(this.additionalVol);
            this.Controls.Add(this.steelMass);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArcFurnanceDesign";
            this.Text = "ArcFurnance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button execButton;
        private TextBox steelMass;
        private TextBox additionalVol;
        private TextBox slagToSteelParticipation;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tiltAngle;
        private Label label8;
        private TextBox diamToDepthRatio;
        private Label theorMetalBath;
        private Label empMetalBath;
    }
}
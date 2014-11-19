namespace EliteDangerousCrosshair2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelGameStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.linkUpdateLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLineThickness = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGameStatus
            // 
            this.labelGameStatus.AutoSize = true;
            this.labelGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameStatus.Location = new System.Drawing.Point(232, 9);
            this.labelGameStatus.Name = "labelGameStatus";
            this.labelGameStatus.Size = new System.Drawing.Size(102, 13);
            this.labelGameStatus.TabIndex = 0;
            this.labelGameStatus.Text = "Game Not Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Status:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 62);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(321, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reticle Size : 50px";
            // 
            // linkUpdateLabel
            // 
            this.linkUpdateLabel.AutoSize = true;
            this.linkUpdateLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkUpdateLabel.Location = new System.Drawing.Point(33, 169);
            this.linkUpdateLabel.Name = "linkUpdateLabel";
            this.linkUpdateLabel.Size = new System.Drawing.Size(265, 13);
            this.linkUpdateLabel.TabIndex = 4;
            this.linkUpdateLabel.TabStop = true;
            this.linkUpdateLabel.Text = "Click here to check for updates at RobCubed\'s Github!";
            this.linkUpdateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdateLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CTRL+SHIFT+F1 will enable and disable the crosshairs in game.";
            // 
            // comboBoxLineThickness
            // 
            this.comboBoxLineThickness.FormattingEnabled = true;
            this.comboBoxLineThickness.Location = new System.Drawing.Point(282, 101);
            this.comboBoxLineThickness.Name = "comboBoxLineThickness";
            this.comboBoxLineThickness.Size = new System.Drawing.Size(43, 21);
            this.comboBoxLineThickness.TabIndex = 7;
            this.comboBoxLineThickness.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineThickness_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Line Thickness:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 194);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLineThickness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkUpdateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGameStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EliteDangerousCrosshair v1.1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkUpdateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLineThickness;
        private System.Windows.Forms.Label label4;

    }
}


using System.Drawing;

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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOpacity = new System.Windows.Forms.ComboBox();
            this.checkBoxNubs = new System.Windows.Forms.CheckBox();
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
            this.trackBar1.Value = ((int)Properties.Settings.Default["ReticleSizeIndex"]) / 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reticle Size : " + Properties.Settings.Default["ReticleSizeIndex"] + "px";
            // 
            // linkUpdateLabel
            // 
            this.linkUpdateLabel.AutoSize = true;
            this.linkUpdateLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkUpdateLabel.Location = new System.Drawing.Point(33, 191);
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
            this.label3.Location = new System.Drawing.Point(17, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CTRL+SHIFT+F1 will enable and disable the crosshairs in game.";
            // 
            // comboBoxLineThickness
            // 
            this.comboBoxLineThickness.FormattingEnabled = true;
            this.comboBoxLineThickness.Location = new System.Drawing.Point(268, 101);
            this.comboBoxLineThickness.Name = "comboBoxLineThickness";
            this.comboBoxLineThickness.Size = new System.Drawing.Size(57, 21);
            this.comboBoxLineThickness.TabIndex = 7;
            this.comboBoxLineThickness.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineThickness_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Line Thickness:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = (Color) Properties.Settings.Default["ReticleColor"];
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(87, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 10);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Opacity:";
            // 
            // comboBoxOpacity
            // 
            this.comboBoxOpacity.FormattingEnabled = true;
            this.comboBoxOpacity.Location = new System.Drawing.Point(268, 132);
            this.comboBoxOpacity.Name = "comboBoxOpacity";
            this.comboBoxOpacity.Size = new System.Drawing.Size(57, 21);
            this.comboBoxOpacity.TabIndex = 12;
            this.comboBoxOpacity.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpacity_SelectedIndexChanged);
            // 
            // checkBoxNubs
            // 
            this.checkBoxNubs.AutoSize = true;
            this.checkBoxNubs.Location = new System.Drawing.Point(20, 135);
            this.checkBoxNubs.Name = "checkBoxNubs";
            this.checkBoxNubs.Size = new System.Drawing.Size(51, 17);
            this.checkBoxNubs.TabIndex = 13;
            this.checkBoxNubs.Text = "Nubs";
            this.checkBoxNubs.UseVisualStyleBackColor = true;
            this.checkBoxNubs.Checked = (bool) Properties.Settings.Default["NubsActivated"];
            this.checkBoxNubs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 215);
            this.Controls.Add(this.checkBoxNubs);
            this.Controls.Add(this.comboBoxOpacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
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
            this.Text = "EliteDangerousCrosshair v1.2";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOpacity;
        private System.Windows.Forms.CheckBox checkBoxNubs;

    }
}


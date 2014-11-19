namespace EliteDangerousCrosshair2
{
    partial class InvisibleForm
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
            this.bufferedPanel1 = new EliteDangerousCrosshair2.BufferedPanel();
            this.SuspendLayout();
            // 
            // bufferedPanel1
            // 
            this.bufferedPanel1.Activate = false;
            this.bufferedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferedPanel1.AutoSize = true;
            this.bufferedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bufferedPanel1.CircleDim = 50;
            this.bufferedPanel1.Location = new System.Drawing.Point(0, 0);
            this.bufferedPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bufferedPanel1.Name = "bufferedPanel1";
            this.bufferedPanel1.ProgramFocus = false;
            this.bufferedPanel1.Size = new System.Drawing.Size(827, 579);
            this.bufferedPanel1.TabIndex = 0;
            this.bufferedPanel1.XDraw = 0;
            this.bufferedPanel1.XScreen = 0;
            this.bufferedPanel1.YDraw = 0;
            this.bufferedPanel1.YScreen = 0;
            // 
            // InvisibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(859, 601);
            this.Controls.Add(this.bufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvisibleForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "InvisibleForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BufferedPanel bufferedPanel1;


    }
}
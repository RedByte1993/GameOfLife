namespace GameOfLife
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.BtnNext);
            this.groupBox1.Controls.Add(this.BtnPause);
            this.groupBox1.Controls.Add(this.BtnRandom);
            this.groupBox1.Controls.Add(this.BtnLoad);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 602);
            this.groupBox1.MaximumSize = new System.Drawing.Size(600, 150);
            this.groupBox1.MinimumSize = new System.Drawing.Size(600, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(6, 25);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(89, 33);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(600, 600);
            this.panel1.MinimumSize = new System.Drawing.Size(600, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 1;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(6, 64);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(89, 33);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnRandom
            // 
            this.BtnRandom.Location = new System.Drawing.Point(505, 111);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(89, 33);
            this.BtnRandom.TabIndex = 3;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(410, 111);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(89, 33);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(101, 64);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(89, 33);
            this.BtnPause.TabIndex = 4;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(101, 25);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(89, 33);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(622, 808);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(622, 808);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Game Of Life";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnLoad;
    }
}


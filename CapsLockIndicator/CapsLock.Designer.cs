namespace CapsLockIndicator
{
    partial class CapsLock
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
            this.l_C = new System.Windows.Forms.Label();
            this.l_C_Status = new System.Windows.Forms.Label();
            this.trayIndicator = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showBaloonTipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_C
            // 
            this.l_C.AutoSize = true;
            this.l_C.Location = new System.Drawing.Point(50, 50);
            this.l_C.Name = "l_C";
            this.l_C.Size = new System.Drawing.Size(91, 13);
            this.l_C.TabIndex = 1;
            this.l_C.Text = "Caps Lock Status";
            // 
            // l_C_Status
            // 
            this.l_C_Status.AutoSize = true;
            this.l_C_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_C_Status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_C_Status.Location = new System.Drawing.Point(165, 50);
            this.l_C_Status.Name = "l_C_Status";
            this.l_C_Status.Size = new System.Drawing.Size(0, 13);
            this.l_C_Status.TabIndex = 2;
            // 
            // trayIndicator
            // 
            this.trayIndicator.ContextMenuStrip = this.contextMenuStrip1;
            this.trayIndicator.Visible = true;
            this.trayIndicator.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBaloonTipToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 70);
            // 
            // showBaloonTipToolStripMenuItem
            // 
            this.showBaloonTipToolStripMenuItem.CheckOnClick = true;
            this.showBaloonTipToolStripMenuItem.Name = "showBaloonTipToolStripMenuItem";
            this.showBaloonTipToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showBaloonTipToolStripMenuItem.Text = "Show Baloon Tip";
            this.showBaloonTipToolStripMenuItem.Click += new System.EventHandler(this.showBaloonTipToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // CapsLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.l_C_Status);
            this.Controls.Add(this.l_C);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 150);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "CapsLock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Caps Lock Status";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_C;
        private System.Windows.Forms.Label l_C_Status;
        private System.Windows.Forms.NotifyIcon trayIndicator;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBaloonTipToolStripMenuItem;
    }
}


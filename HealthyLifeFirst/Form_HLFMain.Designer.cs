namespace HealthyLifeFirst
{
    partial class Form_HLFMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HLFMain));
            this.menu_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_Main = new System.Windows.Forms.StatusStrip();
            this.lbl_Status_Main = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchDataMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Main.SuspendLayout();
            this.status_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Main
            // 
            this.menu_Main.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menu_Main.Location = new System.Drawing.Point(0, 0);
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Size = new System.Drawing.Size(1184, 25);
            this.menu_Main.TabIndex = 1;
            this.menu_Main.Text = "menu_Main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.fileToolStripMenuItem.Text = "Operations";
            // 
            // status_Main
            // 
            this.status_Main.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.status_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status_Main});
            this.status_Main.Location = new System.Drawing.Point(0, 739);
            this.status_Main.Name = "status_Main";
            this.status_Main.Size = new System.Drawing.Size(1184, 22);
            this.status_Main.TabIndex = 2;
            this.status_Main.Text = "status_Main";
            // 
            // lbl_Status_Main
            // 
            this.lbl_Status_Main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status_Main.Name = "lbl_Status_Main";
            this.lbl_Status_Main.Size = new System.Drawing.Size(41, 17);
            this.lbl_Status_Main.Text = "Status:";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchDataMonitorToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // launchDataMonitorToolStripMenuItem
            // 
            this.launchDataMonitorToolStripMenuItem.Name = "launchDataMonitorToolStripMenuItem";
            this.launchDataMonitorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.launchDataMonitorToolStripMenuItem.Text = "Launch DataMonitor";
            this.launchDataMonitorToolStripMenuItem.Click += new System.EventHandler(this.launchDataMonitorToolStripMenuItem_Click);
            // 
            // Form_HLFMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(512, 512);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.status_Main);
            this.Controls.Add(this.menu_Main);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_HLFMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Healthy Life First";
            this.menu_Main.ResumeLayout(false);
            this.menu_Main.PerformLayout();
            this.status_Main.ResumeLayout(false);
            this.status_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status_Main;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status_Main;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchDataMonitorToolStripMenuItem;
    }
}


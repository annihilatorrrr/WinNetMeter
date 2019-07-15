﻿namespace WinNetMeter.Shell
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictDownload = new System.Windows.Forms.PictureBox();
            this.pictUpload = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblDownload = new WinNetMeter.Shell.MyLabel();
            this.LblUpload = new WinNetMeter.Shell.MyLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpload)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictDownload
            // 
            this.pictDownload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictDownload.Image = global::WinNetMeter.Shell.Properties.Resources.down_white_16px;
            this.pictDownload.Location = new System.Drawing.Point(3, 16);
            this.pictDownload.Name = "pictDownload";
            this.pictDownload.Size = new System.Drawing.Size(12, 15);
            this.pictDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictDownload.TabIndex = 2;
            this.pictDownload.TabStop = false;
            // 
            // pictUpload
            // 
            this.pictUpload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictUpload.Image = global::WinNetMeter.Shell.Properties.Resources.up_white_16px;
            this.pictUpload.Location = new System.Drawing.Point(3, 4);
            this.pictUpload.Name = "pictUpload";
            this.pictUpload.Size = new System.Drawing.Size(12, 15);
            this.pictUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictUpload.TabIndex = 3;
            this.pictUpload.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LblDownload
            // 
            this.LblDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblDownload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDownload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDownload.Location = new System.Drawing.Point(30, 16);
            this.LblDownload.Name = "LblDownload";
            this.LblDownload.Size = new System.Drawing.Size(68, 12);
            this.LblDownload.TabIndex = 6;
            this.LblDownload.Text = "......";
            this.LblDownload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblDownload.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // LblUpload
            // 
            this.LblUpload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblUpload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblUpload.Location = new System.Drawing.Point(30, 3);
            this.LblUpload.Name = "LblUpload";
            this.LblUpload.Size = new System.Drawing.Size(68, 12);
            this.LblUpload.TabIndex = 5;
            this.LblUpload.Text = "......";
            this.LblUpload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblUpload.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.monitoringToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationToolStripMenuItem_Click);
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.OnToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.OffToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.LblDownload);
            this.Controls.Add(this.LblUpload);
            this.Controls.Add(this.pictUpload);
            this.Controls.Add(this.pictDownload);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(101, 38);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpload)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictDownload;
        private System.Windows.Forms.PictureBox pictUpload;
        private System.Windows.Forms.Timer timer1;
        private MyLabel LblUpload;
        private MyLabel LblDownload;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

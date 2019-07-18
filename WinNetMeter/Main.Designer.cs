﻿namespace WinNetMeter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIntegrate = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnDatabase = new System.Windows.Forms.Button();
            this.BtnCustomization = new System.Windows.Forms.Button();
            this.BtnGeneral = new System.Windows.Forms.Button();
            this.PnlSelector = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.general = new WinNetMeter.UserControls.General();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.log = new WinNetMeter.UserControls.Log();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customize = new WinNetMeter.UserControls.Customize();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.integrationPage = new WinNetMeter.UserControls.IntegrationPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.about = new WinNetMeter.UserControls.About();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorSelector = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BtnIntegrate);
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.BtnDatabase);
            this.panel1.Controls.Add(this.BtnCustomization);
            this.panel1.Controls.Add(this.BtnGeneral);
            this.panel1.Controls.Add(this.PnlSelector);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 483);
            this.panel1.TabIndex = 0;
            // 
            // BtnIntegrate
            // 
            this.BtnIntegrate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIntegrate.FlatAppearance.BorderSize = 0;
            this.BtnIntegrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIntegrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIntegrate.Image = global::WinNetMeter.Properties.Resources.Chain_filled_16px;
            this.BtnIntegrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIntegrate.Location = new System.Drawing.Point(3, 237);
            this.BtnIntegrate.Name = "BtnIntegrate";
            this.BtnIntegrate.Size = new System.Drawing.Size(235, 46);
            this.BtnIntegrate.TabIndex = 7;
            this.BtnIntegrate.Text = "          Integration";
            this.BtnIntegrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIntegrate.UseVisualStyleBackColor = false;
            this.BtnIntegrate.Click += new System.EventHandler(this.BtnIntegrate_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Image = global::WinNetMeter.Properties.Resources.About_flat_16px;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Location = new System.Drawing.Point(3, 429);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(235, 46);
            this.BtnAbout.TabIndex = 6;
            this.BtnAbout.Text = "          About";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnDatabase
            // 
            this.BtnDatabase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDatabase.FlatAppearance.BorderSize = 0;
            this.BtnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDatabase.Image = global::WinNetMeter.Properties.Resources.Database_filled_16px;
            this.BtnDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDatabase.Location = new System.Drawing.Point(3, 185);
            this.BtnDatabase.Name = "BtnDatabase";
            this.BtnDatabase.Size = new System.Drawing.Size(235, 46);
            this.BtnDatabase.TabIndex = 4;
            this.BtnDatabase.Text = "          Database";
            this.BtnDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDatabase.UseVisualStyleBackColor = false;
            this.BtnDatabase.Click += new System.EventHandler(this.BtnDatabase_Click);
            // 
            // BtnCustomization
            // 
            this.BtnCustomization.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCustomization.FlatAppearance.BorderSize = 0;
            this.BtnCustomization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomization.Image = global::WinNetMeter.Properties.Resources.Brush_filled_16px;
            this.BtnCustomization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomization.Location = new System.Drawing.Point(3, 133);
            this.BtnCustomization.Name = "BtnCustomization";
            this.BtnCustomization.Size = new System.Drawing.Size(235, 46);
            this.BtnCustomization.TabIndex = 3;
            this.BtnCustomization.Text = "          Customization";
            this.BtnCustomization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomization.UseVisualStyleBackColor = false;
            this.BtnCustomization.Click += new System.EventHandler(this.BtnCustomization_Click);
            // 
            // BtnGeneral
            // 
            this.BtnGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGeneral.FlatAppearance.BorderSize = 0;
            this.BtnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeneral.Image = global::WinNetMeter.Properties.Resources.Settings_colored_16px;
            this.BtnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGeneral.Location = new System.Drawing.Point(3, 81);
            this.BtnGeneral.Name = "BtnGeneral";
            this.BtnGeneral.Size = new System.Drawing.Size(235, 46);
            this.BtnGeneral.TabIndex = 1;
            this.BtnGeneral.Text = "          General";
            this.BtnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGeneral.UseVisualStyleBackColor = false;
            this.BtnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
            // 
            // PnlSelector
            // 
            this.PnlSelector.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnlSelector.Location = new System.Drawing.Point(0, 81);
            this.PnlSelector.Name = "PnlSelector";
            this.PnlSelector.Size = new System.Drawing.Size(5, 46);
            this.PnlSelector.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Realtime Network Speed Monitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "WinNetMeter";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(236, 483);
            this.shapeContainer2.TabIndex = 5;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 11;
            this.lineShape3.X2 = 227;
            this.lineShape3.Y1 = 418;
            this.lineShape3.Y2 = 418;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(204, -5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 493);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.general);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // general
            // 
            this.general.BackColor = System.Drawing.Color.White;
            this.general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.general.Location = new System.Drawing.Point(3, 3);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(562, 479);
            this.general.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.log);
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(568, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.White;
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(568, 485);
            this.log.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customize);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customize";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customize
            // 
            this.customize.BackColor = System.Drawing.Color.White;
            this.customize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customize.Location = new System.Drawing.Point(3, 3);
            this.customize.Name = "customize";
            this.customize.Size = new System.Drawing.Size(562, 479);
            this.customize.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.integrationPage);
            this.tabPage4.Location = new System.Drawing.Point(23, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(568, 485);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Integration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // integrationPage
            // 
            this.integrationPage.BackColor = System.Drawing.Color.White;
            this.integrationPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.integrationPage.Location = new System.Drawing.Point(3, 3);
            this.integrationPage.Name = "integrationPage";
            this.integrationPage.Size = new System.Drawing.Size(562, 479);
            this.integrationPage.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.about);
            this.tabPage5.Location = new System.Drawing.Point(23, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(568, 485);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about.Location = new System.Drawing.Point(0, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(568, 485);
            this.about.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(794, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 522);
            this.MinimumSize = new System.Drawing.Size(810, 522);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinNetMeter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WinNetMeter.UserControls.IntegrationPage integrationPage;
        private WinNetMeter.UserControls.Customize customize;
        private WinNetMeter.UserControls.Log log;
        private WinNetMeter.UserControls.General general;
        private WinNetMeter.UserControls.About about;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGeneral;
        private System.Windows.Forms.Button BtnCustomization;
        private System.Windows.Forms.Button BtnDatabase;
        private System.Windows.Forms.Button BtnAbout;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorSelector;
        private System.Windows.Forms.Button BtnIntegrate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}


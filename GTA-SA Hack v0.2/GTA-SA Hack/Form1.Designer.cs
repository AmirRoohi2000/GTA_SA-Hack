﻿namespace GTA_SA_Hack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.godMode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // godMode
            // 
            this.godMode.AutoSize = true;
            this.godMode.BackColor = System.Drawing.Color.Transparent;
            this.godMode.ForeColor = System.Drawing.Color.Aqua;
            this.godMode.Location = new System.Drawing.Point(12, 41);
            this.godMode.Name = "godMode";
            this.godMode.Size = new System.Drawing.Size(105, 27);
            this.godMode.TabIndex = 0;
            this.godMode.Text = "God mode";
            this.godMode.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "GTA San Andreas Hack";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.BackColor = System.Drawing.Color.Transparent;
            this.Money.ForeColor = System.Drawing.Color.Aqua;
            this.Money.Location = new System.Drawing.Point(12, 74);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(129, 27);
            this.Money.TabIndex = 2;
            this.Money.Text = "unlim. Money";
            this.Money.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(269, 156);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.godMode);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTA-SA Hack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox godMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Money;
        private System.Windows.Forms.Timer timer1;
    }
}


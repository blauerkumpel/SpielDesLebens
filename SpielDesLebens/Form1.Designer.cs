﻿
namespace SpielDesLebens
{
    partial class SpielDesLebens
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
            this.components = new System.ComponentModel.Container();
            this.pnl_canvas = new System.Windows.Forms.Panel();
            this.lbl_schritt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Los = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.Location = new System.Drawing.Point(12, 12);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(1001, 1001);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_canvas_Paint_1);
            this.pnl_canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseClick);
            // 
            // lbl_schritt
            // 
            this.lbl_schritt.AutoSize = true;
            this.lbl_schritt.Location = new System.Drawing.Point(1019, 12);
            this.lbl_schritt.Name = "lbl_schritt";
            this.lbl_schritt.Size = new System.Drawing.Size(50, 15);
            this.lbl_schritt.TabIndex = 0;
            this.lbl_schritt.Text = "Schritte:";
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Los
            // 
            this.Los.Location = new System.Drawing.Point(1019, 30);
            this.Los.Name = "Los";
            this.Los.Size = new System.Drawing.Size(75, 23);
            this.Los.TabIndex = 0;
            this.Los.Text = "Los";
            this.Los.UseVisualStyleBackColor = true;
            this.Los.Click += new System.EventHandler(this.Los_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(1019, 59);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(1019, 88);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Start/Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // SpielDesLebens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 1038);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Los);
            this.Controls.Add(this.lbl_schritt);
            this.Controls.Add(this.pnl_canvas);
            this.Name = "SpielDesLebens";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_canvas;
        private System.Windows.Forms.Label lbl_schritt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Los;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Stop;
    }
}


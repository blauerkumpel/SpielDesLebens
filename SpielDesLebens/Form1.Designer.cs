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
            this.SuspendLayout();
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.Location = new System.Drawing.Point(12, 12);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(1035, 1033);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_canvas_Paint_1);
            // 
            // lbl_schritt
            // 
            this.lbl_schritt.AutoSize = true;
            this.lbl_schritt.Location = new System.Drawing.Point(12, 1048);
            this.lbl_schritt.Name = "lbl_schritt";
            this.lbl_schritt.Size = new System.Drawing.Size(50, 15);
            this.lbl_schritt.TabIndex = 0;
            this.lbl_schritt.Text = "Schritte:";
            // 
            // SpielDesLebens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 1071);
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
    }
}


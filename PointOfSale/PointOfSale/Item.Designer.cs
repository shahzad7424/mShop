﻿namespace PointOfSale
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.circularPictureBox1 = new PointOfSale.CircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(87, 79);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chesse Burger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(92, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "250/-";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularPictureBox1);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(204, 79);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

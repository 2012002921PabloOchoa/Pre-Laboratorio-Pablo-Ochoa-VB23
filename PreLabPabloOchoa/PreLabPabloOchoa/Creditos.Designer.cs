﻿namespace PreLabPabloOchoa
{
    partial class Creditos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            label1.Location = new Point(176, 98);
            label1.Name = "label1";
            label1.Size = new Size(119, 27);
            label1.TabIndex = 0;
            label1.Text = "CREDITOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            label2.Location = new Point(83, 164);
            label2.Name = "label2";
            label2.Size = new Size(325, 27);
            label2.TabIndex = 1;
            label2.Text = "PABLO GIOVANI OCHOA QUAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            label3.Location = new Point(137, 231);
            label3.Name = "label3";
            label3.Size = new Size(215, 27);
            label3.TabIndex = 2;
            label3.Text = "V Bachillerato B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            label4.Location = new Point(189, 296);
            label4.Name = "label4";
            label4.Size = new Size(106, 27);
            label4.TabIndex = 3;
            label4.Text = "Clave 23";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._494357856_1826821011499433_2514663380711497924_n;
            pictureBox1.Location = new Point(494, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold);
            label5.Location = new Point(189, 362);
            label5.Name = "label5";
            label5.Size = new Size(129, 27);
            label5.TabIndex = 5;
            label5.Text = "28/04/2025";
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Creditos";
            Text = "Creditos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
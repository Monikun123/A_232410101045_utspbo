﻿namespace A_232410101045_utspbo
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            Kontakbutton = new Button();
            label3 = new Label();
            label4 = new Label();
            Registerbutton = new Button();
            Loginbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 21);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Halaman Welcome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 188);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "Halaman Kontak";
            // 
            // Kontakbutton
            // 
            Kontakbutton.Location = new Point(135, 216);
            Kontakbutton.Name = "Kontakbutton";
            Kontakbutton.Size = new Size(112, 34);
            Kontakbutton.TabIndex = 2;
            Kontakbutton.Text = "Kontak";
            Kontakbutton.UseVisualStyleBackColor = true;
            Kontakbutton.Click += Kontakbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 188);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 3;
            label3.Text = "Halaman Register ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 185);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 4;
            label4.Text = "Halaman Login";
            // 
            // Registerbutton
            // 
            Registerbutton.Location = new Point(352, 216);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(112, 34);
            Registerbutton.TabIndex = 5;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = true;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.Location = new Point(626, 213);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(112, 34);
            Loginbutton.TabIndex = 6;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loginbutton);
            Controls.Add(Registerbutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Kontakbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Kontakbutton;
        private Label label3;
        private Label label4;
        private Button Registerbutton;
        private Button Loginbutton;
    }
}

namespace A_232410101045_utspbo
{
    partial class MenambahkanKontak
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
            namatextBox = new TextBox();
            emailtextBox = new TextBox();
            nohptextBox = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 77);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 146);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 214);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "nohp";
            // 
            // namatextBox
            // 
            namatextBox.Location = new Point(86, 104);
            namatextBox.Name = "namatextBox";
            namatextBox.Size = new Size(150, 31);
            namatextBox.TabIndex = 3;
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(78, 175);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(150, 31);
            emailtextBox.TabIndex = 4;
            // 
            // nohptextBox
            // 
            nohptextBox.Location = new Point(78, 242);
            nohptextBox.Name = "nohptextBox";
            nohptextBox.Size = new Size(150, 31);
            nohptextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 12);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 6;
            label4.Text = "Menambahkan Kontak Baru";
            // 
            // button1
            // 
            button1.Location = new Point(332, 336);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenambahkanKontak
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(nohptextBox);
            Controls.Add(emailtextBox);
            Controls.Add(namatextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenambahkanKontak";
            Text = "MenambahkanKontak";
            Load += MenambahkanKontak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox namatextBox;
        private TextBox emailtextBox;
        private TextBox nohptextBox;
        private Label label4;
        private Button button1;
    }
}
namespace A_232410101045_utspbo
{
    partial class Login
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
            UsernametextBox = new TextBox();
            PasswordtextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            masukbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 41);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Halaman Login";
            // 
            // UsernametextBox
            // 
            UsernametextBox.Location = new Point(176, 123);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(150, 31);
            UsernametextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(176, 201);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(150, 31);
            PasswordtextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 87);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 173);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // masukbutton
            // 
            masukbutton.Location = new Point(154, 359);
            masukbutton.Name = "masukbutton";
            masukbutton.Size = new Size(112, 34);
            masukbutton.TabIndex = 5;
            masukbutton.Text = "Masuk";
            masukbutton.UseVisualStyleBackColor = true;
            masukbutton.Click += masukbutton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(masukbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordtextBox);
            Controls.Add(UsernametextBox);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UsernametextBox;
        private TextBox PasswordtextBox;
        private Label label2;
        private Label label3;
        private Button masukbutton;
    }
}
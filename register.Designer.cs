namespace A_232410101045_utspbo
{
    partial class register
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
            usernametextBox = new TextBox();
            passwordtextBox = new TextBox();
            Addbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "Halaman Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 74);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 179);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // usernametextBox
            // 
            usernametextBox.Location = new Point(172, 113);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(150, 31);
            usernametextBox.TabIndex = 3;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(172, 221);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(150, 31);
            passwordtextBox.TabIndex = 4;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(163, 309);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(112, 34);
            Addbutton.TabIndex = 5;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Addbutton);
            Controls.Add(passwordtextBox);
            Controls.Add(usernametextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private Button Addbutton;
    }
}
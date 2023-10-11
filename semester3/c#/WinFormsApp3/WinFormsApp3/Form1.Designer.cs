namespace WinFormsApp3
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
            button1 = new Button();
            label2 = new Label();
            u_name = new TextBox();
            label3 = new Label();
            u_password = new TextBox();
            btnHS = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 58);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "First WinForm";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(172, 249);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 114);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // u_name
            // 
            u_name.Location = new Point(87, 132);
            u_name.Name = "u_name";
            u_name.Size = new Size(217, 23);
            u_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // u_password
            // 
            u_password.Location = new Point(87, 192);
            u_password.Name = "u_password";
            u_password.Size = new Size(138, 23);
            u_password.TabIndex = 5;
            u_password.UseSystemPasswordChar = true;
            // 
            // btnHS
            // 
            btnHS.Location = new Point(231, 192);
            btnHS.Name = "btnHS";
            btnHS.Size = new Size(73, 23);
            btnHS.TabIndex = 6;
            btnHS.Text = "show";
            btnHS.UseVisualStyleBackColor = true;
            btnHS.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 337);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 428);
            Controls.Add(label4);
            Controls.Add(btnHS);
            Controls.Add(u_password);
            Controls.Add(label3);
            Controls.Add(u_name);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox u_name;
        private Label label3;
        private TextBox u_password;
        private Button btnHS;
        private Label label4;
    }
}
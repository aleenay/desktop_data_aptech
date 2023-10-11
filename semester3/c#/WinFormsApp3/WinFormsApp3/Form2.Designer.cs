namespace WinFormsApp3
{
    partial class Form2
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
            u_name = new Label();
            u_pass = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // u_name
            // 
            u_name.AutoSize = true;
            u_name.Location = new Point(109, 131);
            u_name.Name = "u_name";
            u_name.Size = new Size(38, 15);
            u_name.TabIndex = 1;
            u_name.Text = "label2";
            // 
            // u_pass
            // 
            u_pass.AutoSize = true;
            u_pass.Location = new Point(110, 167);
            u_pass.Name = "u_pass";
            u_pass.Size = new Size(38, 15);
            u_pass.TabIndex = 2;
            u_pass.Text = "label3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 402);
            Controls.Add(u_pass);
            Controls.Add(u_name);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label u_name;
        private Label u_pass;
    }
}
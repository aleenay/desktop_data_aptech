namespace ListBox
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
            ItemListBox = new System.Windows.Forms.ListBox();
            label1 = new Label();
            txtItem = new TextBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // ItemListBox
            // 
            ItemListBox.BackColor = Color.BlanchedAlmond;
            ItemListBox.FormattingEnabled = true;
            ItemListBox.ItemHeight = 15;
            ItemListBox.Location = new Point(23, 77);
            ItemListBox.Name = "ItemListBox";
            ItemListBox.Size = new Size(165, 319);
            ItemListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(240, 46);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 1;
            label1.Text = "Add Item";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(240, 77);
            txtItem.Name = "txtItem";
            txtItem.PlaceholderText = "Enter Item";
            txtItem.Size = new Size(307, 23);
            txtItem.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(455, 42);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 3;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 50);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 4;
            label2.Text = "Item List";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(240, 116);
            button2.Name = "button2";
            button2.Size = new Size(307, 37);
            button2.TabIndex = 5;
            button2.Text = "Item count";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(240, 159);
            button3.Name = "button3";
            button3.Size = new Size(307, 35);
            button3.TabIndex = 6;
            button3.Text = "Item sort";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(240, 200);
            button4.Name = "button4";
            button4.Size = new Size(307, 39);
            button4.TabIndex = 7;
            button4.Text = "Remove Item";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(240, 245);
            button5.Name = "button5";
            button5.Size = new Size(307, 34);
            button5.TabIndex = 8;
            button5.Text = "Clear All";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(678, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtItem);
            Controls.Add(label1);
            Controls.Add(ItemListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ItemListBox;
        private Label label1;
        private TextBox txtItem;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
namespace listBox_2207B2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.add_items = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 199);
            this.listBox1.TabIndex = 0;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(196, 93);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(183, 20);
            this.itemname.TabIndex = 1;
            // 
            // add_items
            // 
            this.add_items.Location = new System.Drawing.Point(406, 93);
            this.add_items.Name = "add_items";
            this.add_items.Size = new System.Drawing.Size(75, 23);
            this.add_items.TabIndex = 2;
            this.add_items.Text = "add item";
            this.add_items.UseVisualStyleBackColor = true;
            this.add_items.Click += new System.EventHandler(this.add_items_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(196, 142);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(183, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Item count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(196, 184);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(183, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Item Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(196, 223);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Item Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 446);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.add_items);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Button add_items;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}


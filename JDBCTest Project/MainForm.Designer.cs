namespace Assign_07
{
    partial class MainForm
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
            lstProducts = new ListBox();
            btnAdd = new Button();
            btnModify = new Button();
            btnRemove = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.Font = new Font("Segoe UI", 8F);
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 17;
            lstProducts.Location = new Point(31, 58);
            lstProducts.Name = "lstProducts";
            lstProducts.RightToLeft = RightToLeft.No;
            lstProducts.Size = new Size(565, 276);
            lstProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 385);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(147, 385);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(110, 34);
            btnModify.TabIndex = 2;
            btnModify.Text = "&Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(263, 385);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(110, 34);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(486, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Product Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 23);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 23);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Version";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 23);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 8;
            label4.Text = "Release Date";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(653, 443);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnRemove);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(lstProducts);
            Name = "MainForm";
            Text = "Product Maintenance";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProducts;
        private Button btnAdd;
        private Button btnModify;
        private Button btnRemove;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

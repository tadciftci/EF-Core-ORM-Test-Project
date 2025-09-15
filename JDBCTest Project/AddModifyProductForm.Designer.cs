namespace Assign_07
{
    partial class AddModifyProductForm
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
            txtCode = new TextBox();
            txtName = new TextBox();
            txtVersion = new TextBox();
            txtReleaseDate = new TextBox();
            lblCode = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(143, 23);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(235, 27);
            txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(337, 27);
            txtName.TabIndex = 1;
            // 
            // txtVersion
            // 
            txtVersion.Location = new Point(143, 128);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(235, 27);
            txtVersion.TabIndex = 2;
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(143, 183);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(235, 27);
            txtReleaseDate.TabIndex = 3;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(14, 26);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(102, 20);
            lblCode.TabIndex = 4;
            lblCode.Text = "Product Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 76);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Version:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 186);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 7;
            label3.Text = "Release Date:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(143, 237);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 8;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(284, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 296);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCode);
            Controls.Add(txtReleaseDate);
            Controls.Add(txtVersion);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Name = "AddModifyProductForm";
            Text = "AddModifyProductForm";
            Load += AddModifyProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtVersion;
        private TextBox txtReleaseDate;
        private Label lblCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOK;
        private Button btnCancel;
    }
}
namespace WFApp
{
    partial class ProductEditForm
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
            this.chBoxIsLocked = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.EntryPrice = new System.Windows.Forms.TextBox();
            this.SellingPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chBoxIsLocked
            // 
            this.chBoxIsLocked.AutoSize = true;
            this.chBoxIsLocked.Location = new System.Drawing.Point(40, 211);
            this.chBoxIsLocked.Name = "chBoxIsLocked";
            this.chBoxIsLocked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chBoxIsLocked.Size = new System.Drawing.Size(69, 17);
            this.chBoxIsLocked.TabIndex = 0;
            this.chBoxIsLocked.Text = "Is locked";
            this.chBoxIsLocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBoxIsLocked.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(223, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product id";
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(107, 24);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(121, 20);
            this.ProductId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Entry price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selling price";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(107, 61);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(121, 20);
            this.ProductName.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(107, 102);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 10;
            // 
            // EntryPrice
            // 
            this.EntryPrice.Location = new System.Drawing.Point(107, 139);
            this.EntryPrice.Name = "EntryPrice";
            this.EntryPrice.Size = new System.Drawing.Size(121, 20);
            this.EntryPrice.TabIndex = 11;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Location = new System.Drawing.Point(107, 173);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(121, 20);
            this.SellingPrice.TabIndex = 12;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 281);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.EntryPrice);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chBoxIsLocked);
            this.Name = "ProductEditForm";
            this.Text = "ProductEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBoxIsLocked;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.TextBox EntryPrice;
        private System.Windows.Forms.TextBox SellingPrice;
    }
}
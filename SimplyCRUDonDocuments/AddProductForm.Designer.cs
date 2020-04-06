namespace SimplyCRUDonDocuments
{
    partial class AddProductForm
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
            this.NameProductLabel = new System.Windows.Forms.Label();
            this.NumberOfProductLabel = new System.Windows.Forms.Label();
            this.ProductNettoPriceLabel = new System.Windows.Forms.Label();
            this.ProductBruttoPriceLabel = new System.Windows.Forms.Label();
            this.NameProductTextBox = new System.Windows.Forms.TextBox();
            this.NumberProductTextBox = new System.Windows.Forms.TextBox();
            this.NettoPriceTextBox = new System.Windows.Forms.TextBox();
            this.BruttoPriceTextBox = new System.Windows.Forms.TextBox();
            this.AcceptProductButton = new System.Windows.Forms.Button();
            this.CancelProdcutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameProductLabel
            // 
            this.NameProductLabel.AutoSize = true;
            this.NameProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameProductLabel.Location = new System.Drawing.Point(88, 49);
            this.NameProductLabel.Name = "NameProductLabel";
            this.NameProductLabel.Size = new System.Drawing.Size(183, 25);
            this.NameProductLabel.TabIndex = 0;
            this.NameProductLabel.Text = "Nazwa Produktu";
            // 
            // NumberOfProductLabel
            // 
            this.NumberOfProductLabel.AutoSize = true;
            this.NumberOfProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfProductLabel.Location = new System.Drawing.Point(88, 150);
            this.NumberOfProductLabel.Name = "NumberOfProductLabel";
            this.NumberOfProductLabel.Size = new System.Drawing.Size(147, 25);
            this.NumberOfProductLabel.TabIndex = 1;
            this.NumberOfProductLabel.Text = "Liczba Sztuk";
            // 
            // ProductNettoPriceLabel
            // 
            this.ProductNettoPriceLabel.AutoSize = true;
            this.ProductNettoPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductNettoPriceLabel.Location = new System.Drawing.Point(88, 249);
            this.ProductNettoPriceLabel.Name = "ProductNettoPriceLabel";
            this.ProductNettoPriceLabel.Size = new System.Drawing.Size(235, 25);
            this.ProductNettoPriceLabel.TabIndex = 2;
            this.ProductNettoPriceLabel.Text = "Cena netto za sztukę";
            // 
            // ProductBruttoPriceLabel
            // 
            this.ProductBruttoPriceLabel.AutoSize = true;
            this.ProductBruttoPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductBruttoPriceLabel.Location = new System.Drawing.Point(88, 356);
            this.ProductBruttoPriceLabel.Name = "ProductBruttoPriceLabel";
            this.ProductBruttoPriceLabel.Size = new System.Drawing.Size(243, 25);
            this.ProductBruttoPriceLabel.TabIndex = 3;
            this.ProductBruttoPriceLabel.Text = "Cena brutto za sztukę";
            // 
            // NameProductTextBox
            // 
            this.NameProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameProductTextBox.Location = new System.Drawing.Point(93, 98);
            this.NameProductTextBox.Name = "NameProductTextBox";
            this.NameProductTextBox.Size = new System.Drawing.Size(230, 29);
            this.NameProductTextBox.TabIndex = 4;
            // 
            // NumberProductTextBox
            // 
            this.NumberProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberProductTextBox.Location = new System.Drawing.Point(93, 198);
            this.NumberProductTextBox.Name = "NumberProductTextBox";
            this.NumberProductTextBox.Size = new System.Drawing.Size(230, 29);
            this.NumberProductTextBox.TabIndex = 5;
            // 
            // NettoPriceTextBox
            // 
            this.NettoPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NettoPriceTextBox.Location = new System.Drawing.Point(93, 305);
            this.NettoPriceTextBox.Name = "NettoPriceTextBox";
            this.NettoPriceTextBox.Size = new System.Drawing.Size(230, 29);
            this.NettoPriceTextBox.TabIndex = 6;
            // 
            // BruttoPriceTextBox
            // 
            this.BruttoPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BruttoPriceTextBox.Location = new System.Drawing.Point(93, 405);
            this.BruttoPriceTextBox.Name = "BruttoPriceTextBox";
            this.BruttoPriceTextBox.Size = new System.Drawing.Size(230, 29);
            this.BruttoPriceTextBox.TabIndex = 7;
            // 
            // AcceptProductButton
            // 
            this.AcceptProductButton.BackColor = System.Drawing.Color.Lime;
            this.AcceptProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AcceptProductButton.Location = new System.Drawing.Point(245, 521);
            this.AcceptProductButton.Name = "AcceptProductButton";
            this.AcceptProductButton.Size = new System.Drawing.Size(117, 42);
            this.AcceptProductButton.TabIndex = 8;
            this.AcceptProductButton.Text = "Zatwierdź";
            this.AcceptProductButton.UseVisualStyleBackColor = false;
            this.AcceptProductButton.Click += new System.EventHandler(this.AcceptProductButton_Click);
            // 
            // CancelProdcutButton
            // 
            this.CancelProdcutButton.BackColor = System.Drawing.Color.Red;
            this.CancelProdcutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelProdcutButton.Location = new System.Drawing.Point(53, 521);
            this.CancelProdcutButton.Name = "CancelProdcutButton";
            this.CancelProdcutButton.Size = new System.Drawing.Size(117, 42);
            this.CancelProdcutButton.TabIndex = 9;
            this.CancelProdcutButton.Text = "Anuluj";
            this.CancelProdcutButton.UseVisualStyleBackColor = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(406, 590);
            this.Controls.Add(this.CancelProdcutButton);
            this.Controls.Add(this.AcceptProductButton);
            this.Controls.Add(this.BruttoPriceTextBox);
            this.Controls.Add(this.NettoPriceTextBox);
            this.Controls.Add(this.NumberProductTextBox);
            this.Controls.Add(this.NameProductTextBox);
            this.Controls.Add(this.ProductBruttoPriceLabel);
            this.Controls.Add(this.ProductNettoPriceLabel);
            this.Controls.Add(this.NumberOfProductLabel);
            this.Controls.Add(this.NameProductLabel);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameProductLabel;
        private System.Windows.Forms.Label NumberOfProductLabel;
        private System.Windows.Forms.Label ProductNettoPriceLabel;
        private System.Windows.Forms.Label ProductBruttoPriceLabel;
        private System.Windows.Forms.TextBox NameProductTextBox;
        private System.Windows.Forms.TextBox NumberProductTextBox;
        private System.Windows.Forms.TextBox NettoPriceTextBox;
        private System.Windows.Forms.TextBox BruttoPriceTextBox;
        private System.Windows.Forms.Button AcceptProductButton;
        private System.Windows.Forms.Button CancelProdcutButton;
    }
}
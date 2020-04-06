namespace SimplyCRUDonDocuments
{
    partial class UpdateDocumentForm
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
            this.HeaderEditButton = new System.Windows.Forms.Button();
            this.EditArticlesButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateIdKleintaTextBox = new System.Windows.Forms.TextBox();
            this.Updatenamelabel = new System.Windows.Forms.Label();
            this.UpdateIdKlientaLabel = new System.Windows.Forms.Label();
            this.UpdateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateDateLabel = new System.Windows.Forms.Label();
            this.UpdateProductDateGrid = new System.Windows.Forms.DataGridView();
            this.UpdateProductNameLabel = new System.Windows.Forms.Label();
            this.UpdateLiczbaSztukProduktuLabel = new System.Windows.Forms.Label();
            this.UpdateProductNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateLiczbaSztukTextBox = new System.Windows.Forms.TextBox();
            this.UpdateCenaNettoProduktuLabel = new System.Windows.Forms.Label();
            this.UpdateCenaBruttoProduktuLabel = new System.Windows.Forms.Label();
            this.UpdateCenaNettoProduktuTextBox = new System.Windows.Forms.TextBox();
            this.UpdateCenaBruttoProduktuTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateProductDateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderEditButton
            // 
            this.HeaderEditButton.BackColor = System.Drawing.Color.Gray;
            this.HeaderEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderEditButton.Location = new System.Drawing.Point(37, 40);
            this.HeaderEditButton.Name = "HeaderEditButton";
            this.HeaderEditButton.Size = new System.Drawing.Size(164, 59);
            this.HeaderEditButton.TabIndex = 0;
            this.HeaderEditButton.Text = "Edytuj Dane Nagłówkowe";
            this.HeaderEditButton.UseVisualStyleBackColor = false;
            this.HeaderEditButton.Click += new System.EventHandler(this.HeaderEditButton_Click);
            // 
            // EditArticlesButton
            // 
            this.EditArticlesButton.BackColor = System.Drawing.Color.Gray;
            this.EditArticlesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditArticlesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditArticlesButton.Location = new System.Drawing.Point(37, 145);
            this.EditArticlesButton.Name = "EditArticlesButton";
            this.EditArticlesButton.Size = new System.Drawing.Size(164, 57);
            this.EditArticlesButton.TabIndex = 1;
            this.EditArticlesButton.Text = "Edytuj Pozycje Dokumentu";
            this.EditArticlesButton.UseVisualStyleBackColor = false;
            this.EditArticlesButton.Click += new System.EventHandler(this.EditArticlesButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Lime;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.Black;
            this.SaveChangesButton.Location = new System.Drawing.Point(37, 256);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(164, 59);
            this.SaveChangesButton.TabIndex = 2;
            this.SaveChangesButton.Text = "Zapisz Zmiany";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackColor = System.Drawing.Color.Red;
            this.CancelChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelChangesButton.Location = new System.Drawing.Point(37, 367);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(164, 59);
            this.CancelChangesButton.TabIndex = 3;
            this.CancelChangesButton.Text = "Nie Zapisuj";
            this.CancelChangesButton.UseVisualStyleBackColor = false;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Gray;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(37, 473);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(164, 59);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Wróc";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateNameTextBox
            // 
            this.UpdateNameTextBox.Location = new System.Drawing.Point(251, 40);
            this.UpdateNameTextBox.Name = "UpdateNameTextBox";
            this.UpdateNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.UpdateNameTextBox.TabIndex = 5;
            // 
            // UpdateIdKleintaTextBox
            // 
            this.UpdateIdKleintaTextBox.Location = new System.Drawing.Point(477, 40);
            this.UpdateIdKleintaTextBox.Name = "UpdateIdKleintaTextBox";
            this.UpdateIdKleintaTextBox.Size = new System.Drawing.Size(164, 20);
            this.UpdateIdKleintaTextBox.TabIndex = 6;
            // 
            // Updatenamelabel
            // 
            this.Updatenamelabel.AutoSize = true;
            this.Updatenamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Updatenamelabel.Location = new System.Drawing.Point(248, 18);
            this.Updatenamelabel.Name = "Updatenamelabel";
            this.Updatenamelabel.Size = new System.Drawing.Size(54, 18);
            this.Updatenamelabel.TabIndex = 7;
            this.Updatenamelabel.Text = "Nazwa";
            // 
            // UpdateIdKlientaLabel
            // 
            this.UpdateIdKlientaLabel.AutoSize = true;
            this.UpdateIdKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateIdKlientaLabel.Location = new System.Drawing.Point(474, 18);
            this.UpdateIdKlientaLabel.Name = "UpdateIdKlientaLabel";
            this.UpdateIdKlientaLabel.Size = new System.Drawing.Size(65, 18);
            this.UpdateIdKlientaLabel.TabIndex = 8;
            this.UpdateIdKlientaLabel.Text = "Id klienta";
            // 
            // UpdateDatePicker
            // 
            this.UpdateDatePicker.Location = new System.Drawing.Point(251, 94);
            this.UpdateDatePicker.Name = "UpdateDatePicker";
            this.UpdateDatePicker.Size = new System.Drawing.Size(208, 20);
            this.UpdateDatePicker.TabIndex = 9;
            // 
            // UpdateDateLabel
            // 
            this.UpdateDateLabel.AutoSize = true;
            this.UpdateDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateDateLabel.Location = new System.Drawing.Point(248, 73);
            this.UpdateDateLabel.Name = "UpdateDateLabel";
            this.UpdateDateLabel.Size = new System.Drawing.Size(200, 18);
            this.UpdateDateLabel.TabIndex = 10;
            this.UpdateDateLabel.Text = "Data wystawienia dokumentu";
            // 
            // UpdateProductDateGrid
            // 
            this.UpdateProductDateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UpdateProductDateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateProductDateGrid.Location = new System.Drawing.Point(251, 145);
            this.UpdateProductDateGrid.Name = "UpdateProductDateGrid";
            this.UpdateProductDateGrid.Size = new System.Drawing.Size(390, 234);
            this.UpdateProductDateGrid.TabIndex = 11;
            this.UpdateProductDateGrid.Click += new System.EventHandler(this.UpdateProductDateGrid_Click);
            // 
            // UpdateProductNameLabel
            // 
            this.UpdateProductNameLabel.AutoSize = true;
            this.UpdateProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateProductNameLabel.Location = new System.Drawing.Point(257, 417);
            this.UpdateProductNameLabel.Name = "UpdateProductNameLabel";
            this.UpdateProductNameLabel.Size = new System.Drawing.Size(118, 18);
            this.UpdateProductNameLabel.TabIndex = 12;
            this.UpdateProductNameLabel.Text = "Nazwa Produktu";
            // 
            // UpdateLiczbaSztukProduktuLabel
            // 
            this.UpdateLiczbaSztukProduktuLabel.AutoSize = true;
            this.UpdateLiczbaSztukProduktuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateLiczbaSztukProduktuLabel.Location = new System.Drawing.Point(474, 417);
            this.UpdateLiczbaSztukProduktuLabel.Name = "UpdateLiczbaSztukProduktuLabel";
            this.UpdateLiczbaSztukProduktuLabel.Size = new System.Drawing.Size(91, 18);
            this.UpdateLiczbaSztukProduktuLabel.TabIndex = 13;
            this.UpdateLiczbaSztukProduktuLabel.Text = "Liczba sztuk";
            // 
            // UpdateProductNameTextBox
            // 
            this.UpdateProductNameTextBox.Location = new System.Drawing.Point(260, 452);
            this.UpdateProductNameTextBox.Name = "UpdateProductNameTextBox";
            this.UpdateProductNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.UpdateProductNameTextBox.TabIndex = 14;
            // 
            // UpdateLiczbaSztukTextBox
            // 
            this.UpdateLiczbaSztukTextBox.Location = new System.Drawing.Point(477, 452);
            this.UpdateLiczbaSztukTextBox.Name = "UpdateLiczbaSztukTextBox";
            this.UpdateLiczbaSztukTextBox.Size = new System.Drawing.Size(164, 20);
            this.UpdateLiczbaSztukTextBox.TabIndex = 15;
            // 
            // UpdateCenaNettoProduktuLabel
            // 
            this.UpdateCenaNettoProduktuLabel.AutoSize = true;
            this.UpdateCenaNettoProduktuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateCenaNettoProduktuLabel.Location = new System.Drawing.Point(257, 494);
            this.UpdateCenaNettoProduktuLabel.Name = "UpdateCenaNettoProduktuLabel";
            this.UpdateCenaNettoProduktuLabel.Size = new System.Drawing.Size(80, 18);
            this.UpdateCenaNettoProduktuLabel.TabIndex = 16;
            this.UpdateCenaNettoProduktuLabel.Text = "Cena netto";
            // 
            // UpdateCenaBruttoProduktuLabel
            // 
            this.UpdateCenaBruttoProduktuLabel.AutoSize = true;
            this.UpdateCenaBruttoProduktuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateCenaBruttoProduktuLabel.Location = new System.Drawing.Point(474, 494);
            this.UpdateCenaBruttoProduktuLabel.Name = "UpdateCenaBruttoProduktuLabel";
            this.UpdateCenaBruttoProduktuLabel.Size = new System.Drawing.Size(85, 18);
            this.UpdateCenaBruttoProduktuLabel.TabIndex = 17;
            this.UpdateCenaBruttoProduktuLabel.Text = "Cena brutto";
            // 
            // UpdateCenaNettoProduktuTextBox
            // 
            this.UpdateCenaNettoProduktuTextBox.Location = new System.Drawing.Point(260, 532);
            this.UpdateCenaNettoProduktuTextBox.Name = "UpdateCenaNettoProduktuTextBox";
            this.UpdateCenaNettoProduktuTextBox.Size = new System.Drawing.Size(164, 20);
            this.UpdateCenaNettoProduktuTextBox.TabIndex = 18;
            // 
            // UpdateCenaBruttoProduktuTextBox
            // 
            this.UpdateCenaBruttoProduktuTextBox.Location = new System.Drawing.Point(477, 532);
            this.UpdateCenaBruttoProduktuTextBox.Name = "UpdateCenaBruttoProduktuTextBox";
            this.UpdateCenaBruttoProduktuTextBox.Size = new System.Drawing.Size(164, 20);
            this.UpdateCenaBruttoProduktuTextBox.TabIndex = 19;
            // 
            // UpdateDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(673, 564);
            this.Controls.Add(this.UpdateCenaBruttoProduktuTextBox);
            this.Controls.Add(this.UpdateCenaNettoProduktuTextBox);
            this.Controls.Add(this.UpdateCenaBruttoProduktuLabel);
            this.Controls.Add(this.UpdateCenaNettoProduktuLabel);
            this.Controls.Add(this.UpdateLiczbaSztukTextBox);
            this.Controls.Add(this.UpdateProductNameTextBox);
            this.Controls.Add(this.UpdateLiczbaSztukProduktuLabel);
            this.Controls.Add(this.UpdateProductNameLabel);
            this.Controls.Add(this.UpdateProductDateGrid);
            this.Controls.Add(this.UpdateDateLabel);
            this.Controls.Add(this.UpdateDatePicker);
            this.Controls.Add(this.UpdateIdKlientaLabel);
            this.Controls.Add(this.Updatenamelabel);
            this.Controls.Add(this.UpdateIdKleintaTextBox);
            this.Controls.Add(this.UpdateNameTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.EditArticlesButton);
            this.Controls.Add(this.HeaderEditButton);
            this.Name = "UpdateDocumentForm";
            this.Text = "UpdateDocumentForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpdateProductDateGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HeaderEditButton;
        private System.Windows.Forms.Button EditArticlesButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox UpdateNameTextBox;
        private System.Windows.Forms.TextBox UpdateIdKleintaTextBox;
        private System.Windows.Forms.Label Updatenamelabel;
        private System.Windows.Forms.Label UpdateIdKlientaLabel;
        private System.Windows.Forms.DateTimePicker UpdateDatePicker;
        private System.Windows.Forms.Label UpdateDateLabel;
        private System.Windows.Forms.DataGridView UpdateProductDateGrid;
        private System.Windows.Forms.Label UpdateProductNameLabel;
        private System.Windows.Forms.Label UpdateLiczbaSztukProduktuLabel;
        private System.Windows.Forms.TextBox UpdateProductNameTextBox;
        private System.Windows.Forms.TextBox UpdateLiczbaSztukTextBox;
        private System.Windows.Forms.Label UpdateCenaNettoProduktuLabel;
        private System.Windows.Forms.Label UpdateCenaBruttoProduktuLabel;
        private System.Windows.Forms.TextBox UpdateCenaNettoProduktuTextBox;
        private System.Windows.Forms.TextBox UpdateCenaBruttoProduktuTextBox;
    }
}
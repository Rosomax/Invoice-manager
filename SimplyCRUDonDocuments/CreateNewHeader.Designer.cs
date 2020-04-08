namespace SimplyCRUDonDocuments
{
    partial class CreateNewHeader
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderNameTextBox = new System.Windows.Forms.TextBox();
            this.HeaderNameLabel = new System.Windows.Forms.Label();
            this.DateHeaderLabel = new System.Windows.Forms.Label();
            this.HeaderNettoLabel = new System.Windows.Forms.Label();
            this.HeaderBrutttoLabel = new System.Windows.Forms.Label();
            this.HeaderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HeaderIdKlientaTextBox = new System.Windows.Forms.TextBox();
            this.HeaderIdKlientaLabel = new System.Windows.Forms.Label();
            this.ConfirmHeaderButton = new System.Windows.Forms.Button();
            this.HeaderCancelButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductFormTimer = new System.Windows.Forms.Timer(this.components);
            this.CreateIdDocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderNameTextBox
            // 
            this.HeaderNameTextBox.Location = new System.Drawing.Point(29, 55);
            this.HeaderNameTextBox.Name = "HeaderNameTextBox";
            this.HeaderNameTextBox.Size = new System.Drawing.Size(249, 20);
            this.HeaderNameTextBox.TabIndex = 0;
            // 
            // HeaderNameLabel
            // 
            this.HeaderNameLabel.AutoSize = true;
            this.HeaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderNameLabel.Location = new System.Drawing.Point(25, 20);
            this.HeaderNameLabel.Name = "HeaderNameLabel";
            this.HeaderNameLabel.Size = new System.Drawing.Size(218, 20);
            this.HeaderNameLabel.TabIndex = 4;
            this.HeaderNameLabel.Text = "Wprowadz nazwę dokumentu";
            // 
            // DateHeaderLabel
            // 
            this.DateHeaderLabel.AutoSize = true;
            this.DateHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateHeaderLabel.Location = new System.Drawing.Point(25, 92);
            this.DateHeaderLabel.Name = "DateHeaderLabel";
            this.DateHeaderLabel.Size = new System.Drawing.Size(273, 20);
            this.DateHeaderLabel.TabIndex = 5;
            this.DateHeaderLabel.Text = "Wybierz datę wystawienia dokumentu";
            // 
            // HeaderNettoLabel
            // 
            this.HeaderNettoLabel.AutoSize = true;
            this.HeaderNettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderNettoLabel.Location = new System.Drawing.Point(376, 511);
            this.HeaderNettoLabel.Name = "HeaderNettoLabel";
            this.HeaderNettoLabel.Size = new System.Drawing.Size(171, 16);
            this.HeaderNettoLabel.TabIndex = 6;
            this.HeaderNettoLabel.Text = "Kwota faktury netto: 0 zł";
            // 
            // HeaderBrutttoLabel
            // 
            this.HeaderBrutttoLabel.AutoSize = true;
            this.HeaderBrutttoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderBrutttoLabel.Location = new System.Drawing.Point(376, 562);
            this.HeaderBrutttoLabel.Name = "HeaderBrutttoLabel";
            this.HeaderBrutttoLabel.Size = new System.Drawing.Size(176, 16);
            this.HeaderBrutttoLabel.TabIndex = 7;
            this.HeaderBrutttoLabel.Text = "Kwota faktury brutto: 0 zł";
            // 
            // HeaderDateTimePicker
            // 
            this.HeaderDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderDateTimePicker.Location = new System.Drawing.Point(29, 125);
            this.HeaderDateTimePicker.Name = "HeaderDateTimePicker";
            this.HeaderDateTimePicker.Size = new System.Drawing.Size(292, 26);
            this.HeaderDateTimePicker.TabIndex = 8;
            // 
            // HeaderIdKlientaTextBox
            // 
            this.HeaderIdKlientaTextBox.Location = new System.Drawing.Point(322, 55);
            this.HeaderIdKlientaTextBox.Name = "HeaderIdKlientaTextBox";
            this.HeaderIdKlientaTextBox.Size = new System.Drawing.Size(249, 20);
            this.HeaderIdKlientaTextBox.TabIndex = 9;
            // 
            // HeaderIdKlientaLabel
            // 
            this.HeaderIdKlientaLabel.AutoSize = true;
            this.HeaderIdKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderIdKlientaLabel.Location = new System.Drawing.Point(318, 20);
            this.HeaderIdKlientaLabel.Name = "HeaderIdKlientaLabel";
            this.HeaderIdKlientaLabel.Size = new System.Drawing.Size(157, 20);
            this.HeaderIdKlientaLabel.TabIndex = 10;
            this.HeaderIdKlientaLabel.Text = "Wprowadz ID Klienta";
            // 
            // ConfirmHeaderButton
            // 
            this.ConfirmHeaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ConfirmHeaderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmHeaderButton.Location = new System.Drawing.Point(203, 511);
            this.ConfirmHeaderButton.Name = "ConfirmHeaderButton";
            this.ConfirmHeaderButton.Size = new System.Drawing.Size(130, 67);
            this.ConfirmHeaderButton.TabIndex = 11;
            this.ConfirmHeaderButton.Text = "Dodaj Dokument";
            this.ConfirmHeaderButton.UseVisualStyleBackColor = false;
            this.ConfirmHeaderButton.Click += new System.EventHandler(this.ConfirmHeaderButton_Click);
            // 
            // HeaderCancelButton
            // 
            this.HeaderCancelButton.BackColor = System.Drawing.Color.Red;
            this.HeaderCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderCancelButton.Location = new System.Drawing.Point(29, 511);
            this.HeaderCancelButton.Name = "HeaderCancelButton";
            this.HeaderCancelButton.Size = new System.Drawing.Size(136, 67);
            this.HeaderCancelButton.TabIndex = 12;
            this.HeaderCancelButton.Text = "Anuluj";
            this.HeaderCancelButton.UseVisualStyleBackColor = false;
            this.HeaderCancelButton.Click += new System.EventHandler(this.HeaderCancelButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddProductButton.Location = new System.Drawing.Point(340, 125);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(117, 75);
            this.AddProductButton.TabIndex = 13;
            this.AddProductButton.Text = " Dodaj Produkt";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Visible = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.BackColor = System.Drawing.Color.Red;
            this.RemoveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveProductButton.Location = new System.Drawing.Point(470, 125);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(117, 75);
            this.RemoveProductButton.TabIndex = 14;
            this.RemoveProductButton.Text = "Usuń Produkt";
            this.RemoveProductButton.UseVisualStyleBackColor = false;
            this.RemoveProductButton.Visible = false;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // ProductDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.EnableHeadersVisualStyles = false;
            this.ProductDataGrid.Location = new System.Drawing.Point(29, 237);
            this.ProductDataGrid.MultiSelect = false;
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.RowHeadersVisible = false;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.Size = new System.Drawing.Size(558, 216);
            this.ProductDataGrid.TabIndex = 15;
            this.ProductDataGrid.Visible = false;
            this.ProductDataGrid.Click += new System.EventHandler(this.ProductDataGrid_Click);
            // 
            // ProductFormTimer
            // 
            this.ProductFormTimer.Enabled = true;
            // 
            // CreateIdDocLabel
            // 
            this.CreateIdDocLabel.AutoSize = true;
            this.CreateIdDocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateIdDocLabel.Location = new System.Drawing.Point(25, 180);
            this.CreateIdDocLabel.Name = "CreateIdDocLabel";
            this.CreateIdDocLabel.Size = new System.Drawing.Size(86, 20);
            this.CreateIdDocLabel.TabIndex = 16;
            this.CreateIdDocLabel.Text = "Numer doc";
            // 
            // CreateNewHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(626, 590);
            this.Controls.Add(this.CreateIdDocLabel);
            this.Controls.Add(this.ProductDataGrid);
            this.Controls.Add(this.RemoveProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.HeaderCancelButton);
            this.Controls.Add(this.ConfirmHeaderButton);
            this.Controls.Add(this.HeaderIdKlientaLabel);
            this.Controls.Add(this.HeaderIdKlientaTextBox);
            this.Controls.Add(this.HeaderDateTimePicker);
            this.Controls.Add(this.HeaderBrutttoLabel);
            this.Controls.Add(this.HeaderNettoLabel);
            this.Controls.Add(this.DateHeaderLabel);
            this.Controls.Add(this.HeaderNameLabel);
            this.Controls.Add(this.HeaderNameTextBox);
            this.MaximizeBox = false;
            this.Name = "CreateNewHeader";
            this.Text = "CreateNewHeader";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeaderNameTextBox;
        private System.Windows.Forms.Label HeaderNameLabel;
        private System.Windows.Forms.Label DateHeaderLabel;
        private System.Windows.Forms.Label HeaderNettoLabel;
        private System.Windows.Forms.Label HeaderBrutttoLabel;
        private System.Windows.Forms.DateTimePicker HeaderDateTimePicker;
        private System.Windows.Forms.TextBox HeaderIdKlientaTextBox;
        private System.Windows.Forms.Label HeaderIdKlientaLabel;
        private System.Windows.Forms.Button ConfirmHeaderButton;
        private System.Windows.Forms.Button HeaderCancelButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.Timer ProductFormTimer;
        private System.Windows.Forms.Label CreateIdDocLabel;
    }
}
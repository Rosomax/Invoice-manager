namespace SimplyCRUDonDocuments
{
    partial class DetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.DatailNameLabelToFill = new System.Windows.Forms.Label();
            this.DetailDateLabelToFill = new System.Windows.Forms.Label();
            this.DetailIDKlientaToFill = new System.Windows.Forms.Label();
            this.DetailDataGrid = new System.Windows.Forms.DataGridView();
            this.DetailNettoLabel = new System.Windows.Forms.Label();
            this.DetailBruttoLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.IddocLabelToFill = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DatailNameLabelToFill
            // 
            this.DatailNameLabelToFill.AutoSize = true;
            this.DatailNameLabelToFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatailNameLabelToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatailNameLabelToFill.Location = new System.Drawing.Point(322, 129);
            this.DatailNameLabelToFill.Name = "DatailNameLabelToFill";
            this.DatailNameLabelToFill.Size = new System.Drawing.Size(115, 39);
            this.DatailNameLabelToFill.TabIndex = 0;
            this.DatailNameLabelToFill.Text = "label1";
            this.DatailNameLabelToFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailDateLabelToFill
            // 
            this.DetailDateLabelToFill.AutoSize = true;
            this.DetailDateLabelToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailDateLabelToFill.Location = new System.Drawing.Point(536, 9);
            this.DetailDateLabelToFill.Name = "DetailDateLabelToFill";
            this.DetailDateLabelToFill.Size = new System.Drawing.Size(172, 24);
            this.DetailDateLabelToFill.TabIndex = 3;
            this.DetailDateLabelToFill.Text = "Data Wystawienia";
            // 
            // DetailIDKlientaToFill
            // 
            this.DetailIDKlientaToFill.AutoSize = true;
            this.DetailIDKlientaToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailIDKlientaToFill.Location = new System.Drawing.Point(12, 72);
            this.DetailIDKlientaToFill.Name = "DetailIDKlientaToFill";
            this.DetailIDKlientaToFill.Size = new System.Drawing.Size(142, 24);
            this.DetailIDKlientaToFill.TabIndex = 4;
            this.DetailIDKlientaToFill.Text = "Numer Klienta";
            // 
            // DetailDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DetailDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DetailDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DetailDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DetailDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DetailDataGrid.Enabled = false;
            this.DetailDataGrid.EnableHeadersVisualStyles = false;
            this.DetailDataGrid.GridColor = System.Drawing.Color.White;
            this.DetailDataGrid.Location = new System.Drawing.Point(46, 238);
            this.DetailDataGrid.MultiSelect = false;
            this.DetailDataGrid.Name = "DetailDataGrid";
            this.DetailDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DetailDataGrid.RowHeadersVisible = false;
            this.DetailDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.Format = "C2";
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DetailDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailDataGrid.RowTemplate.Height = 50;
            this.DetailDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetailDataGrid.Size = new System.Drawing.Size(662, 471);
            this.DetailDataGrid.TabIndex = 5;
            // 
            // DetailNettoLabel
            // 
            this.DetailNettoLabel.AutoSize = true;
            this.DetailNettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailNettoLabel.Location = new System.Drawing.Point(12, 740);
            this.DetailNettoLabel.Name = "DetailNettoLabel";
            this.DetailNettoLabel.Size = new System.Drawing.Size(127, 24);
            this.DetailNettoLabel.TabIndex = 6;
            this.DetailNettoLabel.Text = "Kwota Netto:";
            // 
            // DetailBruttoLabel
            // 
            this.DetailBruttoLabel.AutoSize = true;
            this.DetailBruttoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailBruttoLabel.Location = new System.Drawing.Point(12, 781);
            this.DetailBruttoLabel.Name = "DetailBruttoLabel";
            this.DetailBruttoLabel.Size = new System.Drawing.Size(132, 24);
            this.DetailBruttoLabel.TabIndex = 7;
            this.DetailBruttoLabel.Text = "Kwota Brutto:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // IddocLabelToFill
            // 
            this.IddocLabelToFill.AutoSize = true;
            this.IddocLabelToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IddocLabelToFill.Location = new System.Drawing.Point(12, 9);
            this.IddocLabelToFill.Name = "IddocLabelToFill";
            this.IddocLabelToFill.Size = new System.Drawing.Size(66, 24);
            this.IddocLabelToFill.TabIndex = 10;
            this.IddocLabelToFill.Text = "label1";
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrintButton.Location = new System.Drawing.Point(563, 740);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(159, 65);
            this.PrintButton.TabIndex = 11;
            this.PrintButton.Text = "Drukuj";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnButton.Location = new System.Drawing.Point(288, 740);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(167, 65);
            this.ReturnButton.TabIndex = 12;
            this.ReturnButton.Text = "Wróć";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(761, 842);
            this.ControlBox = false;
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.IddocLabelToFill);
            this.Controls.Add(this.DetailBruttoLabel);
            this.Controls.Add(this.DetailNettoLabel);
            this.Controls.Add(this.DetailDataGrid);
            this.Controls.Add(this.DetailIDKlientaToFill);
            this.Controls.Add(this.DetailDateLabelToFill);
            this.Controls.Add(this.DatailNameLabelToFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatailNameLabelToFill;
        private System.Windows.Forms.Label DetailDateLabelToFill;
        private System.Windows.Forms.Label DetailIDKlientaToFill;
        private System.Windows.Forms.DataGridView DetailDataGrid;
        private System.Windows.Forms.Label DetailNettoLabel;
        private System.Windows.Forms.Label DetailBruttoLabel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label IddocLabelToFill;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
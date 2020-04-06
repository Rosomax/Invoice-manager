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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.DatailNameLabelToFill = new System.Windows.Forms.Label();
            this.DetailDateLabel = new System.Windows.Forms.Label();
            this.DetailsIdKlientaLabel = new System.Windows.Forms.Label();
            this.DetailDateLabelToFill = new System.Windows.Forms.Label();
            this.DetailIDKlientaToFill = new System.Windows.Forms.Label();
            this.DetailDataGrid = new System.Windows.Forms.DataGridView();
            this.DetailNettoLabel = new System.Windows.Forms.Label();
            this.DetailBruttoLabel = new System.Windows.Forms.Label();
            this.DetailBruttoToFill = new System.Windows.Forms.Label();
            this.DetailNettoToFill = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Print = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatailNameLabelToFill
            // 
            this.DatailNameLabelToFill.AutoSize = true;
            this.DatailNameLabelToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatailNameLabelToFill.Location = new System.Drawing.Point(216, 31);
            this.DatailNameLabelToFill.Name = "DatailNameLabelToFill";
            this.DatailNameLabelToFill.Size = new System.Drawing.Size(76, 25);
            this.DatailNameLabelToFill.TabIndex = 0;
            this.DatailNameLabelToFill.Text = "label1";
            // 
            // DetailDateLabel
            // 
            this.DetailDateLabel.AutoSize = true;
            this.DetailDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailDateLabel.Location = new System.Drawing.Point(12, 84);
            this.DetailDateLabel.Name = "DetailDateLabel";
            this.DetailDateLabel.Size = new System.Drawing.Size(152, 20);
            this.DetailDateLabel.TabIndex = 1;
            this.DetailDateLabel.Text = "Data Wystawienia";
            // 
            // DetailsIdKlientaLabel
            // 
            this.DetailsIdKlientaLabel.AutoSize = true;
            this.DetailsIdKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailsIdKlientaLabel.Location = new System.Drawing.Point(43, 137);
            this.DetailsIdKlientaLabel.Name = "DetailsIdKlientaLabel";
            this.DetailsIdKlientaLabel.Size = new System.Drawing.Size(121, 20);
            this.DetailsIdKlientaLabel.TabIndex = 2;
            this.DetailsIdKlientaLabel.Text = "Numer Klienta";
            // 
            // DetailDateLabelToFill
            // 
            this.DetailDateLabelToFill.AutoSize = true;
            this.DetailDateLabelToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailDateLabelToFill.Location = new System.Drawing.Point(199, 84);
            this.DetailDateLabelToFill.Name = "DetailDateLabelToFill";
            this.DetailDateLabelToFill.Size = new System.Drawing.Size(152, 20);
            this.DetailDateLabelToFill.TabIndex = 3;
            this.DetailDateLabelToFill.Text = "Data Wystawienia";
            // 
            // DetailIDKlientaToFill
            // 
            this.DetailIDKlientaToFill.AutoSize = true;
            this.DetailIDKlientaToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailIDKlientaToFill.Location = new System.Drawing.Point(199, 137);
            this.DetailIDKlientaToFill.Name = "DetailIDKlientaToFill";
            this.DetailIDKlientaToFill.Size = new System.Drawing.Size(121, 20);
            this.DetailIDKlientaToFill.TabIndex = 4;
            this.DetailIDKlientaToFill.Text = "Numer Klienta";
            // 
            // DetailDataGrid
            // 
            this.DetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailDataGrid.Location = new System.Drawing.Point(16, 205);
            this.DetailDataGrid.Name = "DetailDataGrid";
            this.DetailDataGrid.Size = new System.Drawing.Size(510, 250);
            this.DetailDataGrid.TabIndex = 5;
            // 
            // DetailNettoLabel
            // 
            this.DetailNettoLabel.AutoSize = true;
            this.DetailNettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailNettoLabel.Location = new System.Drawing.Point(12, 495);
            this.DetailNettoLabel.Name = "DetailNettoLabel";
            this.DetailNettoLabel.Size = new System.Drawing.Size(112, 20);
            this.DetailNettoLabel.TabIndex = 6;
            this.DetailNettoLabel.Text = "Kwota Netto:";
            // 
            // DetailBruttoLabel
            // 
            this.DetailBruttoLabel.AutoSize = true;
            this.DetailBruttoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailBruttoLabel.Location = new System.Drawing.Point(12, 544);
            this.DetailBruttoLabel.Name = "DetailBruttoLabel";
            this.DetailBruttoLabel.Size = new System.Drawing.Size(118, 20);
            this.DetailBruttoLabel.TabIndex = 7;
            this.DetailBruttoLabel.Text = "Kwota Brutto:";
            // 
            // DetailBruttoToFill
            // 
            this.DetailBruttoToFill.AutoSize = true;
            this.DetailBruttoToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailBruttoToFill.Location = new System.Drawing.Point(199, 544);
            this.DetailBruttoToFill.Name = "DetailBruttoToFill";
            this.DetailBruttoToFill.Size = new System.Drawing.Size(118, 20);
            this.DetailBruttoToFill.TabIndex = 8;
            this.DetailBruttoToFill.Text = "Kwota Brutto:";
            // 
            // DetailNettoToFill
            // 
            this.DetailNettoToFill.AutoSize = true;
            this.DetailNettoToFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailNettoToFill.Location = new System.Drawing.Point(199, 495);
            this.DetailNettoToFill.Name = "DetailNettoToFill";
            this.DetailNettoToFill.Size = new System.Drawing.Size(112, 20);
            this.DetailNettoToFill.TabIndex = 9;
            this.DetailNettoToFill.Text = "Kwota Netto:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Print});
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.ShowImageMargin = false;
            this.Menu.Size = new System.Drawing.Size(75, 26);
            this.Menu.Text = "Options";
            // 
            // Print
            // 
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(74, 22);
            this.Print.Text = "Print";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(538, 629);
            this.Controls.Add(this.DetailNettoToFill);
            this.Controls.Add(this.DetailBruttoToFill);
            this.Controls.Add(this.DetailBruttoLabel);
            this.Controls.Add(this.DetailNettoLabel);
            this.Controls.Add(this.DetailDataGrid);
            this.Controls.Add(this.DetailIDKlientaToFill);
            this.Controls.Add(this.DetailDateLabelToFill);
            this.Controls.Add(this.DetailsIdKlientaLabel);
            this.Controls.Add(this.DetailDateLabel);
            this.Controls.Add(this.DatailNameLabelToFill);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatailNameLabelToFill;
        private System.Windows.Forms.Label DetailDateLabel;
        private System.Windows.Forms.Label DetailsIdKlientaLabel;
        private System.Windows.Forms.Label DetailDateLabelToFill;
        private System.Windows.Forms.Label DetailIDKlientaToFill;
        private System.Windows.Forms.DataGridView DetailDataGrid;
        private System.Windows.Forms.Label DetailNettoLabel;
        private System.Windows.Forms.Label DetailBruttoLabel;
        private System.Windows.Forms.Label DetailBruttoToFill;
        private System.Windows.Forms.Label DetailNettoToFill;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Print;
    }
}
namespace SimplyCRUDonDocuments
{
    partial class MainForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.MainDeleteButton = new System.Windows.Forms.Button();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.MainDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Lime;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.Location = new System.Drawing.Point(31, 81);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(152, 57);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.Location = new System.Drawing.Point(31, 164);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(152, 54);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Location = new System.Drawing.Point(231, 81);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.Size = new System.Drawing.Size(542, 324);
            this.MainDataGrid.TabIndex = 2;
            this.MainDataGrid.Click += new System.EventHandler(this.MainDataGrid_Click);
            // 
            // MainDeleteButton
            // 
            this.MainDeleteButton.BackColor = System.Drawing.Color.Red;
            this.MainDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainDeleteButton.Location = new System.Drawing.Point(31, 258);
            this.MainDeleteButton.Name = "MainDeleteButton";
            this.MainDeleteButton.Size = new System.Drawing.Size(152, 56);
            this.MainDeleteButton.TabIndex = 4;
            this.MainDeleteButton.Text = "Delete";
            this.MainDeleteButton.UseVisualStyleBackColor = false;
            this.MainDeleteButton.Click += new System.EventHandler(this.MainDeleteButton_Click);
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTitleLabel.Location = new System.Drawing.Point(384, 21);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(254, 31);
            this.MainTitleLabel.TabIndex = 5;
            this.MainTitleLabel.Text = "Lista Dokumentów";
            // 
            // MainDetailsButton
            // 
            this.MainDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MainDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainDetailsButton.Location = new System.Drawing.Point(31, 349);
            this.MainDetailsButton.Name = "MainDetailsButton";
            this.MainDetailsButton.Size = new System.Drawing.Size(152, 56);
            this.MainDetailsButton.TabIndex = 6;
            this.MainDetailsButton.Text = "Details";
            this.MainDetailsButton.UseVisualStyleBackColor = false;
            this.MainDetailsButton.Click += new System.EventHandler(this.MainDetailsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainDetailsButton);
            this.Controls.Add(this.MainTitleLabel);
            this.Controls.Add(this.MainDeleteButton);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "MainForm";
            this.Text = "SimplyCRUDonDocuments";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.Button MainDeleteButton;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Button MainDetailsButton;
    }
}


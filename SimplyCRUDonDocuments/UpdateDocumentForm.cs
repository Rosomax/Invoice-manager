using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyCRUDonDocuments
{
    public partial class UpdateDocumentForm : Form
    {
        public UpdateDocumentForm()
        {
            InitializeComponent();
            StartStatus();
        }
        DocsModelContext modelUpD = new DocsModelContext();
        DocumentPositions article = new DocumentPositions();
        public int DocId { get; set; }
        public void GetDocId(int id)
        {
            DocId = id;
        }
        public DataGridViewRow SelectedRowUpD { get; private set; }
        public void DeliverInfoHeaderUpD(string name, DateTime date, string nrKlienta)
        {
            UpdateNameTextBox.Text = name;
            UpdateDatePicker.Value = date;
            UpdateIdKleintaTextBox.Text = nrKlienta;
        }


        public void FillUpdateProductDetailGrid(int id)
        {
            UpdateProductDateGrid.DataSource = modelUpD.Articles.Select(o => new
            {
                o.NazwaArtykulu,
                o.LiczbaArtykulu,
                o.CenaNettoArtykulu,
                o.CenaBruttoArtykulu,
                o.DocumentId
            }).Where(o=>o.DocumentId==id).ToList();
            UpdateProductDateGrid.Columns["DocumentId"].Visible = false;
            UpdateProductDateGrid.Columns[0].HeaderCell.Value = "Nazwa";
            UpdateProductDateGrid.Columns[1].HeaderCell.Value = "Liczba sztuk";
            UpdateProductDateGrid.Columns[2].HeaderCell.Value = "Cena netto";
            UpdateProductDateGrid.Columns[3].HeaderCell.Value = "Cena brutto";
        }

        public void FillProductDetailToUpDate(string name,int lsztuk, double cenaN, double cenaB)
        {
            UpdateProductNameTextBox.Text = name;
            UpdateLiczbaSztukTextBox.Text = lsztuk.ToString();
            UpdateCenaNettoProduktuTextBox.Text = cenaN.ToString();
            UpdateCenaBruttoProduktuTextBox.Text = cenaB.ToString();
        }

        public void StartStatus()
        {
            HeaderEditButton.Enabled = true;
            HeaderEditButton.BackColor = Color.Gray;
            EditArticlesButton.Enabled = true;
            EditArticlesButton.BackColor = Color.Gray;
            SaveChangesButton.Enabled = false;
            SaveChangesButton.BackColor = Color.White;
            UpdateNameTextBox.Enabled = false;
            CancelChangesButton.Enabled = false;
            CancelChangesButton.BackColor = Color.White;
            UpdateIdKleintaTextBox.Enabled = false;
            UpdateDatePicker.Enabled = false;
            UpdateProductNameTextBox.Enabled = false;
            UpdateLiczbaSztukTextBox.Enabled = false;
            UpdateCenaNettoProduktuTextBox.Enabled = false;
            UpdateCenaBruttoProduktuTextBox.Enabled = false;
        }

        

        private void HeaderEditButton_Click(object sender, EventArgs e)
        {
            EditArticlesButton.Enabled = false;
            EditArticlesButton.BackColor = Color.White;
            SaveChangesButton.Enabled = true;
            SaveChangesButton.BackColor = Color.Lime;
            CancelChangesButton.Enabled = true;
            CancelChangesButton.BackColor = Color.Red;
            UpdateNameTextBox.Enabled = true;
            UpdateIdKleintaTextBox.Enabled = true;
            UpdateDatePicker.Enabled = true;
        }

        private void EditArticlesButton_Click(object sender, EventArgs e)
        {
            HeaderEditButton.Enabled = false;
            HeaderEditButton.BackColor = Color.White;
            SaveChangesButton.Enabled = true;
            SaveChangesButton.BackColor = Color.Lime;
            CancelChangesButton.Enabled = true;
            CancelChangesButton.BackColor = Color.Red;
            UpdateProductNameTextBox.Enabled = true;
            UpdateLiczbaSztukTextBox.Enabled = true;
            UpdateCenaNettoProduktuTextBox.Enabled = true;
            UpdateCenaBruttoProduktuTextBox.Enabled = true;

        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            DocsModelContext modelUpD = new DocsModelContext();
            DocumentHeader header = new DocumentHeader();
            DocumentPositions article = new DocumentPositions();
            try
            {
                if (!EditArticlesButton.Enabled)
                {
                    using (modelUpD)
                    {
                        header = modelUpD.Headers.Where(x => x.DocumentId == DocId).FirstOrDefault();
                        header.Nazwa = UpdateNameTextBox.Text;
                        header.NumerKlienta = Convert.ToInt32(UpdateIdKleintaTextBox.Text);
                        header.Data = Convert.ToDateTime(UpdateDatePicker.Value);
                        modelUpD.SaveChanges();
                        UpdateNameTextBox.Text = header.Nazwa;
                        UpdateIdKleintaTextBox.Text = header.NumerKlienta.ToString();
                        UpdateDatePicker.Value = header.Data;
                    }
                    
                    MessageBox.Show("Zmodyfikowano dane nagłówkowe");
                    //FillHeaderAfterUpDate();
                }

            }
            catch (NullReferenceException) { }
            try
            {
                if (!HeaderEditButton.Enabled & UpdateProductDateGrid.CurrentRow.Index != -1)
                {
                    article.NazwaArtykulu = (UpdateProductDateGrid.CurrentRow.Cells["NazwaArtykulu"].Value).ToString();
                    using (modelUpD)
                    {
                        article = modelUpD.Articles.Where(x => x.NazwaArtykulu == article.NazwaArtykulu).FirstOrDefault();
                        article.NazwaArtykulu = UpdateProductNameTextBox.Text;
                        article.LiczbaArtykulu = Convert.ToInt32(UpdateLiczbaSztukTextBox.Text);
                        article.CenaNettoArtykulu = Convert.ToDouble(UpdateCenaNettoProduktuTextBox.Text);
                        article.CenaBruttoArtykulu = Convert.ToDouble(UpdateCenaBruttoProduktuTextBox.Text);
                        modelUpD.SaveChanges();
                        FillUpdateProductDetailGrid(DocId);

                    }
                    MessageBox.Show("Zmodyfikowano pozycje dokumentu");

                }

            }
            catch (NullReferenceException) { }
            StartStatus();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            StartStatus();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProductDateGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateProductDateGrid.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = UpdateProductDateGrid.SelectedCells[0].RowIndex;
                    SelectedRowUpD = UpdateProductDateGrid.Rows[selectedRowIndex];
                    int Id = Convert.ToInt32(SelectedRowUpD.Cells["DocumentID"].Value);
                    string name = Convert.ToString(SelectedRowUpD.Cells["NazwaArtykulu"].Value);
                    int liczbaArtykulu= Convert.ToInt32(SelectedRowUpD.Cells["LiczbaArtykulu"].Value); 
                    double cenaNetto = Convert.ToDouble(SelectedRowUpD.Cells["CenaNettoArtykulu"].Value);
                    double cenaBrutto = Convert.ToDouble(SelectedRowUpD.Cells["CenaBruttoArtykulu"].Value);
                    FillProductDetailToUpDate(name, liczbaArtykulu, cenaBrutto, cenaBrutto);
                }
            }
            catch (NullReferenceException) { }
        }
    }
}

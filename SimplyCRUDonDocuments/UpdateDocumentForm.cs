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
        }
        private void UpdateDocumentForm_Load(object sender, EventArgs e)
        {
            StartStatus();
        }
        private MainForm mainForm;
        DocsModelContext modelUpD = new DocsModelContext();
        DocumentPositions article = new DocumentPositions();
        public int DocId { get; set; }
        public UpdateDocumentForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }
        public DataGridViewRow SelectedRowUpD { get; private set; }
        public void StartStatus()
        {
            HeaderEditButton.Enabled = true;
            HeaderEditButton.BackColor = Color.Gray;
            EditArticlesButton.Enabled = true;
            EditArticlesButton.BackColor = Color.Gray;
            SaveChangesButton.Enabled = false;
            SaveChangesButton.BackColor = Color.White;
            UpdateAddProductButton.Enabled = false;
            UpdateAddProductButton.BackColor = Color.White;
            UpdateRemoveProductButon.Enabled = false;
            UpdateRemoveProductButon.BackColor = Color.White;
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
        public void DeliverInfoHeaderUpD(string name, DateTime date, string nrKlienta, string kwotaN, string kwotaB)
        {
            UpdateNameTextBox.Text = name;
            UpdateDatePicker.Value = date;
            UpdateIdKleintaTextBox.Text = nrKlienta;
            SumNettoDocLabel.Text = "Razem  netto: " + kwotaN + "zł" ;
            SumaBruttoLabel.Text = "Razem brutto: "+kwotaB+"zł";
        }
        public void FillUpdateProductDetailGrid(int id)
        {
            UpdateProductDateGrid.DataSource = modelUpD.Articles.Select(o => new
            {
                o.NazwaArtykulu,
                o.LiczbaArtykulu,
                o.CenaNettoArtykulu,
                o.CenaBruttoArtykulu,
                o.RazemNetto,
                o.RazemBrutto,
                o.DocumentId
            }).Where(o=>o.DocumentId==id).ToList();
            UpdateProductDateGrid.Columns["DocumentId"].Visible = false;
            UpdateProductDateGrid.Columns[0].HeaderCell.Value = "Nazwa \nProduktu";
            UpdateProductDateGrid.Columns[1].HeaderCell.Value = "Liczba sztuk";
            UpdateProductDateGrid.Columns[2].HeaderCell.Value = "Cena netto w zł";
            UpdateProductDateGrid.Columns[3].HeaderCell.Value = "Cena brutto w zł";
            UpdateProductDateGrid.Columns[4].HeaderCell.Value = "Razem netto w zł";
            UpdateProductDateGrid.Columns[5].HeaderCell.Value = "Razem Brutto w zł";
        }
        public void FillProductDetailToUpDate(string name,int lsztuk, double cenaN, double cenaB)
        {
            UpdateProductNameTextBox.Text = name;
            UpdateLiczbaSztukTextBox.Text = lsztuk.ToString();
            UpdateCenaNettoProduktuTextBox.Text = cenaN.ToString();
            UpdateCenaBruttoProduktuTextBox.Text = cenaB.ToString();
        }
        public void AdditionNettoAndBruttoValue()
        {
            DocsModelContext modelUpD = new DocsModelContext();
            DocumentHeader header = new DocumentHeader();
            double sumN = 0;
            double sumB = 0;
            for (int i = 0; i < UpdateProductDateGrid.Rows.Count; ++i)
            {
                sumN += Convert.ToDouble(UpdateProductDateGrid.Rows[i].Cells[4].Value);
            }
            SumNettoDocLabel.Text = "Razem  netto: " + sumN+"zł";
            for (int i = 0; i < UpdateProductDateGrid.Rows.Count; ++i)
            {
                sumB += Convert.ToDouble(UpdateProductDateGrid.Rows[i].Cells[5].Value);
            }
            SumaBruttoLabel.Text = "Razem  brutto: " + sumB +"zł";
                using (modelUpD)
                {
                    header = modelUpD.Headers.Where(x => x.DocumentId == DocId).FirstOrDefault();
                    header.CenaNetto = sumN;
                    header.CenaBrutto = sumB;
                    modelUpD.SaveChanges();
                }
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
            UpdateAddProductButton.Enabled = true;
            UpdateAddProductButton.BackColor = Color.Lime;
            UpdateRemoveProductButon.Enabled = true;
            UpdateRemoveProductButon.BackColor = Color.Red;
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
            string nettoFix = UpdateCenaNettoProduktuTextBox.Text.Replace('.', ',');
            string bruttoFix = UpdateCenaBruttoProduktuTextBox.Text.Replace('.', ',');
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
                }

            }
            catch (NullReferenceException) { }
            try
            {
                bool checkEmpty = string.IsNullOrEmpty(UpdateLiczbaSztukTextBox.Text);
                if (!HeaderEditButton.Enabled & UpdateProductDateGrid.CurrentRow.Index != -1 & checkEmpty==false)
                {
                    
                    article.NazwaArtykulu = (UpdateProductDateGrid.CurrentRow.Cells["NazwaArtykulu"].Value).ToString();
                    using (modelUpD)
                    {
                        article = modelUpD.Articles.Where(x => x.NazwaArtykulu == article.NazwaArtykulu).FirstOrDefault();
                        article.NazwaArtykulu = UpdateProductNameTextBox.Text;
                        article.LiczbaArtykulu = Convert.ToInt32(UpdateLiczbaSztukTextBox.Text);
                        article.CenaNettoArtykulu = Convert.ToDouble(nettoFix);
                        article.CenaBruttoArtykulu = Convert.ToDouble(bruttoFix);
                        article.RazemNetto = Math.Round((Convert.ToInt32(UpdateLiczbaSztukTextBox.Text) * Convert.ToDouble(nettoFix)),2,0);
                        article.RazemBrutto = Math.Round((Convert.ToInt32(UpdateLiczbaSztukTextBox.Text) * Convert.ToDouble(bruttoFix)),2,0);
                        modelUpD.SaveChanges();
                        FillUpdateProductDetailGrid(DocId);
                        AdditionNettoAndBruttoValue();
                    }
                    MessageBox.Show("Zmodyfikowano pozycje dokumentu");

                }

            }
            catch
            { 
                MessageBox.Show("Nie zaznaczono żadnego produktu"); 
            }
            StartStatus();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            StartStatus();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainForm.FillGrid();
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
                    int liczbaArtykulu = Convert.ToInt32(SelectedRowUpD.Cells["LiczbaArtykulu"].Value);
                    double cenaNetto = Convert.ToDouble(SelectedRowUpD.Cells["CenaNettoArtykulu"].Value);
                    double cenaBrutto = Convert.ToDouble(SelectedRowUpD.Cells["CenaBruttoArtykulu"].Value);
                    FillProductDetailToUpDate(name, liczbaArtykulu, cenaNetto, cenaBrutto);
                }
            }
            catch (NullReferenceException) { }
            try
            {
                if (UpdateProductDateGrid.CurrentRow.Index != -1)
                {
                    article.NazwaArtykulu = Convert.ToString(UpdateProductDateGrid.CurrentRow.Cells["NazwaArtykulu"].Value);
                    using (DocsModelContext modelDB = new DocsModelContext())
                    {
                        article = modelDB.Articles.Where(x => x.NazwaArtykulu == article.NazwaArtykulu).FirstOrDefault();
                    }
                }

            }
            catch(NullReferenceException) { }
        }

        private void UpdateRemoveProductButon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć wybraną pozycję z faktury?", "USUWANIE REKORDU", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (DocsModelContext modelDB = new DocsModelContext())
                    {
                        var entry = modelDB.Entry(article);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                            modelDB.Articles.Attach(article);
                        modelDB.Articles.Remove(article);
                        modelDB.SaveChanges();
                        MessageBox.Show("Pomyślnie usunięto fakture");
                        FillUpdateProductDetailGrid(DocId);
                    };

                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego Produktu", "Błąd", 0);
            };
        }

        private void UpdateAddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm formAddP = new AddProductForm(this);
            formAddP.GetContext = 2;
            formAddP.GetUpdateDocId = DocId;
            formAddP.Show();
        }


    }
}

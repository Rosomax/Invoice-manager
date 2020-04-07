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
    public partial class CreateNewHeader : Form
    {
        public CreateNewHeader()
        {
            InitializeComponent();
            CreateIdDocLabel.Visible = false;
            AddProductButton.Visible = false;
            RemoveProductButton.Visible = false;
            ProductDataGrid.Visible = false;
        }
        DocsModelContext model = new DocsModelContext();
        DocumentPositions article = new DocumentPositions();
        public int docID { get; set; }
        private void HeaderCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillDGP(int actualId)
        {
            ProductDataGrid.DataSource = model.Articles.Select(n => new
            {
                n.DocumentId,
                n.NazwaArtykulu,
                n.LiczbaArtykulu,
                n.CenaNettoArtykulu,
                n.CenaBruttoArtykulu,
                n.RazemNetto,
                n.RazemBrutto
            })
                .Where(n => n.DocumentId == actualId).ToList();
            ProductDataGrid.Columns["DocumentId"].Visible = false;
            ProductDataGrid.Columns[1].HeaderCell.Value = "Nazwa \nProduktu";
            ProductDataGrid.Columns[2].HeaderCell.Value = "Liczba sztuk";
            ProductDataGrid.Columns[3].HeaderCell.Value = "Cena netto w zł";
            ProductDataGrid.Columns[4].HeaderCell.Value = "Cena brutto w zł";
            ProductDataGrid.Columns[5].HeaderCell.Value = "Razem netto w zł";
            ProductDataGrid.Columns[6].HeaderCell.Value = "Razem Brutto w zł";
        }
        private void ConfirmHeaderButton_Click(object sender, EventArgs e)
        {
            using (var db = new DocsModelContext())
            {

                db.Headers.Add(new DocumentHeader
                {

                    Nazwa = HeaderNameTextBox.Text,
                    Data = HeaderDateTimePicker.Value,
                    NumerKlienta = int.Parse(HeaderIdKlientaTextBox.Text),
                    CenaNetto = 0,
                    CenaBrutto = 0,
                });
                db.SaveChanges();
                int actualId = db.Headers.Max(x => x.DocumentId);
                CreateIdDocLabel.Visible = true;
                CreateIdDocLabel.Text ="Numer faktury: "+ actualId.ToString();
                AddProductButton.Visible = true;
                RemoveProductButton.Visible = true;
                ProductDataGrid.Visible = true;
                HeaderNameTextBox.Enabled = false;
                HeaderIdKlientaTextBox.Enabled = false;
                HeaderDateTimePicker.Enabled = false;
                HeaderCancelButton.Text = "Zakończ dokument";
                MessageBox.Show("Pomyślnie dodano dokument do bazy!", "Sukces", 0);
                MessageBox.Show("Możesz teraz uzupełnić dokument o produkty", "Komunikat", 0);
                ConfirmHeaderButton.Enabled = false;
                fillDGP(docID);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm formAddP = new AddProductForm(this);

            formAddP.Show();
            fillDGP(docID);
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
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
                        ProductDataGrid.DataSource = modelDB.Articles.Select(n => new
                        {
                            n.DocumentId,
                            n.NazwaArtykulu,
                            n.LiczbaArtykulu,
                            n.CenaNettoArtykulu,
                            n.CenaBruttoArtykulu
                        })
                        .Where(n => n.DocumentId == int.Parse(CreateIdDocLabel.Text)).ToList();
                    };
                    
                }
                catch
                {
                    
                }
                fillDGP(docID);
            }
            else 
            { 
                MessageBox.Show("Nie zaznaczono żadnego Produktu", "Błąd", 0); 
            };


        }

        private void ProductDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductDataGrid.CurrentRow.Index != -1)
                {
                    article.NazwaArtykulu = Convert.ToString(ProductDataGrid.CurrentRow.Cells["NazwaArtykulu"].Value);
                    using (DocsModelContext modelDB = new DocsModelContext())       
                    {
                        article = modelDB.Articles.Where(x => x.NazwaArtykulu == article.NazwaArtykulu).FirstOrDefault();
                    }
                }
                
            }
            catch (NullReferenceException) { }
        }
    }
}

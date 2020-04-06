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
            AddProductButton.Visible = false;
            RemoveProductButton.Visible = false;
            ProductDataGrid.Visible = false;
        }

        private void HeaderCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int actualId = db.Headers.Max(x => x.DocumentId);
                db.SaveChanges();
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
                ProductDataGrid.DataSource = db.Articles.Select(n => new
                {
                    n.DocumentId,
                    n.NazwaArtykulu,
                    n.LiczbaArtykulu,
                    n.CenaNettoArtykulu,
                    n.CenaBruttoArtykulu
                })
                .Where(n => n.DocumentId == actualId).ToList();
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm formAddP = new AddProductForm();
            formAddP.Show();
            int actualId;
            using (var db = new DocsModelContext())
            {
                actualId = db.Headers.Max(x => x.DocumentId);
            }
                formAddP.FillProdcutDataGrid(ProductDataGrid, actualId);
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            
             
        }
    }
}

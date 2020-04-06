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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        DocsModelContext model = new DocsModelContext();
        int maxValue;

        public void ClearProductFields()
        {
            NameProductTextBox.Text = "";
            NumberProductTextBox.Text = "";
            NettoPriceTextBox.Text = "";
            BruttoPriceTextBox.Text = "";
        }

        public void FillProdcutDataGrid(DataGridView data, int actualId)
        {
            data.DataSource=model.Articles.Select(n => new
            {
                n.DocumentId,
                n.NazwaArtykulu,
                n.LiczbaArtykulu,
                n.CenaNettoArtykulu,
                n.CenaBruttoArtykulu
            })
                .Where(n => n.DocumentId == actualId).ToList();
        }
        public void RemoveRecord()
        { }

        private void AcceptProductButton_Click(object sender, EventArgs e)
        {

                using (var dbProd = new DocsModelContext())
                {
                maxValue = dbProd.Headers.Max(x => x.DocumentId);
                dbProd.Articles.Add(new DocumentPositions
                {
                    NazwaArtykulu = NameProductTextBox.Text,
                    LiczbaArtykulu = int.Parse(NumberProductTextBox.Text),
                    CenaNettoArtykulu = double.Parse(NettoPriceTextBox.Text),
                    CenaBruttoArtykulu = double.Parse(BruttoPriceTextBox.Text),
                    DocumentId = maxValue
                });
                    dbProd.SaveChanges();
                    ClearProductFields();
                    MessageBox.Show("Pomyślnie dodano produkt", "Sukces", 0);
                    DialogResult dialogResult = MessageBox.Show("Czy kontynuować dodawanie produktów?", "Komunikat", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
        }

        private void CancelProdcutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        private CreateNewHeader headerForm;
        private UpdateDocumentForm updateForm;
        public AddProductForm()
        {
            InitializeComponent();
        }
        DocsModelContext model = new DocsModelContext();
        int maxValue;
        public AddProductForm(CreateNewHeader form)
        {
            InitializeComponent();
            headerForm = form;
        }
        public AddProductForm(UpdateDocumentForm formU)
        {
            InitializeComponent();
            updateForm = formU;
        }

        public void ClearProductFields()
        {
            NameProductTextBox.Text = "";
            NumberProductTextBox.Text = "";
            NettoPriceTextBox.Text = "";
            BruttoPriceTextBox.Text = "";
        }

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
                    RazemNetto= int.Parse(NumberProductTextBox.Text)* double.Parse(NettoPriceTextBox.Text),
                    RazemBrutto = int.Parse(BruttoPriceTextBox.Text) * double.Parse(NettoPriceTextBox.Text),
                    DocumentId = maxValue
                });;
                    dbProd.SaveChanges();
                    ClearProductFields();
                    headerForm.fillDGP(maxValue);
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

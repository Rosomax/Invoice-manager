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
        public int GetContext { get; set; }
        public int GetUpdateDocId { get; set; }
        int maxValue;
        public AddProductForm()
        {
            InitializeComponent();
        }
        
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
            string nettoFix = NettoPriceTextBox.Text.Replace('.', ',');
            string bruttoFix = BruttoPriceTextBox.Text.Replace('.', ',');
            using (var dbProd = new DocsModelContext())
                {
                if (GetContext==1)
                {
                    
                    maxValue = dbProd.Headers.Max(x => x.DocumentId);
                    dbProd.Articles.Add(new DocumentPositions
                    {
                        NazwaArtykulu = NameProductTextBox.Text,
                        LiczbaArtykulu = int.Parse(NumberProductTextBox.Text),
                        CenaNettoArtykulu = double.Parse(nettoFix),
                        CenaBruttoArtykulu = double.Parse(bruttoFix),
                        RazemNetto = Math.Round((int.Parse(NumberProductTextBox.Text) * double.Parse(nettoFix)), 2, 0),
                        RazemBrutto = Math.Round((int.Parse(NumberProductTextBox.Text) * double.Parse(bruttoFix)), 2, 0),
                        DocumentId = maxValue
                    }); ;
                    dbProd.SaveChanges();
                    ClearProductFields();
                    headerForm.fillDGP(maxValue);
                    headerForm.AdditionNettoAndBruttoValue();
                }
                else
                {
                    dbProd.Articles.Add(new DocumentPositions
                    {
                        NazwaArtykulu = NameProductTextBox.Text,
                        LiczbaArtykulu = int.Parse(NumberProductTextBox.Text),
                        CenaNettoArtykulu = double.Parse(nettoFix),
                        CenaBruttoArtykulu = double.Parse(bruttoFix),
                        RazemNetto = Math.Round((int.Parse(NumberProductTextBox.Text) * double.Parse(nettoFix)), 2, 0),
                        RazemBrutto = Math.Round((int.Parse(NumberProductTextBox.Text) * double.Parse(bruttoFix)),2,0),
                        DocumentId = GetUpdateDocId
                    }); ;
                    dbProd.SaveChanges();
                    ClearProductFields();
                    updateForm.FillUpdateProductDetailGrid(GetUpdateDocId);
                    updateForm.AdditionNettoAndBruttoValue();
                }
                    
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

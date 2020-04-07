using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyCRUDonDocuments
{
    public partial class DetailForm : Form
    {
        private PrintDocument docToPrint = new PrintDocument();

        public DetailForm()
        {
            InitializeComponent();
            
        }
        DocsModelContext model = new DocsModelContext();
        public void DeliverInfo(int Id, string name,string  date,string nrKlienta,
            string cenaNetto,string  cenaBrutto)
        {

            IddocLabelToFill.Text = "Numer dokumentu: " + Id.ToString();
            DatailNameLabelToFill.Text = name;
            DetailDateLabelToFill.Text = "Data wystawienia: \n"+date;
            DetailIDKlientaToFill.Text = "Numer klienta: "+ nrKlienta;
            DetailNettoLabel.Text = "Kwota faktury netto: "+cenaNetto+"zł";
            DetailBruttoLabel.Text = "Kwota faktury brutto: " + cenaBrutto + "zł";
        }

        

        public void FillProductDetailGrid(int id)
        {
            
            DetailDataGrid.DataSource = model.Articles.Select(o => new
            {
                o.NazwaArtykulu,
                o.LiczbaArtykulu,
                o.CenaNettoArtykulu,
                o.CenaBruttoArtykulu,
                o.RazemNetto,
                o.RazemBrutto,
                o.DocumentId
            }).Where(o => o.DocumentId == id).ToList();
            DetailDataGrid.Columns["DocumentId"].Visible = false;
            DetailDataGrid.Columns[0].HeaderCell.Value = "Nazwa \nProduktu";
            DetailDataGrid.Columns[1].HeaderCell.Value = "Liczba sztuk";
            DetailDataGrid.Columns[2].HeaderCell.Value = "Cena netto w zł";
            DetailDataGrid.Columns[3].HeaderCell.Value = "Cena brutto w zł";
            DetailDataGrid.Columns[4].HeaderCell.Value = "Razem netto w zł";
            DetailDataGrid.Columns[5].HeaderCell.Value = "Razem Brutto w zł";
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;

            printDialog1.ShowHelp = true;

            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
    }
}

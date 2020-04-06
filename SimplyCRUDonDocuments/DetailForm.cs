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
        private PrintDocument docToPrint;

        public DetailForm()
        {
            InitializeComponent();
            
        }
        DocsModelContext model = new DocsModelContext();
        public void DeliverInfo(string name,string  date,string nrKlienta,
            string cenaNetto,string  cenaBrutto)
        {
            DatailNameLabelToFill.Text = name;
            DetailDateLabelToFill.Text = date;
            DetailIDKlientaToFill.Text = nrKlienta;
            DetailNettoToFill.Text = cenaNetto;
            DetailBruttoToFill.Text = cenaBrutto;
        }
        internal void Show(DocumentHeader header)
        {
            DatailNameLabelToFill.Text = header.Nazwa.ToString();
            DetailDateLabelToFill.Text = header.Data.ToString();
            DetailIDKlientaToFill.Text = header.NumerKlienta.ToString();
            DetailNettoToFill.Text = header.CenaNetto.ToString();
            DetailBruttoToFill.Text = header.ToString();
            FillProductDetailGrid(header);
        }

        public void FillProductDetailGrid(DocumentHeader arg)
        {
            DetailDataGrid.DataSource = model.Articles.Select(o => new
            {
                o.NazwaArtykulu,
                o.LiczbaArtykulu,
                o.CenaNettoArtykulu,
                o.CenaBruttoArtykulu,
                o.DocumentId
            }).Where(o => o.DocumentId == 15).ToList();
        }

        private void Print_Click(object sender, EventArgs e)
        {

            printDialog1.AllowSomePages = true;

            printDialog1.ShowHelp = true;

            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }


    }
}

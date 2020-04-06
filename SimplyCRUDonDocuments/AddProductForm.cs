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


        public void ClearProductFields()
        {
            NameProductTextBox.Text = "";
            NumberProductTextBox.Text = "";
            NettoPriceTextBox.Text = "";
            BruttoPriceTextBox.Text = "";
        }
        // przenies iddockumentu jako klucz obcy!!
        private void AcceptProductButton_Click(object sender, EventArgs e)
        {

                using (var dbProd = new DocsModelContext())
                {
 
                int maxValue = dbProd.Headers.Max(x => x.DocumentId);
                //var result = dbProd.Headers.First(x => x.DocumentId == maxValue).ToString();


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
                        //do something
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
        //}
        //    catch
        //    {
        //        MessageBox.Show("Uzupełnij wszystkie pola zanim dodasz produkt", "UWAGA!", 0);
        //    }
}
    }
}

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
        DocsModelContext modelAdd = new DocsModelContext();
        DocumentPositions product = new DocumentPositions();
        public static int IdDoc { get; private set; }
        public DataGridViewRow SelectedRow { get; private set; }
        private void HeaderCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ClearFields()
        {
            HeaderNameTextBox.Text = "";
            HeaderIdKlientaTextBox.Text = "";
            HeaderNettoTextBox.Text = "";
            HeaderBruttoTextBox.Text = "";
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
                AddProductButton.Visible = true;
                RemoveProductButton.Visible = true;
                ProductDataGrid.Visible = true;
                HeaderNameTextBox.Enabled = false;
                HeaderIdKlientaTextBox.Enabled = false;
                HeaderDateTimePicker.Enabled = false;
                HeaderCancelButton.Text = "Zakończ dokument";
                //ClearFields();
                MessageBox.Show("Pomyślnie dodano dokument do bazy!", "Sukces", 0);
                MessageBox.Show("Możesz teraz uzupełnić dokument o produkty", "Komunikat", 0);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm formAddP = new AddProductForm();
            formAddP.Show();
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            
       
        
    }
    }
}

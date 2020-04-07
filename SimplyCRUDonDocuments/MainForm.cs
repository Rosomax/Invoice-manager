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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGrid();
           
        }
        DocsModelContext model = new DocsModelContext();
        DocumentHeader header = new DocumentHeader();
        public DataGridViewRow SelectedRow { get; private set; }
        public static int Id { get; private set; }
        private void MainDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainDataGrid.CurrentRow.Index != -1)
                {
                    header.DocumentId = Convert.ToInt32(MainDataGrid.CurrentRow.Cells["DocumentID"].Value);
                    using (DocsModelContext modelDB = new DocsModelContext())
                    {
                        header = modelDB.Headers.Where(x => x.DocumentId == header.DocumentId).FirstOrDefault();
                    }
                }
            }
            catch (NullReferenceException) { }
        }
        private void MainDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć wybraną fakture?", "USUWANIE REKORDU", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    using (DocsModelContext modelDB = new DocsModelContext())
                    {
                        var entry = modelDB.Entry(header);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                            modelDB.Headers.Attach(header);
                        modelDB.Headers.Remove(header);
                        modelDB.SaveChanges();

                        MessageBox.Show("Pomyślnie usunięto fakture");
                    }
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show("Nie zaznaczono żadnego dokumentu", "Błąd", 0);
                }
        }
        public void FillGrid()
        {
            MainDataGrid.DataSource = model.Headers.Select(o => new
            {
              o.DocumentId,
              o.Nazwa,
              o.NumerKlienta,
              o.Data,
              o.CenaNetto,
              o.CenaBrutto
            }).ToList();
            MainDataGrid.Columns["DocumentId"].Visible = false;
            MainDataGrid.Columns[1].HeaderCell.Value = "Tytuł faktury";
            MainDataGrid.Columns[2].HeaderCell.Value = "Numer klienta";
            MainDataGrid.Columns[3].HeaderCell.Value = "Data wystawienia";
            MainDataGrid.Columns[4].HeaderCell.Value = "Kwota faktury \nnetto w zł";
            MainDataGrid.Columns[5].HeaderCell.Value = "Kwota faktury \nbrutto w zł";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateNewHeader formHeader = new CreateNewHeader();
            formHeader.Show();
            
        }
        
        private void MainDetailsButton_Click(object sender, EventArgs e)
        {
            DetailForm form = new DetailForm();
            try
            {
                if (MainDataGrid.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = MainDataGrid.SelectedCells[0].RowIndex;
                    SelectedRow = MainDataGrid.Rows[selectedRowIndex];
                    int Id = Convert.ToInt32(SelectedRow.Cells["DocumentID"].Value);
                    string name = Convert.ToString(SelectedRow.Cells["Nazwa"].Value);
                    string date = Convert.ToString(SelectedRow.Cells["Data"].Value);
                    string nrKlienta = Convert.ToString(SelectedRow.Cells["NumerKlienta"].Value);
                    string cenaNetto = Convert.ToString(SelectedRow.Cells["CenaNetto"].Value);
                    string cenaBrutto = Convert.ToString(SelectedRow.Cells["CenaBrutto"].Value);
                    DetailForm formDet = new DetailForm();
                    formDet.DeliverInfo(Id, name, date, nrKlienta, cenaNetto, cenaBrutto);
                    formDet.FillProductDetailGrid(Id);
                    formDet.Show();
                    FillGrid();
                }
            }
            catch
            {
                MessageBox.Show("Nie zaznaczono żadnego dokumentu", "Błąd", 0);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateDocumentForm formUpD = new UpdateDocumentForm();
            try
            {
                if (MainDataGrid.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = MainDataGrid.SelectedCells[0].RowIndex;
                    SelectedRow = MainDataGrid.Rows[selectedRowIndex];
                    int Id = Convert.ToInt32(SelectedRow.Cells["DocumentID"].Value);
                    string name = Convert.ToString(SelectedRow.Cells["Nazwa"].Value);
                    DateTime date = Convert.ToDateTime(SelectedRow.Cells["Data"].Value);
                    string nrKlienta = Convert.ToString(SelectedRow.Cells["NumerKlienta"].Value);
                    string cenaNetto = Convert.ToString(SelectedRow.Cells["CenaNetto"].Value);
                    string cenaBrutto = Convert.ToString(SelectedRow.Cells["CenaBrutto"].Value);
                    formUpD.DeliverInfoHeaderUpD(name, date, nrKlienta,cenaNetto,cenaBrutto);
                    formUpD.FillUpdateProductDetailGrid(Id);
                    formUpD.DocId = Id;
                    formUpD.Show();
                    FillGrid();
                }
            }
            catch
            {
                MessageBox.Show("Nie zaznaczono żadnego dokumentu", "Błąd", 0);
            }
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyCRUDonDocuments
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //using (var db = new DocsModelContext())
            //{
            //    db.Headers.Add(new DocumentHeader 
            //    { 
            //        DocumentId = 1,
            //        Nazwa = "PrzykladowaFaktura",
            //        Data = DateTime.Now,
            //        CenaNetto = 20.12,
            //        CenaBrutto = 24.55
            //    });
            //    db.SaveChanges();
            //}
        }
    }
}

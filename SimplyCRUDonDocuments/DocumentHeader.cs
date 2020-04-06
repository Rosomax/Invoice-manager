using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCRUDonDocuments
{       
    [Table("DocumentHeader")]
    public class DocumentHeader
    {
        [Key]
        public int DocumentId { get; set; }
        public DateTime Data { get; set; }
        public int NumerKlienta { get; set; }
        public string Nazwa { get; set; }
        public double CenaNetto { get; set; }
        public double CenaBrutto { get; set; }
        public virtual ICollection<DocumentPositions> Articles { get; set; }

    }
}

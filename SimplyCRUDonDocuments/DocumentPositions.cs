using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCRUDonDocuments
{
    [Table("DocumentPositions")]
    public class DocumentPositions
    {
        [Key]
        public int ID { get; set; }
        public string NazwaArtykulu { get; set; }
        public double CenaNettoArtykulu { get; set; }
        public double CenaBruttoArtykulu { get; set; }
        public int LiczbaArtykulu { get; set; }
        [ForeignKey("DocumentHeader")]
        public int DocumentId { get; set; }
        public virtual DocumentHeader DocumentHeader { get; set; }
    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("DocumentTypeTbl")]
    public class DocumentType
    {
        [Key]
        public Int64 DocumentTypeId { get; set; }   
        public string DocumentTypeName { set; get; }
    }
}

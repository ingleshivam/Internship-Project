using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("IdeaDocumentsTbl")]
    public class IdeaDocuments
    {
        [Key]
        public Int64 IdeaDocumentID { set; get; }

        public string Attachments { set; get; }

        [ForeignKey("DocumentType")]
        public Int64 DocumentTypeID { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public virtual DocumentType DocumentType { set; get; }
        public virtual Idea Idea { set; get; }
    }
}

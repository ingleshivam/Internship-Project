using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DocumentTypeRepo: GenericRepo<DocumentType>, IDocumentType
    {
        CompanyContext cc;
        public DocumentTypeRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}

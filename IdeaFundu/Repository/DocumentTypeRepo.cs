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

        public bool GetByName(string name)
        {
            var record = this.cc.DocumentTypes.SingleOrDefault(p => p.DocumentTypeName == name);
            if (record != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

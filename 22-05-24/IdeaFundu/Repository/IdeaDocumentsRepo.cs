using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IdeaDocumentsRepo : GenericRepo<IdeaDocuments>, IIdeaDocuments
    {
        CompanyContext cc;
        public IdeaDocumentsRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}

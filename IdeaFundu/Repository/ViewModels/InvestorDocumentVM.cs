using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.ValidationAttributes;

namespace Repository.ViewModels
{
    public class InvestorDocumentVM
    {
        public bool isOrganization { set; get; }
        public bool isNRI { set; get; }
        public string CIN { set; get; }
    }
}

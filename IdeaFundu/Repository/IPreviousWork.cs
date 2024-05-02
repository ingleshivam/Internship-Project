using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPreviousWork:IGeneric<PreviousWork>
    {
        void AddRecord(List<PreviousWorkVM> rec);
    }
}

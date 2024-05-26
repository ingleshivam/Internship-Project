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
        public void AddWorkRecord(PreviousWorkVM rec,Int64 UserID);
        public List<PreviousWorkVM> EditWorkRecord(Int64 id);
        List<PreviousWork> GetAllByUserID(Int64 userid);
    }
}

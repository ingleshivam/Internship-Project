using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IWorkClosure:IGeneric<WorkClosure>
    {
        List<WorkProgress> GetAllWorkInProgressIdeas(Int64 UserID);
        List<WorkProgress> GetAllWorkClosedIdeas(Int64 UserID);
    }
}

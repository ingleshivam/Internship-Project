using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IIdea : IGeneric<Idea>
    {
        void EditRecord(Idea rec);
        void DeleteRecord(Int64 id);
    }
}

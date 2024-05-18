using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IIdea : IGeneric<Idea>
    {
        void AddRecord(IdeaBudgetVM rec, string photoFilePath);
        void EditRecord(Idea rec,string photoFilePath);
        void DeleteRecord(Int64 id);
        List<Idea> GetAllByUserID(Int64 userid);
    }
}

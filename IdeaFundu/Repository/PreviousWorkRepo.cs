using Core;
using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PreviousWorkRepo : GenericRepo<PreviousWork>, IPreviousWork
    {
        CompanyContext cc;
        public PreviousWorkRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public void AddRecord(List<PreviousWorkVM> rec)
        {
            foreach(var temp in rec)
            {
                PreviousWork pw = new PreviousWork();
                pw.WorkTitle = temp.WorkTitle;
                pw.WorkDescription = temp.WorkDescription;
                pw.Duration = temp.Duration;
                pw.TentativeBudget = temp.TentativeBudget;
                pw.UserID = temp.UserID;
                this.cc.PreviousWorks.Add(pw);
                this.cc.SaveChanges();
            }
            this.cc.SaveChanges();
        }

        public void AddWorkRecord(PreviousWorkVM rec, Int64 UserID)
        {
            for (int i = 0; i < rec.PreviousWorks.WorkTitle.Count(); i++)
            {
                PreviousWork pw = new PreviousWork();
                pw.WorkTitle = rec.PreviousWorks.WorkTitle[i];
                pw.WorkDescription = rec.PreviousWorks.WorkDescription[i];
                pw.Duration = Convert.ToInt32(rec.PreviousWorks.Duration[i]);
                pw.TentativeBudget = Convert.ToDecimal(rec.PreviousWorks.TentativeBudget[i]);
                pw.UserID = UserID;
                this.cc.PreviousWorks.Add(pw);
            }
            this.cc.SaveChanges();
        }

        public List<PreviousWorkVM> EditWorkRecord(long id)
        {
            var rec = from t in this.cc.PreviousWorks
                      where t.PreviousWorkID == id
                      select new PreviousWorkVM
                      {
                          PreviousWorkID = t.PreviousWorkID,
                          WorkTitle = t.WorkTitle,
                          WorkDescription = t.WorkDescription,
                          Duration = t.Duration,
                          TentativeBudget = t.TentativeBudget,
                          UserID = t.UserID
                      };
            return rec.ToList();
        }

        public List<PreviousWork> GetAllByUserID(long userid)
        {
            return this.cc.PreviousWorks.Where(p => p.UserID == userid).ToList();
        }
    }
}


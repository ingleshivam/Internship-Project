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
            }
            this.cc.SaveChanges();
        }
    }
}

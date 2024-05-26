using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WorkClosureRepo:GenericRepo<WorkClosure>,IWorkClosure
    {
        CompanyContext cc;
        public WorkClosureRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<WorkProgress> GetAllWorkInProgressIdeas(long UserID)
        {

            var v = from t in this.cc.WorkProgresses
                    where !(from t1 in this.cc.WorkClosures
                            select t1.IdeaID)
                            .Contains(t.IdeaID) && t.Idea.UserID == UserID
                    select t;

            return v.ToList();
        }

        public List<WorkProgress> GetAllWorkClosedIdeas(long UserID)
        {
            var v = from t in this.cc.WorkProgresses
                    join t1 in this.cc.WorkClosures
                    on t.IdeaID equals t1.IdeaID
                    select t;

            return v.ToList();
        }
    }
}

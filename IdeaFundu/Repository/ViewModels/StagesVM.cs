using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class StagesVM
    {
        public Int64 StageID { set; get; }
        public string StageName { set; get; }
        public string StageDescription { set; get; }
        public Int64 IdeaID { set; get; }
        public virtual Idea Idea { set; get; }
        public virtual StagessVM Stagess { set; get; }
    }
}

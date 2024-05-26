using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class StagessVM
    {
        public List<string> StageName { set; get; }
        public List<string> StageDescription { set; get; }
        public List<Int64> IdeaID { set; get; }
        public StagessVM()
        {
            StageName = new List<string>();
            StageDescription = new List<string>();
            IdeaID = new List<Int64>();
        }
    }
}

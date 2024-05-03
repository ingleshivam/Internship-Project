using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class MembersVM
    {
        //public Int64 MemberID { set; get; }
        //public string MemberName { set; get; }
        //public string MemberRole { set; get; }
        //public string ShortProfileDesc { set; get; }
        //public Int64 IdeaID { set; get; }
        public List<string> MemberName { set; get; }
        public List<string> MemberRole { set; get; }
        public List<string> ShortProfileDesc { set; get; } 
        public List<Int64> IdeaID { set; get; }
        public MembersVM()
        {
            MemberName = new List<string>();
            MemberRole = new List<string>();
            ShortProfileDesc = new List<string>();
            IdeaID = new List<Int64>();
        }
    }
}

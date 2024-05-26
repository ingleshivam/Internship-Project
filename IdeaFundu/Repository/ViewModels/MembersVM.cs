using Repository.ValidationAttributes;
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
        [ListString(ErrorMessage = "Member Name Required")]
        public List<string> MemberName { set; get; }

        [ListString(ErrorMessage = "Member Role Required")]
        public List<string> MemberRole { set; get; }

        [ListString(ErrorMessage = "Short Profile Description Required")]
        public List<string> ShortProfileDesc { set; get; }

        //[SelectRequired(ErrorMessage ="Idea Name Required")]
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

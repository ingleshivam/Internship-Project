using Core;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class MemberVM
    {
        public Int64 MemberID { set; get; }
        public List<string> MemberName { set; get; }
        public List<string> MemberRole { set; get; }
        public List<string> ShortProfileDesc { set; get; }
        public List<Int64> IdeaID { set; get; }
        public virtual Idea Idea { set; get; }
        public virtual MembersVM Members { set; get; }
        public MemberVM()
        {
            MemberName = new List<string>();
            MemberRole = new List<string>();
            ShortProfileDesc = new List<string>();
        }
    }
}

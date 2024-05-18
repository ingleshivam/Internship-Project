using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMember : IGeneric<Member>
    {
        List<Member> GetAllByUserID(Int64 userid);
    }
}

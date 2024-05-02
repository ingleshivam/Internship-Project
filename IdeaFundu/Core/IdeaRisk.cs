﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("IdeaRiskTbl")]
    public partial class IdeaRisk
    {
        [Key]
        public Int64 RiskID { set; get; }
        
        [ForeignKey("Idea")]
        public Int64 IdeaID {set;get;}
        public string RiskTitle { set; get; }
        [StringLength(800,MinimumLength =60,ErrorMessage ="Description should be maximum of 60 chars.")]
        public string RiskDescription { set; get; }
        public int RiskLevel { set; get; }
        public virtual Idea Idea { set; get; }
    }
}

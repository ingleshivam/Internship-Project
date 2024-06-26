﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("StagesTbl")]
    public class Stages
    {
        [Key]
        public Int64 StageID { set; get; }

        public string StageName { set; get; }

        public string StageDescription { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public virtual Idea Idea { set; get; }
    }
}

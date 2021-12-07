using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZPROPERTY")]
    public partial class ZProperty
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZAID")]
        public long? ZAid { get; set; }

        [Column("ZCID")]
        public long? ZCid { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZSYNCCHECK")]
        public long? ZSyncCheck { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZDESC", TypeName = "VARCHAR")]
        public string ZDesc { get; set; }

        [Column("ZKEY", TypeName = "VARCHAR")]
        public string ZKey { get; set; }

        [Column("ZTYPE", TypeName = "VARCHAR")]
        public string ZType { get; set; }

        [Column("ZVALUE", TypeName = "VARCHAR")]
        public string ZValue { get; set; }
    }
}

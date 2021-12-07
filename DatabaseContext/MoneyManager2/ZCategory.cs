using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZCATEGORY")]
    public partial class ZCategory
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZORDER")]
        public long? ZOrder { get; set; }

        [Column("ZSTATUS")]
        public long? ZStatus { get; set; }

        [Column("ZAID")]
        public long? ZAid { get; set; }

        [Column("ZDOTYPE")]
        public long? ZDoType { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZSYNCCHECK")]
        public long? ZSyncCheck { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZNAME", TypeName = "VARCHAR")]
        public string ZName { get; set; }

        [Column("ZPUID", TypeName = "VARCHAR")]
        public string ZPUid { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }

        [Column("ZZDATA", TypeName = "VARCHAR")]
        public string ZzData { get; set; }

        [Column("ZZDATA2", TypeName = "VARCHAR")]
        public string ZzData2 { get; set; }
    }
}

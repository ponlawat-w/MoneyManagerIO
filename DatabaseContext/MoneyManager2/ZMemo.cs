using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZMEMO")]
    public partial class ZMemo
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZDEL_SYNCTIME")]
        public long? ZDelSynctime { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZMEMOTIME")]
        public long? ZMemoTime { get; set; }

        [Column("ZORDERSEQ")]
        public long? ZOrderSeq { get; set; }

        [Column("ZPINNED")]
        public long? ZPinned { get; set; }

        [Column("ZPINNEDTIME")]
        public long? ZPinnedTime { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZCOLOR", TypeName = "VARCHAR")]
        public string ZColor { get; set; }

        [Column("ZCONTENT", TypeName = "VARCHAR")]
        public string ZContent { get; set; }

        [Column("ZMEMODATE", TypeName = "VARCHAR")]
        public string ZMemoDate { get; set; }

        [Column("ZTITLE", TypeName = "VARCHAR")]
        public string ZTitle { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

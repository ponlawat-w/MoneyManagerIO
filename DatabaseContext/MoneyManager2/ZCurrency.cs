using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZCURRENCY")]
    public partial class ZCurrency
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

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISMAINCURRENCY")]
        public long? ZIsMainCurrency { get; set; }

        [Column("ZISSHOW")]
        public long? ZIsShow { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZORDERSEQ")]
        public long? ZOrderSeq { get; set; }

        [Column("ZPOINT")]
        public long? ZPoint { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZMODIFYDATE", TypeName = "TIMESTAMP")]
        public byte[] ZModifydate { get; set; }

        [Column("ZRATE", TypeName = "FLOAT")]
        public double? ZRate { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZINSERTTYPE", TypeName = "VARCHAR")]
        public string ZInsertType { get; set; }

        [Column("ZISO", TypeName = "VARCHAR")]
        public string ZIso { get; set; }

        [Column("ZMAINISO", TypeName = "VARCHAR")]
        public string ZMainIso { get; set; }

        [Column("ZMEMO", TypeName = "VARCHAR")]
        public string ZMemo { get; set; }

        [Column("ZSYMBOL", TypeName = "VARCHAR")]
        public string ZSymbol { get; set; }

        [Column("ZSYMBOLPOSITION", TypeName = "VARCHAR")]
        public string ZSymbolPosition { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

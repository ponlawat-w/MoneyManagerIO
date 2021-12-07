using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZETC")]
    public partial class ZEtc
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZDATATYPE")]
        public long? ZDataType { get; set; }

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

        [Column("ZDATA", TypeName = "VARCHAR")]
        public string ZData { get; set; }

        [Column("ZDATAYTYPEKEY", TypeName = "VARCHAR")]
        public string ZDatayTypeKey { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }

        [Column("ZZDATA", TypeName = "VARCHAR")]
        public string ZzData { get; set; }

        [Column("ZZDATA1", TypeName = "VARCHAR")]
        public string ZzData1 { get; set; }

        [Column("ZZDATA2", TypeName = "VARCHAR")]
        public string ZzData2 { get; set; }
    }
}

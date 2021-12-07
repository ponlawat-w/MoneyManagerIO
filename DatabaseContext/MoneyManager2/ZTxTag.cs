using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZTXTAG")]
    [Index(nameof(ZTag), Name = "ZTXTAG_ZTAG_INDEX")]
    [Index(nameof(ZTx), Name = "ZTXTAG_ZTX_INDEX")]
    public partial class ZTxTag
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZTAG")]
        public long? ZTag { get; set; }

        [Column("ZTX")]
        public long? ZTx { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZTAGUID", TypeName = "VARCHAR")]
        public string ZTagUid { get; set; }

        [Column("ZTXUID", TypeName = "VARCHAR")]
        public string ZTxuUd { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

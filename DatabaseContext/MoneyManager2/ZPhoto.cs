using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZPHOTO")]
    public partial class ZPhoto
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZDEVICEID")]
        public long? ZDeviceId { get; set; }

        [Column("ZFILESIZE")]
        public long? ZFileSize { get; set; }

        [Column("ZINOUTCOMEID")]
        public long? ZInOutcomeId { get; set; }

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

        [Column("ZFILENAME", TypeName = "VARCHAR")]
        public string ZFileName { get; set; }

        [Column("ZFILEPATH", TypeName = "VARCHAR")]
        public string ZFilePath { get; set; }

        [Column("ZORGFILENAME", TypeName = "VARCHAR")]
        public string ZOrgFileName { get; set; }

        [Column("ZORGFILEPATH", TypeName = "VARCHAR")]
        public string ZOrgFilePath { get; set; }

        [Column("ZTXUID", TypeName = "VARCHAR")]
        public string ZTxUid { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

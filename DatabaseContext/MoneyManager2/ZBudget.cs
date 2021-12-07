using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZBUDGET")]
    public partial class ZBudget
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

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZORDER")]
        public long? ZOrder { get; set; }

        [Column("ZPERIODTYPEINT")]
        public long? ZPeriodTypeInt { get; set; }

        [Column("ZSYNCCHECK")]
        public long? ZSyncCheck { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZTOTALTYPEINT")]
        public long? ZTotalTypeInt { get; set; }

        [Column("ZTRANSTYPEINT")]
        public long? ZTransTypeInt { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZDAYSTR", TypeName = "VARCHAR")]
        public string ZDayStr { get; set; }

        [Column("ZDOTYPESTR", TypeName = "VARCHAR")]
        public string ZDoTypeStr { get; set; }

        [Column("ZMONEYSTR", TypeName = "VARCHAR")]
        public string ZMoneyStr { get; set; }

        [Column("ZTARGETUID", TypeName = "VARCHAR")]
        public string ZTargetUid { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZASSET")]
    public partial class ZAsset
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZCARD_ACCOUNT_ID")]
        public long? ZCardAccountId { get; set; }

        [Column("ZGROUP_ID")]
        public long? ZGroupId { get; set; }

        [Column("ZLEFTMONEY")]
        public long? ZLeftMoney { get; set; }

        [Column("ZORDER")]
        public long? ZOrder { get; set; }

        [Column("ZTYPE")]
        public long? ZType { get; set; }

        [Column("ZAID")]
        public long? ZAid { get; set; }

        [Column("ZCARD_USAGE_HURDLE_START_DATE")]
        public long? ZCardUsageHurdleStartDate { get; set; }

        [Column("ZCARD_USAGE_HURDLE_TYPE")]
        public long? ZCardUsageHurdleType { get; set; }

        [Column("ZCURRENCYID")]
        public long? ZCurrencyId { get; set; }

        [Column("ZISCARDAUTOPAY")]
        public long? ZIsCardAutoPay { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISREFLECT")]
        public long? ZIsReflect { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZSYNCCHECK")]
        public long? ZSyncCheck { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZTRANSFEREXPENSE")]
        public long? ZTransferExpense { get; set; }

        [Column("ZUTIME")]
        public long? ZUtime { get; set; }

        [Column("ZCARD_UPDATEFINDATE", TypeName = "TIMESTAMP")]
        public byte[] ZCardUpdatefindate { get; set; }

        [Column("ZCARD_UPDATEPAYDATE", TypeName = "TIMESTAMP")]
        public byte[] ZCardUpdatepaydate { get; set; }

        [Column("ZCARD_USAGE_HURDLE_AMOUNT", TypeName = "FLOAT")]
        public double? ZCardUsageHurdleAmount { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSynctime { get; set; }

        [Column("ZCARD_ACCOUNT_NAME", TypeName = "VARCHAR")]
        public string ZCardAccountName { get; set; }

        [Column("ZCARD_DAYFIN", TypeName = "VARCHAR")]
        public string ZCardDayfin { get; set; }

        [Column("ZCARD_DAYPAY", TypeName = "VARCHAR")]
        public string ZCardDaypay { get; set; }

        [Column("ZNICNAME", TypeName = "VARCHAR")]
        public string ZNicName { get; set; }

        [Column("ZCARDASSETUID", TypeName = "VARCHAR")]
        public string ZCardAssetiid { get; set; }

        [Column("ZCURRENCYUID", TypeName = "VARCHAR")]
        public string ZCurrencyUid { get; set; }

        [Column("ZGROUPUID", TypeName = "VARCHAR")]
        public string ZGroupUid { get; set; }

        [Column("ZMEMO", TypeName = "VARCHAR")]
        public string ZMemo { get; set; }

        [Column("ZMEMOTITLE", TypeName = "VARCHAR")]
        public string ZMemoTitle { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }

        [Column("ZZDATA", TypeName = "VARCHAR")]
        public string ZzData { get; set; }

        [Column("ZZDATA2", TypeName = "VARCHAR")]
        public string ZzData2 { get; set; }

        [Column("ZSMSSTRING", TypeName = "VARCHAR")]
        public string ZSmsString { get; set; }
    }
}

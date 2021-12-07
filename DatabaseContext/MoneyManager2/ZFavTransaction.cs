using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZFAVTRANSACTION")]
    public partial class ZFavTransaction
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

        [Column("ZACCOUNT_ID")]
        public long? ZAccountId { get; set; }

        [Column("ZCATEGORYID")]
        public long? ZCategoryId { get; set; }

        [Column("ZCATEGORY_ID")]
        public long? ZCategoryId1 { get; set; }

        [Column("ZCURRENCYID")]
        public long? ZCurrencyId { get; set; }

        [Column("ZDOTYPE")]
        public long? ZDoType { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZMARK")]
        public long? ZMark { get; set; }

        [Column("ZORDER")]
        public long? ZOrder { get; set; }

        [Column("ZSUBCATEGORY_ID")]
        public long? ZSubCategoryId { get; set; }

        [Column("ZSYNCCHECK")]
        public long? ZSyncCheck { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZTO_ACCOUNT_ID")]
        public long? ZToAccountId { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZAMOUNTSUB", TypeName = "FLOAT")]
        public double? ZAmountSub { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZAMOUNT_SUB", TypeName = "VARCHAR")]
        public string ZAmountSub1 { get; set; }

        [Column("ZASSETUID", TypeName = "VARCHAR")]
        public string ZAssetUid { get; set; }

        [Column("ZCATEGORYUID", TypeName = "VARCHAR")]
        public string ZCategoryUid { get; set; }

        [Column("ZCURRENCYUID", TypeName = "VARCHAR")]
        public string ZCurrencyUid { get; set; }

        [Column("ZCURRENCY_SUB", TypeName = "VARCHAR")]
        public string ZCurrencySub { get; set; }

        [Column("ZMEMO", TypeName = "VARCHAR")]
        public string ZMemo { get; set; }

        [Column("ZPAYEE", TypeName = "VARCHAR")]
        public string ZPayee { get; set; }

        [Column("ZTOASSETUID", TypeName = "VARCHAR")]
        public string ZToAssetUid { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

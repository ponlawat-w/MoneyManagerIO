using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZINOUTCOME")]
    [Index(nameof(ZAssetUid), Name = "Z_InOutCome_byAssetUid")]
    [Index(nameof(ZCategoryUid), Name = "Z_InOutCome_byCategoryUid")]
    [Index(nameof(ZCurrencyUid), Name = "Z_InOutCome_byCurrencyUid")]
    [Index(nameof(ZDate), Name = "Z_InOutCome_byDate")]
    [Index(nameof(ZDoType), Name = "Z_InOutCome_byDo_TypeIndex")]
    [Index(nameof(ZTxDateStr), Name = "Z_InOutCome_byTxDateStr")]
    [Index(nameof(ZUTime), Name = "Z_InOutCome_byUtime")]
    public partial class ZInOutcome
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZASSET_GROUP")]
        public long? ZAssetGroup { get; set; }

        [Column("ZASSET_ID")]
        public long? ZAssetId { get; set; }

        [Column("ZCATEGORY_ID")]
        public long? ZCategoryId { get; set; }

        [Column("ZOPPOSITEAID")]
        public long? ZOppositeAid { get; set; }

        [Column("ZAID")]
        public long? ZAid { get; set; }

        [Column("ZCATEGORYID")]
        public long? ZCategoryId1 { get; set; }

        [Column("ZCURRENCYID")]
        public long? ZCurrencyId { get; set; }

        [Column("ZFEE_ID")]
        public long? ZFeeId { get; set; }

        [Column("ZISDEL")]
        public long? ZIsDel { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZMARK")]
        public long? ZMark { get; set; }

        [Column("ZSYNCCHECK")]
        public long? ZSyncCheck { get; set; }

        [Column("ZSYNCVERSION")]
        public long? ZSyncVersion { get; set; }

        [Column("ZUTIME")]
        public long? ZUTime { get; set; }

        [Column("ZDATE", TypeName = "TIMESTAMP")]
        public byte[] ZDate { get; set; }

        [Column("ZAMOUNT", TypeName = "FLOAT")]
        public double? ZAmount { get; set; }

        [Column("ZAMOUNTACCOUNT", TypeName = "FLOAT")]
        public double? ZAmountAccount { get; set; }

        [Column("ZAMOUNTSUB", TypeName = "FLOAT")]
        public double? ZAmountSub { get; set; }

        [Column("ZSYNCTIME", TypeName = "TIMESTAMP")]
        public byte[] ZSyncTime { get; set; }

        [Column("ZASSET_NAME", TypeName = "VARCHAR")]
        public string ZAssetName { get; set; }

        [Column("ZASSET_NIC", TypeName = "VARCHAR")]
        public string ZAssetNic { get; set; }

        [Column("ZCARDDIVIDID", TypeName = "VARCHAR")]
        public string ZCardDividId { get; set; }

        [Column("ZCATEGORY_NAME", TypeName = "VARCHAR")]
        public string ZCategoryName { get; set; }

        [Column("ZCONTENT", TypeName = "VARCHAR")]
        public string ZContent { get; set; }

        [Column("ZDO_TYPE", TypeName = "VARCHAR")]
        public string ZDoType { get; set; }

        [Column("ZMONEY", TypeName = "VARCHAR")]
        public string ZMoney { get; set; }

        [Column("ZASSETUID", TypeName = "VARCHAR")]
        public string ZAssetUid { get; set; }

        [Column("ZCARDDIVIDEMONTH", TypeName = "VARCHAR")]
        public string ZCardDivideMonth { get; set; }

        [Column("ZCARDDIVIDEMONTHSTR", TypeName = "VARCHAR")]
        public string ZCardDivideMonthStr { get; set; }

        [Column("ZCARDDIVIDEUID", TypeName = "VARCHAR")]
        public string ZCardDivideUid { get; set; }

        [Column("ZCARDTIMESTAMPSTR", TypeName = "VARCHAR")]
        public string ZCardTimestampStr { get; set; }

        [Column("ZCATEGORYUID", TypeName = "VARCHAR")]
        public string ZCategoryUid { get; set; }

        [Column("ZCURRENCY", TypeName = "VARCHAR")]
        public string ZCurrency { get; set; }

        [Column("ZCURRENCYUID", TypeName = "VARCHAR")]
        public string ZCurrencyUid { get; set; }

        [Column("ZMEMO", TypeName = "VARCHAR")]
        public string ZMemo { get; set; }

        [Column("ZSMSORIGINE", TypeName = "VARCHAR")]
        public string ZSmsOrigine { get; set; }

        [Column("ZSMSPARSECONTENTS", TypeName = "VARCHAR")]
        public string ZSmsParseContents { get; set; }

        [Column("ZTOASSETUID", TypeName = "VARCHAR")]
        public string ZToAssetUid { get; set; }

        [Column("ZTXDATESTR", TypeName = "VARCHAR")]
        public string ZTxDateStr { get; set; }

        [Column("ZTXUIDFEE", TypeName = "VARCHAR")]
        public string ZTxUidFee { get; set; }

        [Column("ZTXUIDTRANS", TypeName = "VARCHAR")]
        public string ZTxUidTrans { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }

        [Column("ZZDATA1", TypeName = "VARCHAR")]
        public string ZzData1 { get; set; }

        [Column("ZZDATA2", TypeName = "VARCHAR")]
        public string ZzData2 { get; set; }

    }
}

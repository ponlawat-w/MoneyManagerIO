using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZMESSAGEMACRO")]
    public partial class ZMessageMacro
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZCONASSETGROUPID")]
        public long? ZConAssetGroupId { get; set; }

        [Column("ZCONASSETID")]
        public long? ZConassetId { get; set; }

        [Column("ZCONTENTNUM")]
        public long? ZContentNum { get; set; }

        [Column("ZMACROTYPE")]
        public long? ZMacroType { get; set; }

        [Column("ZAID")]
        public long? ZAid { get; set; }

        [Column("ZORDERSEQ")]
        public long? ZOrderSeq { get; set; }

        [Column("ZDAYCALC", TypeName = "TIMESTAMP")]
        public byte[] ZDayCalc { get; set; }

        [Column("ZDAYSUM", TypeName = "TIMESTAMP")]
        public byte[] ZDaySum { get; set; }

        [Column("ZCONASSETNAME", TypeName = "VARCHAR")]
        public string ZConAssetName { get; set; }

        [Column("ZCONTENTSEPERATE", TypeName = "VARCHAR")]
        public string ZContentSeperate { get; set; }

        [Column("ZMACROASSETNAME", TypeName = "VARCHAR")]
        public string ZMacroAssetName { get; set; }

        [Column("ZMACROASSETTYPE", TypeName = "VARCHAR")]
        public string ZMacroAssetType { get; set; }

        [Column("ZMACRODIVID", TypeName = "VARCHAR")]
        public string ZMacroDivId { get; set; }

        [Column("ZMODIDATE", TypeName = "VARCHAR")]
        public string ZModidate { get; set; }

        [Column("ZMONEYDIVID", TypeName = "VARCHAR")]
        public string ZMoneyDivId { get; set; }

        [Column("ZMONTHDIVID", TypeName = "VARCHAR")]
        public string ZMonthDivId { get; set; }

        [Column("ZNAMENIC", TypeName = "VARCHAR")]
        public string ZNameNic { get; set; }

        [Column("ZNUMBANK", TypeName = "VARCHAR")]
        public string ZNumBank { get; set; }

        [Column("ZNUMMONEY", TypeName = "VARCHAR")]
        public string ZNumMoney { get; set; }

        [Column("ZNUMMONTH", TypeName = "VARCHAR")]
        public string ZNumMonth { get; set; }

        [Column("ZNUMMONTHFUNC", TypeName = "VARCHAR")]
        public string ZNumMonthFunc { get; set; }

        [Column("ZORDER", TypeName = "VARCHAR")]
        public string ZOrder { get; set; }

        [Column("ZCONASSETUID", TypeName = "VARCHAR")]
        public string ZConAssetUid { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("ZMESSAGEMACRO2")]
    [Index(nameof(ZSmsTel), Name = "Z_MessageMacro2_bySmsTel")]
    public partial class ZMessageMacro2
    {
        [Key]
        [Column("Z_PK")]
        public long ZPk { get; set; }

        [Column("Z_ENT")]
        public long? ZEnt { get; set; }

        [Column("Z_OPT")]
        public long? ZOpt { get; set; }

        [Column("ZISSYNCED")]
        public long? ZIsSynced { get; set; }

        [Column("ZMACROTYPE")]
        public long? ZMacroType { get; set; }

        [Column("ZORDERSEQ")]
        public long? ZOrderSeq { get; set; }

        [Column("ZUTIME")]
        public long? ZUtime { get; set; }

        [Column("ZAPPNAME", TypeName = "VARCHAR")]
        public string ZAppName { get; set; }

        [Column("ZAPPPACKAGE", TypeName = "VARCHAR")]
        public string ZAppPackage { get; set; }

        [Column("ZCONASSETUID", TypeName = "VARCHAR")]
        public string ZConAssetUid { get; set; }

        [Column("ZMACROASSETNAME", TypeName = "VARCHAR")]
        public string ZMacroAssetName { get; set; }

        [Column("ZMODIDATE", TypeName = "VARCHAR")]
        public string ZModiDate { get; set; }

        [Column("ZSMSTEL", TypeName = "VARCHAR")]
        public string ZSmsTel { get; set; }

        [Column("ZUID", TypeName = "VARCHAR")]
        public string ZUid { get; set; }

        [Column("ZUSEYN", TypeName = "VARCHAR")]
        public string ZUseYn { get; set; }
    }
}

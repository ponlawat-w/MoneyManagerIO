using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("Z_METADATA")]
    public partial class ZMetadatum
    {
        [Key]
        [Column("Z_VERSION")]
        public long ZVersion { get; set; }

        [Column("Z_UUID", TypeName = "VARCHAR(255)")]
        public string ZUuid { get; set; }

        [Column("Z_PLIST")]
        public byte[] ZPlist { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Table("Z_PRIMARYKEY")]
    public partial class ZPrimarykey
    {
        [Key]
        [Column("Z_ENT")]
        public long ZEnt { get; set; }

        [Column("Z_NAME", TypeName = "VARCHAR")]
        public string ZName { get; set; }

        [Column("Z_SUPER")]
        public long? ZSuper { get; set; }

        [Column("Z_MAX")]
        public long? ZMax { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    [Keyless]
    [Table("Z_MODELCACHE")]
    public partial class ZModelCache
    {
        [Column("Z_CONTENT")]
        public byte[] ZContent { get; set; }
    }
}

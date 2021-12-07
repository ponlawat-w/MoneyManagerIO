using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MoneyManagerIO.DatabaseContext.MoneyManager2
{
    public partial class MoneyManager2DbContext : DbContext
    {
        private string _dbPath;

        public MoneyManager2DbContext(string dbPath)
        {
            _dbPath = dbPath;
        }

        public MoneyManager2DbContext(DbContextOptions<MoneyManager2DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ZMetadatum> ZMetaData { get; set; }
        public virtual DbSet<ZModelCache> ZModelCaches { get; set; }
        public virtual DbSet<ZPrimarykey> ZPrimaryKeys { get; set; }
        public virtual DbSet<ZAsset> ZAssets { get; set; }
        public virtual DbSet<ZAssetGroup> ZAssetGroups { get; set; }
        public virtual DbSet<ZBudget> ZBudgets { get; set; }
        public virtual DbSet<ZBudgetAmount> ZBudgetAmounts { get; set; }
        public virtual DbSet<ZCategory> ZCategories { get; set; }
        public virtual DbSet<ZCurrency> ZCurrencies { get; set; }
        public virtual DbSet<ZEtc> ZEtcs { get; set; }
        public virtual DbSet<ZFavTransaction> ZFavTransactions { get; set; }
        public virtual DbSet<ZInOutcome> ZInOutcomes { get; set; }
        public virtual DbSet<ZMemo> ZMemos { get; set; }
        public virtual DbSet<ZMessageMacro> ZMessageMacros { get; set; }
        public virtual DbSet<ZMessageMacro2> ZMessageMacros2 { get; set; }
        public virtual DbSet<ZPhoto> ZPhotos { get; set; }
        public virtual DbSet<ZProperty> ZProperties { get; set; }
        public virtual DbSet<ZRepeatTransaction> ZRepeatTransactions { get; set; }
        public virtual DbSet<ZTag> ZTags { get; set; }
        public virtual DbSet<ZTxTag> ZTxTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"DataSource={_dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZMetadatum>(entity =>
            {
                entity.Property(e => e.ZVersion).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZPrimarykey>(entity =>
            {
                entity.Property(e => e.ZEnt).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZAsset>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZAssetGroup>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZBudget>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZBudgetAmount>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZCategory>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZCurrency>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZEtc>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZFavTransaction>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZInOutcome>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZMemo>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZMessageMacro>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZMessageMacro2>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZPhoto>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZProperty>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZRepeatTransaction>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZTag>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            modelBuilder.Entity<ZTxTag>(entity =>
            {
                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;
using InfoBarDBGenerator.InfoBar.Models;

namespace InfoBarDBGenerator.InfoBar.Data
{
    public partial class InfoBarContext : DbContext
    {
        public InfoBarContext()
        {
        }

        public InfoBarContext(DbContextOptions<InfoBarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Monster> Monsters { get; set; }
        public virtual DbSet<Npc> Npcs { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=database.db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Monster>(entity =>
            {
                entity.ToTable("monster");

                entity.HasKey(e => e.Id);

                entity.HasIndex(e => e.Name)
                    .HasName("monster__name");

                entity.HasIndex(e => new { e.Zone, e.Name, e.Id })
                    .HasName("monster__zone__name");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.AllakhazamId).HasColumnName("allakhazam_id");

                entity.Property(e => e.AtlasId).HasColumnName("atlas_id");

                entity.Property(e => e.DetectsHealing).HasColumnName("detects_healing").HasDefaultValue(false);

                entity.Property(e => e.DetectsLowhp).HasColumnName("detects_lowhp").HasDefaultValue(false);

                entity.Property(e => e.DetectsMagic).HasColumnName("detects_magic").HasDefaultValue(false);

                entity.Property(e => e.DetectsSight).HasColumnName("detects_sight").HasDefaultValue(false);

                entity.Property(e => e.DetectsSound).HasColumnName("detects_sound").HasDefaultValue(false);

                entity.Property(e => e.DetectsTruesight).HasColumnName("detects_truesight").HasDefaultValue(false);

                entity.Property(e => e.DetectsTruesound).HasColumnName("detects_truesound").HasDefaultValue(false);

                entity.Property(e => e.Drops).HasColumnName("drops");

                entity.Property(e => e.Family).HasColumnName("family");

                entity.Property(e => e.FfxiclopediaId).HasColumnName("ffxiclopedia_id");

                entity.Property(e => e.Immunities).HasColumnName("immunities");

                entity.Property(e => e.IsAggressive).HasColumnName("is_aggressive").HasDefaultValue(false);

                entity.Property(e => e.IsFishing).HasColumnName("is_fishing").HasDefaultValue(false);

                entity.Property(e => e.IsLinking).HasColumnName("is_linking").HasDefaultValue(false);

                entity.Property(e => e.IsNm).HasColumnName("is_nm").HasDefaultValue(false);

                entity.Property(e => e.Job).HasColumnName("job");

                entity.Property(e => e.LevelMax).HasColumnName("level_max");

                entity.Property(e => e.LevelMin).HasColumnName("level_min");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Resistances).HasColumnName("resistances");

                entity.Property(e => e.SomepageId).HasColumnName("somepage_id");

                entity.Property(e => e.SpawnCount)
                    .HasColumnName("spawn_count");

                entity.Property(e => e.SpawnTime).HasColumnName("spawn_time");

                entity.Property(e => e.Stolen).HasColumnName("stolen");

                entity.Property(e => e.TracksScent).HasColumnName("tracks_scent").HasDefaultValue(false);

                entity.Property(e => e.Weaknesses).HasColumnName("weaknesses");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<Npc>(entity =>
            {
                entity.ToTable("npc");

                entity.HasIndex(e => new { e.Zone, e.Name, e.Id })
                    .HasName("npc__zone__name");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Family).HasColumnName("family");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");

                entity.HasIndex(e => new { e.Zone, e.Name, e.Id })
                    .HasName("player__zone__name");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Family).HasColumnName("family");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("zone");
            });
        }
    }
}

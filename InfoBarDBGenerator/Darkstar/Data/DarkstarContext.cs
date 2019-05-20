using Microsoft.EntityFrameworkCore;
using InfoBarDBGenerator.Darkstar.Models;

namespace InfoBarDBGenerator.Darkstar.Data
{
    public partial class DarkstarContext : DbContext
    {
        public DarkstarContext()
        {
        }

        public DarkstarContext(DbContextOptions<DarkstarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abilities> Abilities { get; set; }
        public virtual DbSet<AbilitiesCharges> AbilitiesCharges { get; set; }
        public virtual DbSet<AccountIpRecord> AccountIpRecord { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsBanned> AccountsBanned { get; set; }
        public virtual DbSet<AccountsParties> AccountsParties { get; set; }
        public virtual DbSet<AccountsSessions> AccountsSessions { get; set; }
        public virtual DbSet<AuctionHouse> AuctionHouse { get; set; }
        public virtual DbSet<AuditChat> AuditChat { get; set; }
        public virtual DbSet<AuditGm> AuditGm { get; set; }
        public virtual DbSet<Augments> Augments { get; set; }
        public virtual DbSet<AutomatonSpells> AutomatonSpells { get; set; }
        public virtual DbSet<BcnmBattlefield> BcnmBattlefield { get; set; }
        public virtual DbSet<BcnmInfo> BcnmInfo { get; set; }
        public virtual DbSet<BcnmLoot> BcnmLoot { get; set; }
        public virtual DbSet<BcnmTreasureChests> BcnmTreasureChests { get; set; }
        public virtual DbSet<BlueSpellList> BlueSpellList { get; set; }
        public virtual DbSet<BlueSpellMods> BlueSpellMods { get; set; }
        public virtual DbSet<BlueTraits> BlueTraits { get; set; }
        public virtual DbSet<CharBlacklist> CharBlacklist { get; set; }
        public virtual DbSet<CharEffects> CharEffects { get; set; }
        public virtual DbSet<CharEquip> CharEquip { get; set; }
        public virtual DbSet<CharExp> CharExp { get; set; }
        public virtual DbSet<CharInventory> CharInventory { get; set; }
        public virtual DbSet<CharJobs> CharJobs { get; set; }
        public virtual DbSet<CharLook> CharLook { get; set; }
        public virtual DbSet<CharMerit> CharMerit { get; set; }
        public virtual DbSet<CharPet> CharPet { get; set; }
        public virtual DbSet<CharPoints> CharPoints { get; set; }
        public virtual DbSet<CharProfile> CharProfile { get; set; }
        public virtual DbSet<CharRecast> CharRecast { get; set; }
        public virtual DbSet<CharSkills> CharSkills { get; set; }
        public virtual DbSet<CharSpells> CharSpells { get; set; }
        public virtual DbSet<CharStats> CharStats { get; set; }
        public virtual DbSet<CharStorage> CharStorage { get; set; }
        public virtual DbSet<CharStyle> CharStyle { get; set; }
        public virtual DbSet<CharUnlocks> CharUnlocks { get; set; }
        public virtual DbSet<CharVars> CharVars { get; set; }
        public virtual DbSet<Chars> Chars { get; set; }
        public virtual DbSet<ConquestSystem> ConquestSystem { get; set; }
        public virtual DbSet<DeliveryBox> DeliveryBox { get; set; }
        public virtual DbSet<DespoilEffects> DespoilEffects { get; set; }
        public virtual DbSet<ExpBase> ExpBase { get; set; }
        public virtual DbSet<ExpTable> ExpTable { get; set; }
        public virtual DbSet<FishingFish> FishingFish { get; set; }
        public virtual DbSet<FishingLure> FishingLure { get; set; }
        public virtual DbSet<FishingRod> FishingRod { get; set; }
        public virtual DbSet<FishingZone> FishingZone { get; set; }
        public virtual DbSet<GuildItemPoints> GuildItemPoints { get; set; }
        public virtual DbSet<GuildShops> GuildShops { get; set; }
        public virtual DbSet<Guilds> Guilds { get; set; }
        public virtual DbSet<InstanceEntities> InstanceEntities { get; set; }
        public virtual DbSet<InstanceList> InstanceList { get; set; }
        public virtual DbSet<ItemArmor> ItemArmor { get; set; }
        public virtual DbSet<ItemBasic> ItemBasic { get; set; }
        public virtual DbSet<ItemFurnishing> ItemFurnishing { get; set; }
        public virtual DbSet<ItemLatents> ItemLatents { get; set; }
        public virtual DbSet<ItemMods> ItemMods { get; set; }
        public virtual DbSet<ItemModsPet> ItemModsPet { get; set; }
        public virtual DbSet<ItemPuppet> ItemPuppet { get; set; }
        public virtual DbSet<ItemUsable> ItemUsable { get; set; }
        public virtual DbSet<ItemWeapon> ItemWeapon { get; set; }
        public virtual DbSet<JobPoints> JobPoints { get; set; }
        public virtual DbSet<Linkshells> Linkshells { get; set; }
        public virtual DbSet<Merits> Merits { get; set; }
        public virtual DbSet<MobDroplist> MobDroplist { get; set; }
        public virtual DbSet<MobFamilyMods> MobFamilyMods { get; set; }
        public virtual DbSet<MobFamilySystem> MobFamilySystem { get; set; }
        public virtual DbSet<MobGroups> MobGroups { get; set; }
        public virtual DbSet<MobPets> MobPets { get; set; }
        public virtual DbSet<MobPoolMods> MobPoolMods { get; set; }
        public virtual DbSet<MobPools> MobPools { get; set; }
        public virtual DbSet<MobSkillLists> MobSkillLists { get; set; }
        public virtual DbSet<MobSkills> MobSkills { get; set; }
        public virtual DbSet<MobSpawnMods> MobSpawnMods { get; set; }
        public virtual DbSet<MobSpawnPoints> MobSpawnPoints { get; set; }
        public virtual DbSet<MobSpellLists> MobSpellLists { get; set; }
        public virtual DbSet<NmSpawnPoints> NmSpawnPoints { get; set; }
        public virtual DbSet<NpcList> NpcList { get; set; }
        public virtual DbSet<PetList> PetList { get; set; }
        public virtual DbSet<PetName> PetName { get; set; }
        public virtual DbSet<ServerVariables> ServerVariables { get; set; }
        public virtual DbSet<SkillCaps> SkillCaps { get; set; }
        public virtual DbSet<SkillRanks> SkillRanks { get; set; }
        public virtual DbSet<SkillchainDamageModifiers> SkillchainDamageModifiers { get; set; }
        public virtual DbSet<SpellList> SpellList { get; set; }
        public virtual DbSet<StatusEffects> StatusEffects { get; set; }
        public virtual DbSet<SynthRecipes> SynthRecipes { get; set; }
        public virtual DbSet<Traits> Traits { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<WaterPoints> WaterPoints { get; set; }
        public virtual DbSet<WeaponSkills> WeaponSkills { get; set; }
        public virtual DbSet<ZoneSettings> ZoneSettings { get; set; }
        public virtual DbSet<ZoneWeather> ZoneWeather { get; set; }
        public virtual DbSet<Zonelines> Zonelines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=root;database=dspdb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Abilities>(entity =>
            {
                entity.HasKey(e => e.AbilityId);

                entity.ToTable("abilities", "dspdb");

                entity.Property(e => e.AbilityId)
                    .HasColumnName("abilityId")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionType)
                    .HasColumnName("actionType")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.AddType)
                    .HasColumnName("addType")
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Animation)
                    .HasColumnName("animation")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimationTime)
                    .HasColumnName("animationTime")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CastTime)
                    .HasColumnName("castTime")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ce)
                    .HasColumnName("CE")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentTag)
                    .HasColumnName("content_tag")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IsAoe)
                    .HasColumnName("isAOE")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MeritModId)
                    .HasColumnName("meritModID")
                    .HasColumnType("smallint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message1)
                    .HasColumnName("message1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message2)
                    .HasColumnName("message2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("float(3,1) unsigned")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.RecastId)
                    .HasColumnName("recastId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecastTime)
                    .HasColumnName("recastTime")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValidTarget)
                    .HasColumnName("validTarget")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ve)
                    .HasColumnName("VE")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AbilitiesCharges>(entity =>
            {
                entity.HasKey(e => new { e.RecastId, e.Job, e.Level });

                entity.ToTable("abilities_charges", "dspdb");

                entity.Property(e => e.RecastId)
                    .HasColumnName("recastId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.ChargeTime)
                    .HasColumnName("chargeTime")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxCharges)
                    .HasColumnName("maxCharges")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MeritModId)
                    .HasColumnName("meritModID")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AccountIpRecord>(entity =>
            {
                entity.HasKey(e => new { e.LoginTime, e.Accid });

                entity.ToTable("account_ip_record", "dspdb");

                entity.Property(e => e.LoginTime)
                    .HasColumnName("login_time")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Accid)
                    .HasColumnName("accid")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("client_ip")
                    .HasColumnType("tinytext");
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.ToTable("accounts", "dspdb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentIds)
                    .HasColumnName("content_ids")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("16");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .IsRequired()
                    .HasColumnName("email2")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Expansions)
                    .HasColumnName("expansions")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("4094");

                entity.Property(e => e.Features)
                    .HasColumnName("features")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("13");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Priv)
                    .HasColumnName("priv")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Timecreate)
                    .HasColumnName("timecreate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Timelastmodify)
                    .HasColumnName("timelastmodify")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<AccountsBanned>(entity =>
            {
                entity.HasKey(e => e.Accid);

                entity.ToTable("accounts_banned", "dspdb");

                entity.Property(e => e.Accid)
                    .HasColumnName("accid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Banncomment)
                    .HasColumnName("banncomment")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Timebann)
                    .HasColumnName("timebann")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Timeunbann)
                    .HasColumnName("timeunbann")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<AccountsParties>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("accounts_parties", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Allianceid)
                    .HasColumnName("allianceid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Partyflag)
                    .HasColumnName("partyflag")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Partyid)
                    .HasColumnName("partyid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Char)
                    .WithOne(p => p.AccountsParties)
                    .HasForeignKey<AccountsParties>(d => d.Charid)
                    .HasConstraintName("accounts_parties_ibfk_1");
            });

            modelBuilder.Entity<AccountsSessions>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("accounts_sessions", "dspdb");

                entity.HasIndex(e => e.Accid)
                    .HasName("accid")
                    .IsUnique();

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Accid)
                    .HasColumnName("accid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClientAddr)
                    .HasColumnName("client_addr")
                    .HasColumnType("int(10) unsigned zerofill")
                    .HasDefaultValueSql("0000000000");

                entity.Property(e => e.ClientPort)
                    .HasColumnName("client_port")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linkshellid1)
                    .HasColumnName("linkshellid1")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linkshellid2)
                    .HasColumnName("linkshellid2")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linkshellrank1)
                    .HasColumnName("linkshellrank1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linkshellrank2)
                    .HasColumnName("linkshellrank2")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerAddr)
                    .HasColumnName("server_addr")
                    .HasColumnType("int(10) unsigned zerofill")
                    .HasDefaultValueSql("0000000000");

                entity.Property(e => e.ServerPort)
                    .HasColumnName("server_port")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SessionKey)
                    .IsRequired()
                    .HasColumnName("session_key")
                    .HasColumnType("binary(20)")
                    .HasDefaultValueSql("                    ");

                entity.Property(e => e.Targid)
                    .HasColumnName("targid")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VersionMismatch)
                    .HasColumnName("version_mismatch")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AuctionHouse>(entity =>
            {
                entity.ToTable("auction_house", "dspdb");

                entity.HasIndex(e => e.Itemid)
                    .HasName("itemid");

                entity.HasIndex(e => e.Seller)
                    .HasName("charid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BuyerName)
                    .HasColumnName("buyer_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sale)
                    .HasColumnName("sale")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SellDate)
                    .HasColumnName("sell_date")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Seller)
                    .HasColumnName("seller")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SellerName)
                    .HasColumnName("seller_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Stack)
                    .HasColumnName("stack")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AuditChat>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("audit_chat", "dspdb");

                entity.Property(e => e.LineId)
                    .HasColumnName("lineID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.LsName)
                    .HasColumnName("lsName")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("blob");

                entity.Property(e => e.Recipient)
                    .HasColumnName("recipient")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Speaker)
                    .IsRequired()
                    .HasColumnName("speaker")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("tinytext");
            });

            modelBuilder.Entity<AuditGm>(entity =>
            {
                entity.HasKey(e => new { e.DateTime, e.GmName });

                entity.ToTable("audit_gm", "dspdb");

                entity.Property(e => e.DateTime).HasColumnName("date_time");

                entity.Property(e => e.GmName)
                    .HasColumnName("gm_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Command)
                    .IsRequired()
                    .HasColumnName("command")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FullString)
                    .IsRequired()
                    .HasColumnName("full_string")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Augments>(entity =>
            {
                entity.HasKey(e => new { e.AugmentId, e.Multiplier, e.ModId, e.IsPet, e.PetType });

                entity.ToTable("augments", "dspdb");

                entity.Property(e => e.AugmentId)
                    .HasColumnName("augmentId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Multiplier)
                    .HasColumnName("multiplier")
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModId)
                    .HasColumnName("modId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPet)
                    .HasColumnName("isPet")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetType)
                    .HasColumnName("petType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AutomatonSpells>(entity =>
            {
                entity.HasKey(e => e.Spellid);

                entity.ToTable("automaton_spells", "dspdb");

                entity.Property(e => e.Spellid)
                    .HasColumnName("spellid")
                    .HasColumnType("smallint(4) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Enfeeble)
                    .HasColumnName("enfeeble")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Heads)
                    .HasColumnName("heads")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Immunity)
                    .HasColumnName("immunity")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Removes)
                    .HasColumnName("removes")
                    .HasColumnType("int(6) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skilllevel)
                    .HasColumnName("skilllevel")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BcnmBattlefield>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("bcnm_battlefield", "dspdb");

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.BattlefieldNumber)
                    .HasColumnName("battlefieldNumber")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.BcnmId)
                    .HasColumnName("bcnmId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Conditions)
                    .HasColumnName("conditions")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MonsterId)
                    .HasColumnName("monsterId")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<BcnmInfo>(entity =>
            {
                entity.HasKey(e => e.BcnmId);

                entity.ToTable("bcnm_info", "dspdb");

                entity.Property(e => e.BcnmId)
                    .HasColumnName("bcnmId")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.FastestName)
                    .HasColumnName("fastestName")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Not Set!");

                entity.Property(e => e.FastestPartySize)
                    .HasColumnName("fastestPartySize")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FastestTime)
                    .HasColumnName("fastestTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsMission)
                    .HasColumnName("isMission")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LevelCap)
                    .HasColumnName("levelCap")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("75");

                entity.Property(e => e.LootDropId)
                    .HasColumnName("lootDropId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PartySize)
                    .HasColumnName("partySize")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.Rules)
                    .HasColumnName("rules")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeLimit)
                    .HasColumnName("timeLimit")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("1800");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneId")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BcnmLoot>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("bcnm_loot", "dspdb");

                entity.HasIndex(e => e.LootDropId)
                    .HasName("LootDropId");

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LootDropId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LootGroupId)
                    .HasColumnName("lootGroupId")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rolls)
                    .HasColumnName("rolls")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BcnmTreasureChests>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("bcnm_treasure_chests", "dspdb");

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.BattlefieldNumber)
                    .HasColumnName("battlefieldNumber")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.BcnmId)
                    .HasColumnName("bcnmId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.NpcId)
                    .HasColumnName("npcId")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<BlueSpellList>(entity =>
            {
                entity.HasKey(e => new { e.Spellid, e.MobSkillId });

                entity.ToTable("blue_spell_list", "dspdb");

                entity.Property(e => e.Spellid)
                    .HasColumnName("spellid")
                    .HasColumnType("smallint(3)");

                entity.Property(e => e.MobSkillId)
                    .HasColumnName("mob_skill_id")
                    .HasColumnType("smallint(4) unsigned");

                entity.Property(e => e.PrimarySc)
                    .HasColumnName("primary_sc")
                    .HasColumnType("smallint(2)");

                entity.Property(e => e.SecondarySc)
                    .HasColumnName("secondary_sc")
                    .HasColumnType("smallint(2)");

                entity.Property(e => e.SetPoints)
                    .HasColumnName("set_points")
                    .HasColumnType("smallint(2)");

                entity.Property(e => e.TraitCategory)
                    .HasColumnName("trait_category")
                    .HasColumnType("smallint(2)");

                entity.Property(e => e.TraitCategoryWeight)
                    .HasColumnName("trait_category_weight")
                    .HasColumnType("smallint(2)");
            });

            modelBuilder.Entity<BlueSpellMods>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.Modid });

                entity.ToTable("blue_spell_mods", "dspdb");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spellId")
                    .HasColumnType("smallint(3) unsigned");

                entity.Property(e => e.Modid)
                    .HasColumnName("modid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BlueTraits>(entity =>
            {
                entity.HasKey(e => new { e.TraitCategory, e.TraitPointsNeeded, e.Modifier });

                entity.ToTable("blue_traits", "dspdb");

                entity.Property(e => e.TraitCategory)
                    .HasColumnName("trait_category")
                    .HasColumnType("smallint(2) unsigned");

                entity.Property(e => e.TraitPointsNeeded)
                    .HasColumnName("trait_points_needed")
                    .HasColumnType("smallint(2) unsigned");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Traitid)
                    .HasColumnName("traitid")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<CharBlacklist>(entity =>
            {
                entity.HasKey(e => new { e.CharidOwner, e.CharidTarget });

                entity.ToTable("char_blacklist", "dspdb");

                entity.Property(e => e.CharidOwner)
                    .HasColumnName("charid_owner")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CharidTarget)
                    .HasColumnName("charid_target")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CharEffects>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("char_effects", "dspdb");

                entity.HasIndex(e => e.Charid)
                    .HasName("charid");

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Effectid)
                    .HasColumnName("effectid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Power)
                    .HasColumnName("power")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subid)
                    .HasColumnName("subid")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subpower)
                    .HasColumnName("subpower")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tick)
                    .HasColumnName("tick")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tier)
                    .HasColumnName("tier")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharEquip>(entity =>
            {
                entity.HasKey(e => new { e.Charid, e.Equipslotid });

                entity.ToTable("char_equip", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Equipslotid)
                    .HasColumnName("equipslotid")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Containerid)
                    .HasColumnName("containerid")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slotid)
                    .HasColumnName("slotid")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharExp>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_exp", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Blm)
                    .HasColumnName("blm")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blu)
                    .HasColumnName("blu")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Brd)
                    .HasColumnName("brd")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bst)
                    .HasColumnName("bst")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dnc)
                    .HasColumnName("dnc")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Drg)
                    .HasColumnName("drg")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Drk)
                    .HasColumnName("drk")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geo)
                    .HasColumnName("geo")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Limits)
                    .HasColumnName("limits")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Merits)
                    .HasColumnName("merits")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mnk)
                    .HasColumnName("mnk")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mode)
                    .HasColumnName("mode")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nin)
                    .HasColumnName("nin")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pld)
                    .HasColumnName("pld")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pup)
                    .HasColumnName("pup")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rdm)
                    .HasColumnName("rdm")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rng)
                    .HasColumnName("rng")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Run)
                    .HasColumnName("run")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sam)
                    .HasColumnName("sam")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sch)
                    .HasColumnName("sch")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Smn)
                    .HasColumnName("smn")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Thf)
                    .HasColumnName("thf")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.War)
                    .HasColumnName("war")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Whm)
                    .HasColumnName("whm")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharInventory>(entity =>
            {
                entity.HasKey(e => new { e.Charid, e.Location, e.Slot });

                entity.ToTable("char_inventory", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bazaar)
                    .HasColumnName("bazaar")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Extra)
                    .HasColumnName("extra")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("65535");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasColumnName("signature")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CharJobs>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_jobs", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Blm)
                    .HasColumnName("blm")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Blu)
                    .HasColumnName("blu")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Brd)
                    .HasColumnName("brd")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bst)
                    .HasColumnName("bst")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dnc)
                    .HasColumnName("dnc")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Drg)
                    .HasColumnName("drg")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Drk)
                    .HasColumnName("drk")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Genkai)
                    .HasColumnName("genkai")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.Geo)
                    .HasColumnName("geo")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mnk)
                    .HasColumnName("mnk")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Nin)
                    .HasColumnName("nin")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pld)
                    .HasColumnName("pld")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pup)
                    .HasColumnName("pup")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rdm)
                    .HasColumnName("rdm")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Rng)
                    .HasColumnName("rng")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Run)
                    .HasColumnName("run")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sam)
                    .HasColumnName("sam")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sch)
                    .HasColumnName("sch")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Smn)
                    .HasColumnName("smn")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Thf)
                    .HasColumnName("thf")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Unlocked)
                    .HasColumnName("unlocked")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("126");

                entity.Property(e => e.War)
                    .HasColumnName("war")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Whm)
                    .HasColumnName("whm")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CharLook>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_look", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.Face)
                    .HasColumnName("face")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Feet)
                    .HasColumnName("feet")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.Hands)
                    .HasColumnName("hands")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.Head)
                    .HasColumnName("head")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Legs)
                    .HasColumnName("legs")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.Main)
                    .HasColumnName("main")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ranged)
                    .HasColumnName("ranged")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sub)
                    .HasColumnName("sub")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharMerit>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("char_merit", "dspdb");

                entity.HasIndex(e => e.Charid)
                    .HasName("char_merits_charid_index");

                entity.HasIndex(e => new { e.Meritid, e.Charid })
                    .HasName("idx_char_merit_meritid_charid")
                    .IsUnique();

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Meritid)
                    .HasColumnName("meritid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Upgrades)
                    .HasColumnName("upgrades")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<CharPet>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_pet", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adventuringfellowid)
                    .HasColumnName("adventuringfellowid")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Automatonid)
                    .HasColumnName("automatonid")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Chocoboid)
                    .HasColumnName("chocoboid")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EquippedAttachments)
                    .HasColumnName("equipped_attachments")
                    .HasColumnType("blob");

                entity.Property(e => e.UnlockedAttachments)
                    .HasColumnName("unlocked_attachments")
                    .HasColumnType("blob");

                entity.Property(e => e.Wyvernid)
                    .HasColumnName("wyvernid")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharPoints>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_points", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlliedNotes)
                    .HasColumnName("allied_notes")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AncientBeastcoin)
                    .HasColumnName("ancient_beastcoin")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BallistaPoint)
                    .HasColumnName("ballista_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BastokCp)
                    .HasColumnName("bastok_cp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bayld)
                    .HasColumnName("bayld")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BeastmanSeal)
                    .HasColumnName("beastman_seal")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CavePoints)
                    .HasColumnName("cave_points")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChocobuckBastok)
                    .HasColumnName("chocobuck_bastok")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChocobuckSandoria)
                    .HasColumnName("chocobuck_sandoria")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChocobuckWindurst)
                    .HasColumnName("chocobuck_windurst")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cinder)
                    .HasColumnName("cinder")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cruor)
                    .HasColumnName("cruor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DarkFewell)
                    .HasColumnName("dark_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DominionNote)
                    .HasColumnName("dominion_note")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EarthFewell)
                    .HasColumnName("earth_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FellowPoint)
                    .HasColumnName("fellow_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FifthEchelonTrophy)
                    .HasColumnName("fifth_echelon_trophy")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FireFewell)
                    .HasColumnName("fire_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FirstEchelonTrophy)
                    .HasColumnName("first_echelon_trophy")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FourthEchelonTrophy)
                    .HasColumnName("fourth_echelon_trophy")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildAlchemy)
                    .HasColumnName("guild_alchemy")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildBonecraft)
                    .HasColumnName("guild_bonecraft")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildCooking)
                    .HasColumnName("guild_cooking")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildFishing)
                    .HasColumnName("guild_fishing")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildGoldsmithing)
                    .HasColumnName("guild_goldsmithing")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildLeathercraft)
                    .HasColumnName("guild_leathercraft")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildSmithing)
                    .HasColumnName("guild_smithing")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildWeaving)
                    .HasColumnName("guild_weaving")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GuildWoodworking)
                    .HasColumnName("guild_woodworking")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HighKindredCrest)
                    .HasColumnName("high_kindred_crest")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IceFewell)
                    .HasColumnName("ice_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdTags)
                    .HasColumnName("id_tags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IlrusiAssaultPoint)
                    .HasColumnName("ilrusi_assault_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImperialStanding)
                    .HasColumnName("imperial_standing")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Imprimaturs)
                    .HasColumnName("imprimaturs")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Infamy)
                    .HasColumnName("infamy")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Jetton)
                    .HasColumnName("jetton")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KindredCrest)
                    .HasColumnName("kindred_crest")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KindredSeal)
                    .HasColumnName("kindred_seal")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KineticUnit)
                    .HasColumnName("kinetic_unit")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KupofriedCorundums)
                    .HasColumnName("kupofried_corundums")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LebondoptWing)
                    .HasColumnName("lebondopt_wing")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LebrosAssaultPoint)
                    .HasColumnName("lebros_assault_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LegionPoint)
                    .HasColumnName("legion_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LeujaoamAssaultPoint)
                    .HasColumnName("leujaoam_assault_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightFewell)
                    .HasColumnName("light_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LightningFewell)
                    .HasColumnName("lightning_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MamoolAssaultPoint)
                    .HasColumnName("mamool_assault_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MoblinMarble)
                    .HasColumnName("moblin_marble")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MorionWorm)
                    .HasColumnName("morion_worm")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MweyaPlasm)
                    .HasColumnName("mweya_plasm")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NyzulIsleAssaultPoint)
                    .HasColumnName("nyzul_isle_assault_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObsidianFragment)
                    .HasColumnName("obsidian_fragment")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OpCredits)
                    .HasColumnName("op_credits")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PeriqiaAssaultPoint)
                    .HasColumnName("periqia_assault_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhantomWorm)
                    .HasColumnName("phantom_worm")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PheromoneSacks)
                    .HasColumnName("pheromone_sacks")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prestige)
                    .HasColumnName("prestige")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PulchridoptWing)
                    .HasColumnName("pulchridopt_wing")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResearchMark)
                    .HasColumnName("research_mark")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResistanceCredit)
                    .HasColumnName("resistance_credit")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SacredKindredCrest)
                    .HasColumnName("sacred_kindred_crest")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SandoriaCp)
                    .HasColumnName("sandoria_cp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Scyld)
                    .HasColumnName("scyld")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SecondEchelonTrophy)
                    .HasColumnName("second_echelon_trophy")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShiningStar)
                    .HasColumnName("shining_star")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SparkOfEminence)
                    .HasColumnName("spark_of_eminence")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TherionIchor)
                    .HasColumnName("therion_ichor")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ThirdEchelonTrophy)
                    .HasColumnName("third_echelon_trophy")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TraverserStones)
                    .HasColumnName("traverser_stones")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TunnelWorm)
                    .HasColumnName("tunnel_worm")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorPoint)
                    .HasColumnName("valor_point")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Voidstones)
                    .HasColumnName("voidstones")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WaterFewell)
                    .HasColumnName("water_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindFewell)
                    .HasColumnName("wind_fewell")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindurstCp)
                    .HasColumnName("windurst_cp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZeniPoint)
                    .HasColumnName("zeni_point")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharProfile>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_profile", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.FameAbyAltepa)
                    .HasColumnName("fame_aby_altepa")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyAttohwa)
                    .HasColumnName("fame_aby_attohwa")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyGrauberg)
                    .HasColumnName("fame_aby_grauberg")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyKonschtat)
                    .HasColumnName("fame_aby_konschtat")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyLatheine)
                    .HasColumnName("fame_aby_latheine")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyMisareaux)
                    .HasColumnName("fame_aby_misareaux")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyTahrongi)
                    .HasColumnName("fame_aby_tahrongi")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyUleguerand)
                    .HasColumnName("fame_aby_uleguerand")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAbyVunkerl)
                    .HasColumnName("fame_aby_vunkerl")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameAdoulin)
                    .HasColumnName("fame_adoulin")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameBastok)
                    .HasColumnName("fame_bastok")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameJeuno)
                    .HasColumnName("fame_jeuno")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameNorg)
                    .HasColumnName("fame_norg")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameSandoria)
                    .HasColumnName("fame_sandoria")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FameWindurst)
                    .HasColumnName("fame_windurst")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RankBastok)
                    .HasColumnName("rank_bastok")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RankPoints)
                    .HasColumnName("rank_points")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RankSandoria)
                    .HasColumnName("rank_sandoria")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RankWindurst)
                    .HasColumnName("rank_windurst")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CharRecast>(entity =>
            {
                entity.HasKey(e => new { e.Charid, e.Id });

                entity.ToTable("char_recast", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recast)
                    .HasColumnName("recast")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharSkills>(entity =>
            {
                entity.HasKey(e => new { e.Charid, e.Skillid });

                entity.ToTable("char_skills", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Skillid)
                    .HasColumnName("skillid")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharSpells>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("char_spells", "dspdb");

                entity.HasIndex(e => e.Charid)
                    .HasName("char_spells_charid_index");

                entity.HasIndex(e => e.Spellid)
                    .HasName("char_spells_spellid_index");

                entity.HasIndex(e => new { e.Spellid, e.Charid })
                    .HasName("idx_char_spells_spellid_charid")
                    .IsUnique();

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Spellid)
                    .HasColumnName("spellid")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<CharStats>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_stats", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.BazaarMessage)
                    .HasColumnName("bazaar_message")
                    .HasColumnType("blob");

                entity.Property(e => e.Death)
                    .HasColumnName("death")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hp)
                    .HasColumnName("hp")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.Mhflag)
                    .HasColumnName("mhflag")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mjob)
                    .HasColumnName("mjob")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mlvl)
                    .HasColumnName("mlvl")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Mp)
                    .HasColumnName("mp")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.Nameflags)
                    .HasColumnName("nameflags")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetHp)
                    .HasColumnName("pet_hp")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetId)
                    .HasColumnName("pet_id")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetMp)
                    .HasColumnName("pet_mp")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PetType)
                    .HasColumnName("pet_type")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sjob)
                    .HasColumnName("sjob")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slvl)
                    .HasColumnName("slvl")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zoning)
                    .HasColumnName("zoning")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e._2h)
                    .HasColumnName("2h")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharStorage>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_storage", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Case)
                    .HasColumnName("case")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("80");

                entity.Property(e => e.Inventory)
                    .HasColumnName("inventory")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.Locker)
                    .HasColumnName("locker")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sack)
                    .HasColumnName("sack")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.Safe)
                    .HasColumnName("safe")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.Satchel)
                    .HasColumnName("satchel")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.Wardrobe)
                    .HasColumnName("wardrobe")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("80");

                entity.Property(e => e.Wardrobe2)
                    .HasColumnName("wardrobe2")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("80");

                entity.Property(e => e.Wardrobe3)
                    .HasColumnName("wardrobe3")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("80");

                entity.Property(e => e.Wardrobe4)
                    .HasColumnName("wardrobe4")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("80");
            });

            modelBuilder.Entity<CharStyle>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_style", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Feet)
                    .HasColumnName("feet")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hands)
                    .HasColumnName("hands")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Head)
                    .HasColumnName("head")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Legs)
                    .HasColumnName("legs")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Main)
                    .HasColumnName("main")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ranged)
                    .HasColumnName("ranged")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sub)
                    .HasColumnName("sub")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharUnlocks>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("char_unlocks", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.BastokSupply)
                    .HasColumnName("bastok_supply")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Homepoints)
                    .HasColumnName("homepoints")
                    .HasColumnType("blob");

                entity.Property(e => e.Maw)
                    .HasColumnName("maw")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MogLocker)
                    .HasColumnName("mog_locker")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PastBastokTp)
                    .HasColumnName("past_bastok_tp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PastSandoriaTp)
                    .HasColumnName("past_sandoria_tp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PastWindurstTp)
                    .HasColumnName("past_windurst_tp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunicPortal)
                    .HasColumnName("runic_portal")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SandoriaSupply)
                    .HasColumnName("sandoria_supply")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindurstSupply)
                    .HasColumnName("windurst_supply")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CharVars>(entity =>
            {
                entity.HasKey(e => new { e.Charid, e.Varname });

                entity.ToTable("char_vars", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Varname)
                    .HasColumnName("varname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Chars>(entity =>
            {
                entity.HasKey(e => e.Charid);

                entity.ToTable("chars", "dspdb");

                entity.HasIndex(e => e.Charname)
                    .HasName("charname");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abilities)
                    .HasColumnName("abilities")
                    .HasColumnType("blob");

                entity.Property(e => e.Accid)
                    .HasColumnName("accid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Assault)
                    .HasColumnName("assault")
                    .HasColumnType("blob");

                entity.Property(e => e.Boundary)
                    .HasColumnName("boundary")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Campaign)
                    .HasColumnName("campaign")
                    .HasColumnType("blob");

                entity.Property(e => e.CampaignAllegiance)
                    .HasColumnName("campaign_allegiance")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Charname)
                    .IsRequired()
                    .HasColumnName("charname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Gmlevel)
                    .HasColumnName("gmlevel")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HomeRot)
                    .HasColumnName("home_rot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HomeX)
                    .HasColumnName("home_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.HomeY)
                    .HasColumnName("home_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.HomeZ)
                    .HasColumnName("home_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.HomeZone)
                    .HasColumnName("home_zone")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Isstylelocked)
                    .HasColumnName("isstylelocked")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Keyitems)
                    .HasColumnName("keyitems")
                    .HasColumnType("blob");

                entity.Property(e => e.Mentor)
                    .HasColumnName("mentor")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Missions)
                    .HasColumnName("missions")
                    .HasColumnType("blob");

                entity.Property(e => e.Moghancement)
                    .HasColumnName("moghancement")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Moghouse)
                    .HasColumnName("moghouse")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nation)
                    .HasColumnName("nation")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nnameflags)
                    .HasColumnName("nnameflags")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Playtime)
                    .HasColumnName("playtime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosPrevzone)
                    .HasColumnName("pos_prevzone")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosRot)
                    .HasColumnName("pos_rot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("pos_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosY)
                    .HasColumnName("pos_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosZ)
                    .HasColumnName("pos_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosZone)
                    .HasColumnName("pos_zone")
                    .HasColumnType("smallint(3) unsigned");

                entity.Property(e => e.Quests)
                    .HasColumnName("quests")
                    .HasColumnType("blob");

                entity.Property(e => e.SetBlueSpells)
                    .HasColumnName("set_blue_spells")
                    .HasColumnType("blob");

                entity.Property(e => e.Titles)
                    .HasColumnName("titles")
                    .HasColumnType("blob");

                entity.Property(e => e.UnlockedWeapons)
                    .HasColumnName("unlocked_weapons")
                    .HasColumnType("blob");

                entity.Property(e => e.Weaponskills)
                    .HasColumnName("weaponskills")
                    .HasColumnType("blob");

                entity.Property(e => e.Zones)
                    .HasColumnName("zones")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<ConquestSystem>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("conquest_system", "dspdb");

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BastokInfluence)
                    .HasColumnName("bastok_influence")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BeastmenInfluence)
                    .HasColumnName("beastmen_influence")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionControl)
                    .HasColumnName("region_control")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionControlPrev)
                    .HasColumnName("region_control_prev")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SandoriaInfluence)
                    .HasColumnName("sandoria_influence")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindurstInfluence)
                    .HasColumnName("windurst_influence")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DeliveryBox>(entity =>
            {
                entity.HasKey(e => new { e.Charid, e.Box, e.Slot });

                entity.ToTable("delivery_box", "dspdb");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Charname)
                    .HasColumnName("charname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Extra)
                    .HasColumnName("extra")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Itemsubid)
                    .HasColumnName("itemsubid")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Received)
                    .HasColumnName("received")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Senderid)
                    .HasColumnName("senderid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DespoilEffects>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("despoil_effects", "dspdb");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectId")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<ExpBase>(entity =>
            {
                entity.HasKey(e => e.Level);

                entity.ToTable("exp_base", "dspdb");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Exp)
                    .HasColumnName("exp")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ExpTable>(entity =>
            {
                entity.HasKey(e => e.Level);

                entity.ToTable("exp_table", "dspdb");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.R1)
                    .HasColumnName("r1")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R10)
                    .HasColumnName("r10")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R11)
                    .HasColumnName("r11")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R12)
                    .HasColumnName("r12")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R13)
                    .HasColumnName("r13")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R14)
                    .HasColumnName("r14")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R15)
                    .HasColumnName("r15")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R16)
                    .HasColumnName("r16")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R17)
                    .HasColumnName("r17")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R18)
                    .HasColumnName("r18")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R19)
                    .HasColumnName("r19")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R2)
                    .HasColumnName("r2")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R20)
                    .HasColumnName("r20")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R3)
                    .HasColumnName("r3")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R4)
                    .HasColumnName("r4")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R5)
                    .HasColumnName("r5")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R6)
                    .HasColumnName("r6")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R7)
                    .HasColumnName("r7")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R8)
                    .HasColumnName("r8")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R9)
                    .HasColumnName("r9")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<FishingFish>(entity =>
            {
                entity.HasKey(e => e.Fishid);

                entity.ToTable("fishing_fish", "dspdb");

                entity.Property(e => e.Fishid)
                    .HasColumnName("fishid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Log)
                    .HasColumnName("log")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("255");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("255");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stamina)
                    .HasColumnName("stamina")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Watertype)
                    .HasColumnName("watertype")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<FishingLure>(entity =>
            {
                entity.HasKey(e => new { e.Lureid, e.Fishid });

                entity.ToTable("fishing_lure", "dspdb");

                entity.Property(e => e.Lureid)
                    .HasColumnName("lureid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Fishid)
                    .HasColumnName("fishid")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Luck)
                    .HasColumnName("luck")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FishingRod>(entity =>
            {
                entity.HasKey(e => new { e.Rodid, e.Fishid });

                entity.ToTable("fishing_rod", "dspdb");

                entity.Property(e => e.Rodid)
                    .HasColumnName("rodid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Fishid)
                    .HasColumnName("fishid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FishingZone>(entity =>
            {
                entity.HasKey(e => new { e.Zoneid, e.Fishid });

                entity.ToTable("fishing_zone", "dspdb");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Fishid)
                    .HasColumnName("fishid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuildItemPoints>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.Itemid, e.Pattern });

                entity.ToTable("guild_item_points", "dspdb");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Pattern)
                    .HasColumnName("pattern")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPoints)
                    .HasColumnName("max_points")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(1) unsigned");
            });

            modelBuilder.Entity<GuildShops>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.Itemid });

                entity.ToTable("guild_shops", "dspdb");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.DailyIncrease)
                    .HasColumnName("daily_increase")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InitialQuantity)
                    .HasColumnName("initial_quantity")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxPrice)
                    .HasColumnName("max_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxQuantity)
                    .HasColumnName("max_quantity")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinPrice)
                    .HasColumnName("min_price")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Guilds>(entity =>
            {
                entity.ToTable("guilds", "dspdb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PointsName)
                    .IsRequired()
                    .HasColumnName("points_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstanceEntities>(entity =>
            {
                entity.HasKey(e => new { e.Instanceid, e.Id });

                entity.ToTable("instance_entities", "dspdb");

                entity.Property(e => e.Instanceid)
                    .HasColumnName("instanceid")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<InstanceList>(entity =>
            {
                entity.HasKey(e => e.Instanceid);

                entity.ToTable("instance_list", "dspdb");

                entity.Property(e => e.Instanceid)
                    .HasColumnName("instanceid")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Battlemulti)
                    .HasColumnName("battlemulti")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Battlesolo)
                    .HasColumnName("battlesolo")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.EntranceZone)
                    .HasColumnName("entrance_zone")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceName)
                    .IsRequired()
                    .HasColumnName("instance_name")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MusicDay)
                    .HasColumnName("music_day")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.MusicNight)
                    .HasColumnName("music_night")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.StartRot)
                    .HasColumnName("start_rot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartX)
                    .HasColumnName("start_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.StartY)
                    .HasColumnName("start_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.StartZ)
                    .HasColumnName("start_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.TimeLimit)
                    .HasColumnName("time_limit")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemArmor>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("item_armor", "dspdb");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ilevel)
                    .HasColumnName("ilevel")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Jobs)
                    .HasColumnName("jobs")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mid)
                    .HasColumnName("MId")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Rslot)
                    .HasColumnName("rslot")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScriptType)
                    .HasColumnName("scriptType")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShieldSize)
                    .HasColumnName("shieldSize")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemBasic>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("item_basic", "dspdb");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AH)
                    .HasColumnName("aH")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.BaseSell)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.NoSale)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sortname)
                    .IsRequired()
                    .HasColumnName("sortname")
                    .HasColumnType("tinytext");

                entity.Property(e => e.StackSize)
                    .HasColumnName("stackSize")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Subid)
                    .HasColumnName("subid")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemFurnishing>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("item_furnishing", "dspdb");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aura)
                    .HasColumnName("aura")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Moghancement)
                    .HasColumnName("moghancement")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Storage)
                    .HasColumnName("storage")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemLatents>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ModId, e.Value, e.LatentId, e.LatentParam });

                entity.ToTable("item_latents", "dspdb");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ModId)
                    .HasColumnName("modId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LatentId)
                    .HasColumnName("latentId")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.LatentParam)
                    .HasColumnName("latentParam")
                    .HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<ItemMods>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ModId });

                entity.ToTable("item_mods", "dspdb");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ModId)
                    .HasColumnName("modId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemModsPet>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ModId, e.PetType });

                entity.ToTable("item_mods_pet", "dspdb");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ModId)
                    .HasColumnName("modId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PetType)
                    .HasColumnName("petType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemPuppet>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("item_puppet", "dspdb");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemUsable>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("item_usable", "dspdb");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activation)
                    .HasColumnName("activation")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Animation)
                    .HasColumnName("animation")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimationTime)
                    .HasColumnName("animationTime")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Aoe)
                    .HasColumnName("aoe")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxCharges)
                    .HasColumnName("maxCharges")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.ReuseDelay)
                    .HasColumnName("reuseDelay")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseDelay)
                    .HasColumnName("useDelay")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValidTargets)
                    .HasColumnName("validTargets")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ItemWeapon>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("item_weapon", "dspdb");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dmg)
                    .HasColumnName("dmg")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DmgType)
                    .HasColumnName("dmgType")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hit)
                    .HasColumnName("hit")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IlvlMacc)
                    .HasColumnName("ilvl_macc")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IlvlParry)
                    .HasColumnName("ilvl_parry")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IlvlSkill)
                    .HasColumnName("ilvl_skill")
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Skill)
                    .HasColumnName("skill")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subskill)
                    .HasColumnName("subskill")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnlockPoints)
                    .HasColumnName("unlock_points")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<JobPoints>(entity =>
            {
                entity.HasKey(e => e.JobPointid);

                entity.ToTable("job_points", "dspdb");

                entity.Property(e => e.JobPointid)
                    .HasColumnName("job_pointid")
                    .HasColumnType("smallint(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Jobs)
                    .HasColumnName("jobs")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Upgrade)
                    .HasColumnName("upgrade")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Linkshells>(entity =>
            {
                entity.HasKey(e => e.Linkshellid);

                entity.ToTable("linkshells", "dspdb");

                entity.Property(e => e.Linkshellid)
                    .HasColumnName("linkshellid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("61440");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("blob");

                entity.Property(e => e.Messagetime)
                    .HasColumnName("messagetime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poster)
                    .IsRequired()
                    .HasColumnName("poster")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Postrights)
                    .HasColumnName("postrights")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Merits>(entity =>
            {
                entity.HasKey(e => e.Meritid);

                entity.ToTable("merits", "dspdb");

                entity.Property(e => e.Meritid)
                    .HasColumnName("meritid")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catagoryid)
                    .HasColumnName("catagoryid")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Jobs)
                    .HasColumnName("jobs")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(25)");

                entity.Property(e => e.Upgrade)
                    .HasColumnName("upgrade")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Upgradeid)
                    .HasColumnName("upgradeid")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobDroplist>(entity =>
            {
                entity.HasKey(e => e.Trashid);

                entity.ToTable("mob_droplist", "dspdb");

                entity.HasIndex(e => e.DropId)
                    .HasName("dropId");

                entity.Property(e => e.Trashid)
                    .HasColumnName("trashid")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DropId)
                    .HasColumnName("dropId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.DropType)
                    .HasColumnName("dropType")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupId")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupRate)
                    .HasColumnName("groupRate")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemRate)
                    .HasColumnName("itemRate")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobFamilyMods>(entity =>
            {
                entity.HasKey(e => new { e.Familyid, e.Modid });

                entity.ToTable("mob_family_mods", "dspdb");

                entity.Property(e => e.Familyid)
                    .HasColumnName("familyid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Modid)
                    .HasColumnName("modid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsMobMod)
                    .HasColumnName("is_mob_mod")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobFamilySystem>(entity =>
            {
                entity.HasKey(e => e.Familyid);

                entity.ToTable("mob_family_system", "dspdb");

                entity.Property(e => e.Familyid)
                    .HasColumnName("familyid")
                    .HasColumnType("smallint(4) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Acc)
                    .HasColumnName("ACC")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Agi)
                    .HasColumnName("AGI")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Att)
                    .HasColumnName("ATT")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Charmable)
                    .HasColumnName("charmable")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Chr)
                    .HasColumnName("CHR")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Dark).HasDefaultValueSql("1");

                entity.Property(e => e.Def)
                    .HasColumnName("DEF")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Detects)
                    .HasColumnName("detects")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dex)
                    .HasColumnName("DEX")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Earth).HasDefaultValueSql("1");

                entity.Property(e => e.Element).HasDefaultValueSql("0");

                entity.Property(e => e.Eva)
                    .HasColumnName("EVA")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Family)
                    .HasColumnName("family")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Fire).HasDefaultValueSql("1");

                entity.Property(e => e.H2h)
                    .HasColumnName("H2H")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Hp)
                    .HasColumnName("HP")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Ice).HasDefaultValueSql("1");

                entity.Property(e => e.Impact).HasDefaultValueSql("1");

                entity.Property(e => e.Int)
                    .HasColumnName("INT")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Light).HasDefaultValueSql("1");

                entity.Property(e => e.Lightning).HasDefaultValueSql("1");

                entity.Property(e => e.Mnd)
                    .HasColumnName("MND")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Mobsize)
                    .HasColumnName("mobsize")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mp)
                    .HasColumnName("MP")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Pierce).HasDefaultValueSql("1");

                entity.Property(e => e.Slash).HasDefaultValueSql("1");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.Str)
                    .HasColumnName("STR")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.System)
                    .HasColumnName("system")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Systemid)
                    .HasColumnName("systemid")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vit)
                    .HasColumnName("VIT")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Water).HasDefaultValueSql("1");

                entity.Property(e => e.Wind).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<MobGroups>(entity =>
            {
                entity.HasKey(e => e.Groupid);

                entity.ToTable("mob_groups", "dspdb");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Allegiance)
                    .HasColumnName("allegiance")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dropid)
                    .HasColumnName("dropid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hp)
                    .HasColumnName("HP")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnName("maxLevel")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnName("minLevel")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mp)
                    .HasColumnName("MP")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Poolid)
                    .HasColumnName("poolid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Respawntime)
                    .HasColumnName("respawntime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Spawntype)
                    .HasColumnName("spawntype")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobPets>(entity =>
            {
                entity.HasKey(e => e.MobMobid);

                entity.ToTable("mob_pets", "dspdb");

                entity.Property(e => e.MobMobid)
                    .HasColumnName("mob_mobid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.PetOffset)
                    .HasColumnName("pet_offset")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<MobPoolMods>(entity =>
            {
                entity.HasKey(e => new { e.Poolid, e.Modid });

                entity.ToTable("mob_pool_mods", "dspdb");

                entity.Property(e => e.Poolid)
                    .HasColumnName("poolid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Modid)
                    .HasColumnName("modid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsMobMod)
                    .HasColumnName("is_mob_mod")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobPools>(entity =>
            {
                entity.HasKey(e => e.Poolid);

                entity.ToTable("mob_pools", "dspdb");

                entity.Property(e => e.Poolid)
                    .HasColumnName("poolid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aggro)
                    .HasColumnName("aggro")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Animationsub)
                    .HasColumnName("animationsub")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Behavior)
                    .HasColumnName("behavior")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CmbDelay)
                    .HasColumnName("cmbDelay")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("240");

                entity.Property(e => e.CmbDmgMult)
                    .HasColumnName("cmbDmgMult")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.CmbSkill)
                    .HasColumnName("cmbSkill")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EntityFlags)
                    .HasColumnName("entityFlags")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Familyid)
                    .HasColumnName("familyid")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasSpellScript)
                    .HasColumnName("hasSpellScript")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Immunity)
                    .HasColumnName("immunity")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Links)
                    .HasColumnName("links")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MJob)
                    .HasColumnName("mJob")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MobType)
                    .HasColumnName("mobType")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modelid)
                    .IsRequired()
                    .HasColumnName("modelid")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("name_prefix")
                    .HasColumnType("tinyint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Namevis)
                    .HasColumnName("namevis")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PacketName)
                    .HasColumnName("packet_name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Roamflag)
                    .HasColumnName("roamflag")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SJob)
                    .HasColumnName("sJob")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SkillListId)
                    .HasColumnName("skill_list_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellList)
                    .HasColumnName("spellList")
                    .HasColumnType("smallint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TrueDetection)
                    .HasColumnName("true_detection")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobSkillLists>(entity =>
            {
                entity.HasKey(e => new { e.SkillListId, e.MobSkillId });

                entity.ToTable("mob_skill_lists", "dspdb");

                entity.Property(e => e.SkillListId)
                    .HasColumnName("skill_list_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MobSkillId)
                    .HasColumnName("mob_skill_id")
                    .HasColumnType("smallint(3) unsigned");

                entity.Property(e => e.SkillListName)
                    .HasColumnName("skill_list_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MobSkills>(entity =>
            {
                entity.HasKey(e => e.MobSkillId);

                entity.ToTable("mob_skills", "dspdb");

                entity.Property(e => e.MobSkillId)
                    .HasColumnName("mob_skill_id")
                    .HasColumnType("smallint(4) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Knockback)
                    .HasColumnName("knockback")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobAnimId)
                    .HasColumnName("mob_anim_id")
                    .HasColumnType("smallint(4) unsigned");

                entity.Property(e => e.MobAnimTime)
                    .HasColumnName("mob_anim_time")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("2000");

                entity.Property(e => e.MobPrepareTime)
                    .HasColumnName("mob_prepare_time")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.MobSkillAoe)
                    .HasColumnName("mob_skill_aoe")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobSkillDistance)
                    .HasColumnName("mob_skill_distance")
                    .HasColumnType("float(3,1)")
                    .HasDefaultValueSql("6.0");

                entity.Property(e => e.MobSkillFlag)
                    .HasColumnName("mob_skill_flag")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobSkillName)
                    .IsRequired()
                    .HasColumnName("mob_skill_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MobSkillParam)
                    .HasColumnName("mob_skill_param")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobValidTargets)
                    .HasColumnName("mob_valid_targets")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.PrimarySc)
                    .HasColumnName("primary_sc")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SecondarySc)
                    .HasColumnName("secondary_sc")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TertiarySc)
                    .HasColumnName("tertiary_sc")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobSpawnMods>(entity =>
            {
                entity.HasKey(e => new { e.Mobid, e.Modid });

                entity.ToTable("mob_spawn_mods", "dspdb");

                entity.Property(e => e.Mobid)
                    .HasColumnName("mobid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Modid)
                    .HasColumnName("modid")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.IsMobMod)
                    .HasColumnName("is_mob_mod")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MobSpawnPoints>(entity =>
            {
                entity.HasKey(e => e.Mobid);

                entity.ToTable("mob_spawn_points", "dspdb");

                entity.Property(e => e.Mobid)
                    .HasColumnName("mobid")
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mobname)
                    .HasColumnName("mobname")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.PolutilsName)
                    .HasColumnName("polutils_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosRot)
                    .HasColumnName("pos_rot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("pos_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosY)
                    .HasColumnName("pos_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosZ)
                    .HasColumnName("pos_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");
            });

            modelBuilder.Entity<MobSpellLists>(entity =>
            {
                entity.HasKey(e => new { e.SpellListId, e.SpellId });

                entity.ToTable("mob_spell_lists", "dspdb");

                entity.Property(e => e.SpellListId)
                    .HasColumnName("spell_list_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spell_id")
                    .HasColumnType("smallint(3) unsigned");

                entity.Property(e => e.MaxLevel)
                    .HasColumnName("max_level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MinLevel)
                    .HasColumnName("min_level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SpellListName)
                    .HasColumnName("spell_list_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NmSpawnPoints>(entity =>
            {
                entity.HasKey(e => new { e.Mobid, e.Pos });

                entity.ToTable("nm_spawn_points", "dspdb");

                entity.Property(e => e.Mobid)
                    .HasColumnName("mobid")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("pos_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosY)
                    .HasColumnName("pos_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosZ)
                    .HasColumnName("pos_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");
            });

            modelBuilder.Entity<NpcList>(entity =>
            {
                entity.HasKey(e => e.Npcid);

                entity.ToTable("npc_list", "dspdb");

                entity.Property(e => e.Npcid)
                    .HasColumnName("npcid")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Animation)
                    .HasColumnName("animation")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Animationsub)
                    .HasColumnName("animationsub")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentTag)
                    .HasColumnName("content_tag")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EntityFlags)
                    .HasColumnName("entityFlags")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Look)
                    .IsRequired()
                    .HasColumnName("look")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("char(24)");

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("name_prefix")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Namevis)
                    .HasColumnName("namevis")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PolutilsName)
                    .HasColumnName("polutils_name")
                    .HasColumnType("char(50)");

                entity.Property(e => e.PosRot)
                    .HasColumnName("pos_rot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("pos_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosY)
                    .HasColumnName("pos_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PosZ)
                    .HasColumnName("pos_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.Speedsub)
                    .HasColumnName("speedsub")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Widescan)
                    .HasColumnName("widescan")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PetList>(entity =>
            {
                entity.HasKey(e => e.Petid);

                entity.ToTable("pet_list", "dspdb");

                entity.Property(e => e.Petid)
                    .HasColumnName("petid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLevel)
                    .HasColumnName("maxLevel")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinLevel)
                    .HasColumnName("minLevel")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(15)");

                entity.Property(e => e.Poolid)
                    .HasColumnName("poolid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PetName>(entity =>
            {
                entity.ToTable("pet_name", "dspdb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(3) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(15)");
            });

            modelBuilder.Entity<ServerVariables>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("server_variables", "dspdb");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkillCaps>(entity =>
            {
                entity.HasKey(e => e.Level);

                entity.ToTable("skill_caps", "dspdb");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.R0)
                    .HasColumnName("r0")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R1)
                    .HasColumnName("r1")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R10)
                    .HasColumnName("r10")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R11)
                    .HasColumnName("r11")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R12)
                    .HasColumnName("r12")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R13)
                    .HasColumnName("r13")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R2)
                    .HasColumnName("r2")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R3)
                    .HasColumnName("r3")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R4)
                    .HasColumnName("r4")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R5)
                    .HasColumnName("r5")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R6)
                    .HasColumnName("r6")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R7)
                    .HasColumnName("r7")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R8)
                    .HasColumnName("r8")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.R9)
                    .HasColumnName("r9")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SkillRanks>(entity =>
            {
                entity.HasKey(e => e.Skillid);

                entity.ToTable("skill_ranks", "dspdb");

                entity.Property(e => e.Skillid)
                    .HasColumnName("skillid")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blm)
                    .HasColumnName("blm")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Blu)
                    .HasColumnName("blu")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Brd)
                    .HasColumnName("brd")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bst)
                    .HasColumnName("bst")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dnc)
                    .HasColumnName("dnc")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Drg)
                    .HasColumnName("drg")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Drk)
                    .HasColumnName("drk")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Geo)
                    .HasColumnName("geo")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mnk)
                    .HasColumnName("mnk")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("char(12)");

                entity.Property(e => e.Nin)
                    .HasColumnName("nin")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pld)
                    .HasColumnName("pld")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pup)
                    .HasColumnName("pup")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rdm)
                    .HasColumnName("rdm")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rng)
                    .HasColumnName("rng")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Run)
                    .HasColumnName("run")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sam)
                    .HasColumnName("sam")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sch)
                    .HasColumnName("sch")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Smn)
                    .HasColumnName("smn")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Thf)
                    .HasColumnName("thf")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.War)
                    .HasColumnName("war")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Whm)
                    .HasColumnName("whm")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SkillchainDamageModifiers>(entity =>
            {
                entity.HasKey(e => new { e.ChainLevel, e.ChainCount });

                entity.ToTable("skillchain_damage_modifiers", "dspdb");

                entity.Property(e => e.ChainLevel)
                    .HasColumnName("chain_level")
                    .HasColumnType("enum('1','2','3','4')")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ChainCount)
                    .HasColumnName("chain_count")
                    .HasColumnType("enum('1','2','3','4','5')")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InitialModifier)
                    .HasColumnName("initial_modifier")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MagicBurstModifier)
                    .HasColumnName("magic_burst_modifier")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<SpellList>(entity =>
            {
                entity.HasKey(e => e.Spellid);

                entity.ToTable("spell_list", "dspdb");

                entity.Property(e => e.Spellid)
                    .HasColumnName("spellid")
                    .HasColumnType("smallint(3) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Animation)
                    .HasColumnName("animation")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimationTime)
                    .HasColumnName("animationTime")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("2000");

                entity.Property(e => e.Aoe)
                    .HasColumnName("AOE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Base)
                    .HasColumnName("base")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CastTime)
                    .HasColumnName("castTime")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ce)
                    .HasColumnName("CE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentTag)
                    .HasColumnName("content_tag")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Jobs)
                    .IsRequired()
                    .HasColumnName("jobs")
                    .HasColumnType("binary(22)");

                entity.Property(e => e.MagicBurstMessage)
                    .HasColumnName("magicBurstMessage")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MpCost)
                    .HasColumnName("mpCost")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Multiplier)
                    .HasColumnName("multiplier")
                    .HasColumnType("float(4,2)")
                    .HasDefaultValueSql("1.00");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(20)");

                entity.Property(e => e.RecastTime)
                    .HasColumnName("recastTime")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Requirements)
                    .HasColumnName("requirements")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skill)
                    .HasColumnName("skill")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpellRange)
                    .HasColumnName("spell_range")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValidTargets)
                    .HasColumnName("validTargets")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ve)
                    .HasColumnName("VE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zonemisc)
                    .HasColumnName("zonemisc")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<StatusEffects>(entity =>
            {
                entity.ToTable("status_effects", "dspdb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlockId)
                    .HasColumnName("block_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(8) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinDuration)
                    .HasColumnName("min_duration")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NegativeId)
                    .HasColumnName("negative_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Overwrite)
                    .HasColumnName("overwrite")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemoveId)
                    .HasColumnName("remove_id")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SynthRecipes>(entity =>
            {
                entity.ToTable("synth_recipes", "dspdb");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Alchemy).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Bone).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Cloth).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Cook).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Crystal).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Gold).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Hqcrystal)
                    .HasColumnName("HQCrystal")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient5).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient6).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient7).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Ingredient8).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.KeyItem).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Leather).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Result).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ResultHq1)
                    .HasColumnName("ResultHQ1")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ResultHq1qty)
                    .HasColumnName("ResultHQ1Qty")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.ResultHq2)
                    .HasColumnName("ResultHQ2")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ResultHq2qty)
                    .HasColumnName("ResultHQ2Qty")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.ResultHq3)
                    .HasColumnName("ResultHQ3")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ResultHq3qty)
                    .HasColumnName("ResultHQ3Qty")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.ResultQty).HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.Smith).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Wood).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Traits>(entity =>
            {
                entity.HasKey(e => new { e.Traitid, e.Job, e.Level, e.Rank, e.Modifier });

                entity.ToTable("traits", "dspdb");

                entity.Property(e => e.Traitid)
                    .HasColumnName("traitid")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Modifier)
                    .HasColumnName("modifier")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentTag)
                    .HasColumnName("content_tag")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Meritid)
                    .HasColumnName("meritid")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.ToTable("transport", "dspdb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.AnimArrive)
                    .HasColumnName("anim_arrive")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimDepart)
                    .HasColumnName("anim_depart")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Boundary)
                    .HasColumnName("boundary")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DockRot)
                    .HasColumnName("dock_rot")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DockX)
                    .HasColumnName("dock_x")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.DockY)
                    .HasColumnName("dock_y")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.DockZ)
                    .HasColumnName("dock_z")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Door)
                    .HasColumnName("door")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.TimeAnimArrive)
                    .HasColumnName("time_anim_arrive")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeAnimDepart)
                    .HasColumnName("time_anim_depart")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeInterval)
                    .HasColumnName("time_interval")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeOffset)
                    .HasColumnName("time_offset")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeWaiting)
                    .HasColumnName("time_waiting")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transport1)
                    .HasColumnName("transport")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WaterPoints>(entity =>
            {
                entity.HasKey(e => e.Waterid);

                entity.ToTable("water_points", "dspdb");

                entity.Property(e => e.Waterid)
                    .HasColumnName("waterid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Pointid)
                    .HasColumnName("pointid")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosX)
                    .HasColumnName("pos_x")
                    .HasColumnType("float(7,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PosY)
                    .HasColumnName("pos_y")
                    .HasColumnType("float(7,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PosZ)
                    .HasColumnName("pos_z")
                    .HasColumnType("float(7,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasColumnType("smallint(3) unsigned");
            });

            modelBuilder.Entity<WeaponSkills>(entity =>
            {
                entity.HasKey(e => e.Weaponskillid);

                entity.ToTable("weapon_skills", "dspdb");

                entity.Property(e => e.Weaponskillid)
                    .HasColumnName("weaponskillid")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Animation)
                    .HasColumnName("animation")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnimationTime)
                    .HasColumnName("animationTime")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Aoe)
                    .HasColumnName("aoe")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Jobs)
                    .IsRequired()
                    .HasColumnName("jobs")
                    .HasColumnType("binary(22)");

                entity.Property(e => e.MainOnly)
                    .HasColumnName("main_only")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySc)
                    .HasColumnName("primary_sc")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Range)
                    .HasColumnName("range")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.SecondarySc)
                    .HasColumnName("secondary_sc")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skilllevel)
                    .HasColumnName("skilllevel")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TertiarySc)
                    .HasColumnName("tertiary_sc")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnlockId)
                    .HasColumnName("unlock_id")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ZoneSettings>(entity =>
            {
                entity.HasKey(e => e.Zoneid);

                entity.ToTable("zone_settings", "dspdb");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Battlemulti)
                    .HasColumnName("battlemulti")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Battlesolo)
                    .HasColumnName("battlesolo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Misc)
                    .HasColumnName("misc")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MusicDay)
                    .HasColumnName("music_day")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MusicNight)
                    .HasColumnName("music_night")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Restriction)
                    .HasColumnName("restriction")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Zoneip)
                    .IsRequired()
                    .HasColumnName("zoneip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Zoneport)
                    .HasColumnName("zoneport")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zonetype)
                    .HasColumnName("zonetype")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ZoneWeather>(entity =>
            {
                entity.HasKey(e => new { e.Zoneid, e.WeatherDay });

                entity.ToTable("zone_weather", "dspdb");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WeatherDay)
                    .HasColumnName("weather_day")
                    .HasColumnType("smallint(4) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Common)
                    .HasColumnName("common")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Normal)
                    .HasColumnName("normal")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rare)
                    .HasColumnName("rare")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Zonelines>(entity =>
            {
                entity.HasKey(e => e.Zoneline);

                entity.ToTable("zonelines", "dspdb");

                entity.Property(e => e.Zoneline)
                    .HasColumnName("zoneline")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fromzone)
                    .HasColumnName("fromzone")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rotation)
                    .HasColumnName("rotation")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tox)
                    .HasColumnName("tox")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Toy)
                    .HasColumnName("toy")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Toz)
                    .HasColumnName("toz")
                    .HasColumnType("float(7,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Tozone)
                    .HasColumnName("tozone")
                    .HasColumnType("smallint(3) unsigned")
                    .HasDefaultValueSql("0");
            });
        }
    }
}

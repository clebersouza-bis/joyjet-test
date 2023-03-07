using System;
using Bridge.ERP.Models;
using Bridge.ERP.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bridge.ERP
{
    public partial class bidbdesenvContext : DbContext
    {
        public bidbdesenvContext()
        {
        }

        public bidbdesenvContext(DbContextOptions<bidbdesenvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactsLocation> ContactsLocations { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CycleCampaignsTransaction> CycleCampaignsTransactions { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; }
        public virtual DbSet<ImportHistory> ImportHistories { get; set; }
        public virtual DbSet<Lancamento> Lancamentos { get; set; }
        public virtual DbSet<LeadsFollowUp> LeadsFollowUps { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LogAccess> LogAccesses { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<PropertiesList> PropertiesLists { get; set; }
        public virtual DbSet<PropertiesTag> PropertiesTags { get; set; }
        public virtual DbSet<PropertiesTask> PropertiesTasks { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<RecycledCampaignsList> RecycledCampaignsLists { get; set; }
        //public virtual DbSet<Seguradora> Seguradoras { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TransactionsCampaign> TransactionsCampaigns { get; set; }
        //public virtual DbSet<VehiclesOnMarket> VehiclesOnMarkets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=bidbdesenv.mysql.dbaas.com.br;database=bidbdesenv;user id=bidbdesenv;pwd=b*[2021];treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(767);

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(767);

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("text");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PasswordHash).HasColumnType("text");

                entity.Property(e => e.PhoneNumber).HasColumnType("text");

                entity.Property(e => e.SecurityStamp).HasColumnType("text");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MarketType).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Pipeline).HasMaxLength(255);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.HasIndex(e => e.ParentId, "parent_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("category_ibfk_1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("Cliente");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCliente");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("CNPJ")
                    .UseCollation("latin1_general_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Datacadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("DATACADASTRO");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("NOME")
                    .UseCollation("latin1_general_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("STATUS")
                    .UseCollation("latin1_general_ci")
                    .HasCharSet("latin1");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.Address, "IndexAddress");

                entity.HasIndex(e => e.City, "IndexCity");

                entity.HasIndex(e => e.TenantId, "TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactType).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(55);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedType).HasMaxLength(55);

                entity.Property(e => e.CriticalStatus).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Email2).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MainCity).HasMaxLength(255);

                entity.Property(e => e.MainState).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.SourceName).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Vipcontact)
                    .HasMaxLength(55)
                    .HasColumnName("VIPContact");

                entity.Property(e => e.ZipCode).HasMaxLength(255);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("Contacts_ibfk_1");
            });

            modelBuilder.Entity<ContactsLocation>(entity =>
            {
                entity.HasIndex(e => e.LocationId, "LocationId");

                entity.HasIndex(e => e.TenantId, "TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ContactsLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContactsLocations_ibfk_2");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ContactsLocations)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContactsLocations_ibfk_1");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentCheck).HasColumnType("int(11)");

                entity.Property(e => e.PaymentOption).HasColumnType("int(11)");

                entity.Property(e => e.PaymentPeriod).HasColumnType("int(11)");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plan)
                    .IsRequired()
                    .HasMaxLength(55);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CycleCampaignsTransaction>(entity =>
            {
                entity.HasIndex(e => e.CampaignId, "CampaignId");

                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.CycleNumber).HasColumnType("int(11)");

                entity.Property(e => e.CycleStatus).HasMaxLength(55);

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.CycleCampaignsTransactions)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CycleCampaignsTransactions_ibfk_1");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.CycleCampaignsTransactions)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers");
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ImportHistory>(entity =>
            {
                entity.ToTable("ImportHistory");

                entity.HasIndex(e => e.TenantId, "TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FailReason).HasMaxLength(255);

                entity.Property(e => e.FileLink)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ImportedCount).HasColumnType("int(11)");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ListStatus)
                    .IsRequired()
                    .HasMaxLength(55);

                entity.Property(e => e.NotImportedCount).HasColumnType("int(11)");

                entity.Property(e => e.RecordsCount).HasColumnType("int(11)");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedCount).HasColumnType("int(11)");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ImportHistories)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ImportHistory_ibfk_1");
            });

            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.HasKey(e => e.IdLancamento)
                    .HasName("PRIMARY");

                entity.ToTable("Lancamento");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.IdLancamento)
                    .HasColumnType("int(11)")
                    .HasColumnName("idLancamento");

                entity.Property(e => e.Apolice)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("APOLICE");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_ALTERACAO");

                entity.Property(e => e.DataLancto)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_LANCTO");

                entity.Property(e => e.Endosso)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("ENDOSSO");

                entity.Property(e => e.IdCorretora)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_CORRETORA");

                entity.Property(e => e.IdSeguradora)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_SEGURADORA");

                entity.Property(e => e.MesReferencia)
                    .HasColumnType("date")
                    .HasColumnName("MES_REFERENCIA");

                entity.Property(e => e.Ordem)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("ORDEM");

                entity.Property(e => e.Prc)
                    .HasMaxLength(45)
                    .HasColumnName("PRC");

                entity.Property(e => e.Premio)
                    .HasPrecision(30)
                    .HasColumnName("PREMIO");

                entity.Property(e => e.Ramo)
                    .HasMaxLength(45)
                    .HasColumnName("RAMO");

                entity.Property(e => e.Segurado)
                    .HasMaxLength(45)
                    .HasColumnName("SEGURADO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusContabil)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("STATUS_CONTABIL");

                entity.Property(e => e.Taxa).HasColumnName("TAXA");

                entity.Property(e => e.ValorCms)
                    .HasPrecision(20)
                    .HasColumnName("VALOR_CMS");

                entity.Property(e => e.Vencto)
                    .HasColumnType("date")
                    .HasColumnName("VENCTO");

                entity.Property(e => e.Vigencia)
                    .HasColumnType("date")
                    .HasColumnName("VIGENCIA");
            });

            modelBuilder.Entity<LeadsFollowUp>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.HasIndex(e => e.PropertyId, "FK_Properties");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LeadStatus).HasMaxLength(55);

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(6000);

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.LeadsFollowUpIdNavigation)
                    .HasForeignKey<LeadsFollowUp>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyId");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.LeadsFollowUpProperties)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Properties");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ListDescription).HasMaxLength(5000);

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ListType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CountryCode).HasMaxLength(255);

                entity.Property(e => e.CountryName).HasMaxLength(255);

                entity.Property(e => e.County).HasMaxLength(255);

                entity.Property(e => e.Latitude).HasMaxLength(255);

                entity.Property(e => e.Longitude).HasMaxLength(255);

                entity.Property(e => e.Neighborhood).HasMaxLength(255);

                entity.Property(e => e.StateCode).HasMaxLength(55);

                entity.Property(e => e.StateName).HasMaxLength(255);
            });

            modelBuilder.Entity<LogAccess>(entity =>
            {
                entity.ToTable("LogAccess");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerId).HasMaxLength(255);

                entity.Property(e => e.SourceId).HasMaxLength(255);

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.HasIndex(e => e.PropertyId, "IX_Phones_PropertyId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(255)
                    .HasColumnName("Phone");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Score).HasColumnType("int(11)");

                entity.Property(e => e.SkipTraceDate).HasColumnType("datetime");

                entity.Property(e => e.SkipTraceSource).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<PropertiesList>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.HasIndex(e => e.ListId, "id_list");

                entity.HasIndex(e => e.PropertyId, "id_property");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ListId).HasColumnType("int(11)");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.PropertiesLists)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesLists_ibfk_2");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertiesLists)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesLists_ibfk_1");
            });

            modelBuilder.Entity<PropertiesTag>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.HasIndex(e => e.PropertyId, "PropertyId");

                entity.HasIndex(e => e.TagId, "TagId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.TagId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertiesTags)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesTags_ibfk_1");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PropertiesTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesTags_ibfk_2");
            });

            modelBuilder.Entity<PropertiesTask>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId, "DepartmentId");

                entity.HasIndex(e => e.PropertyId, "PropertyId");

                entity.HasIndex(e => e.TenantId, "TenantId");

                entity.HasIndex(e => e.UserAssignedId, "UserAssignedId");

                entity.HasIndex(e => e.UserId, "UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AssignedType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasMaxLength(767);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FilePath).HasMaxLength(500);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasMaxLength(55);

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.RepeatFinalDate).HasColumnType("datetime");

                entity.Property(e => e.RepeatFrequency)
                    .IsRequired()
                    .HasMaxLength(55);

                entity.Property(e => e.TaskStatus)
                    .IsRequired()
                    .HasMaxLength(55);

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserAssignedId).HasMaxLength(767);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(767);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PropertiesTasks)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("PropertiesTasks_ibfk_5");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertiesTasks)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesTasks_ibfk_2");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PropertiesTasks)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesTasks_ibfk_1");

                entity.HasOne(d => d.UserAssigned)
                    .WithMany(p => p.PropertiesTaskUserAssigneds)
                    .HasForeignKey(d => d.UserAssignedId)
                    .HasConstraintName("PropertiesTasks_ibfk_4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PropertiesTaskUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesTasks_ibfk_3");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.HasIndex(e => e.PropertyAddress, "PropertiesAddress");

                entity.HasIndex(e => e.PropertyCity, "PropertiesCity");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApnNumber).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriticalStatus).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Email2).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.HotLead).HasMaxLength(255);

                entity.Property(e => e.IsMailingVacant).HasMaxLength(255);

                entity.Property(e => e.IsVacant).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LastSalePrice).HasMaxLength(255);

                entity.Property(e => e.LastStaleDate).HasMaxLength(255);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MailingAddress).HasMaxLength(255);

                entity.Property(e => e.MailingCity).HasMaxLength(255);

                entity.Property(e => e.MailingCounty).HasMaxLength(255);

                entity.Property(e => e.MailingState).HasMaxLength(255);

                entity.Property(e => e.MailingZip).HasMaxLength(255);

                entity.Property(e => e.MatchCrm).HasMaxLength(255);

                entity.Property(e => e.MlsStatus).HasMaxLength(255);

                entity.Property(e => e.OptOut).HasMaxLength(255);

                entity.Property(e => e.Owner2FirstName).HasMaxLength(255);

                entity.Property(e => e.Owner2LastName).HasMaxLength(255);

                entity.Property(e => e.OwnerOccupied).HasMaxLength(255);

                entity.Property(e => e.PrimaryListSource).HasMaxLength(255);

                entity.Property(e => e.PrimaryListType).HasMaxLength(255);

                entity.Property(e => e.PropertyAddress).IsRequired();

                entity.Property(e => e.PropertyCity).IsRequired();

                entity.Property(e => e.PropertyCounty).HasMaxLength(255);

                entity.Property(e => e.PropertyState)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyType).HasMaxLength(45);

                entity.Property(e => e.PropertyTypeDetail).HasMaxLength(255);

                entity.Property(e => e.PropertyZip).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenLienBalance).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ZoningCode).HasMaxLength(255);
            });

            modelBuilder.Entity<RecycledCampaignsList>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CallStartTime).HasColumnType("datetime");

                entity.Property(e => e.CallType).HasMaxLength(255);

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.Cellphone).HasMaxLength(255);

                entity.Property(e => e.ContactSucess)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CycleNumber).HasColumnType("int(11)");

                entity.Property(e => e.DialNumberType).HasMaxLength(255);

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.DispositionForRecyle).HasMaxLength(255);

                entity.Property(e => e.Faxphone).HasMaxLength(255);

                entity.Property(e => e.Homephone).HasMaxLength(255);

                entity.Property(e => e.ListName).HasMaxLength(255);

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutboundCallerId)
                    .HasMaxLength(255)
                    .HasColumnName("OutboundCallerID");

                entity.Property(e => e.PhoneId).HasColumnType("int(11)");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.ReasonCode).HasMaxLength(255);

                entity.Property(e => e.RecordingFileName).HasMaxLength(255);

                entity.Property(e => e.Recycle).HasMaxLength(255);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SecondaryVoicePhone).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.User).HasMaxLength(255);

                entity.Property(e => e.VoicePhone).HasMaxLength(255);
            });

            //modelBuilder.Entity<Seguradora>(entity =>
            //{
            //    entity.HasKey(e => e.IdSeguradora)
            //        .HasName("PRIMARY");

            //    entity.ToTable("Seguradora");

            //    entity.HasCharSet("utf8")
            //        .UseCollation("utf8_unicode_ci");

            //    entity.Property(e => e.IdSeguradora)
            //        .HasColumnType("int(11)")
            //        .HasColumnName("idSeguradora");

            //    entity.Property(e => e.Cnpj)
            //        .IsRequired()
            //        .HasMaxLength(45)
            //        .HasColumnName("CNPJ");

            //    entity.Property(e => e.DataCadastro).HasColumnType("datetime");

            //    entity.Property(e => e.NomeSeguradora)
            //        .IsRequired()
            //        .HasMaxLength(45)
            //        .HasColumnName("nomeSeguradora");

            //    entity.Property(e => e.Ramo)
            //        .IsRequired()
            //        .HasMaxLength(45)
            //        .HasColumnName("RAMO");

            //    entity.Property(e => e.StatusSeguradora)
            //        .IsRequired()
            //        .HasMaxLength(45);
            //});

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TagDescription).HasMaxLength(5000);

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TagType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TransactionsCampaign>(entity =>
            {
                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TenantId, "FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

        //    modelBuilder.Entity<VehiclesOnMarket>(entity =>
        //    {
        //        entity.ToTable("VehiclesOnMarket");

        //        entity.Property(e => e.Id)
        //            .HasColumnType("int(11)")
        //            .HasColumnName("id");

        //        entity.Property(e => e.AvailableStatus).HasMaxLength(55);

        //        entity.Property(e => e.Description).HasMaxLength(15000);

        //        entity.Property(e => e.Email).HasMaxLength(255);

        //        entity.Property(e => e.ExtractTime).HasMaxLength(255);

        //        entity.Property(e => e.FollowUp).HasMaxLength(55);

        //        entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

        //        entity.Property(e => e.FollowUpUser).HasMaxLength(255);

        //        entity.Property(e => e.Location).HasMaxLength(255);

        //        entity.Property(e => e.Notes).HasMaxLength(5000);

        //        entity.Property(e => e.Odometer).HasPrecision(10);

        //        entity.Property(e => e.Phone).HasMaxLength(255);

        //        entity.Property(e => e.Photos).HasMaxLength(10000);

        //        entity.Property(e => e.Price).HasPrecision(10);

        //        entity.Property(e => e.PublishDate).HasColumnType("datetime");

        //        entity.Property(e => e.RadiusDistance).HasMaxLength(255);

        //        entity.Property(e => e.SaleStatus).HasMaxLength(55);

        //        entity.Property(e => e.Seller).HasMaxLength(255);

        //        entity.Property(e => e.SellerType).HasMaxLength(255);

        //        entity.Property(e => e.SourceId).HasColumnType("bigint(20)");

        //        entity.Property(e => e.SourceName).HasMaxLength(55);

        //        entity.Property(e => e.SourceType).HasMaxLength(55);

        //        entity.Property(e => e.Titlestatus).HasMaxLength(255);

        //        entity.Property(e => e.Transmition).HasMaxLength(255);

        //        entity.Property(e => e.UrlVehicle).HasMaxLength(2000);

        //        entity.Property(e => e.VehicleFull).HasMaxLength(255);

        //        entity.Property(e => e.VehicleFullDecoded).HasMaxLength(255);

        //        entity.Property(e => e.VehicleMake).HasMaxLength(255);

        //        entity.Property(e => e.VehicleModel).HasMaxLength(255);

        //        entity.Property(e => e.VehicleSeries).HasMaxLength(255);

        //        entity.Property(e => e.VehicleYear).HasMaxLength(255);

        //        entity.Property(e => e.Vin).HasMaxLength(255);
        //    });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

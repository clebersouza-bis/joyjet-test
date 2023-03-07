using System;
using Bridge.ERP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP.Data
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

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactsLocation> ContactsLocations { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CycleCampaignsTransaction> CycleCampaignsTransactions { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistory { get; set; }
        public virtual DbSet<ImportHistory> ImportHistory { get; set; }
        public virtual DbSet<Lancamento> Lancamento { get; set; }
        public virtual DbSet<LeadsFollowUp> LeadsFollowUps { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LogAccess> LogAccess { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertiesList> PropertiesLists { get; set; }
        public virtual DbSet<PropertiesTag> PropertiesTags { get; set; }
        public virtual DbSet<PropertiesTask> PropertiesTasks { get; set; }
        public virtual DbSet<ProviderHistoryCall> ProviderHistoryCalls { get; set; }
        public virtual DbSet<RecycledCampaignsList> RecycledCampaignsLists { get; set; }
        public virtual DbSet<Seguradora> Seguradora { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ThirdPartProvider> ThirdPartProviders { get; set; }
        public virtual DbSet<TransactionsCampaign> TransactionsCampaigns { get; set; }
        public virtual DbSet<VehiclesOnMarket> VehiclesOnMarket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=bidbdesenv.mysql.dbaas.com.br;database=bidbdesenv;user id=bidbdesenv;pwd=b*[2021];treattinyasboolean=true;AllowZeroDateTime=True;ConvertZeroDateTime=True", x => x.ServerVersion("5.7.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(767)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ConcurrencyStamp)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.NormalizedName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(767)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp");

                entity.Property(e => e.NormalizedEmail)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.NormalizedUserName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.PasswordHash)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SecurityStamp)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.TenantId)
                   .HasColumnName("TenantId")
                   .HasColumnType("int(11)");


                //entity.HasOne(d => d.Customer);

                entity.Property(e => e.ThirdPartyId)
                       .HasColumnType("int(11)");

                entity.Property(e => e.ThirdPartyCampaignId)
                       .HasColumnType("int(11)");

                entity.Property(e => e.Id).HasColumnType("int(11)");
                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MarketType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pipeline)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

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

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Datacadastro)
                    .HasColumnName("DATACADASTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.Address)
                    .HasName("IndexAddress");

                entity.HasIndex(e => e.City)
                    .HasName("IndexCity");

                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CompanyName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ContactType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedType)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CriticalStatus)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Email2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.MainCity)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.MainState)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SourceName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Vipcontact)
                    .HasColumnName("VIPContact")
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ZipCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("Contacts_ibfk_1");
            });

            modelBuilder.Entity<ContactsLocation>(entity =>
            {
                entity.HasIndex(e => e.LocationId)
                    .HasName("LocationId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

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
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.IpAddress)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.PaymentCheck).HasColumnType("int(11)");

                entity.Property(e => e.PaymentOption).HasColumnType("int(11)");

                entity.Property(e => e.PaymentPeriod).HasColumnType("int(11)");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Plan)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CycleCampaignsTransaction>(entity =>
            {
                entity.HasIndex(e => e.CampaignId)
                    .HasName("CampaignId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.CycleNumber).HasColumnType("int(11)");

                entity.Property(e => e.CycleStatus)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

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

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            modelBuilder.Entity<ImportHistory>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FailReason)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FileLink)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ImportedCount).HasColumnType("int(11)");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ListStatus)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

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

                entity.Property(e => e.IdLancamento)
                    .HasColumnName("idLancamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apolice)
                    .IsRequired()
                    .HasColumnName("APOLICE")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("DATA_ALTERACAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataLancto)
                    .HasColumnName("DATA_LANCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Endosso)
                    .IsRequired()
                    .HasColumnName("ENDOSSO")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IdCorretora)
                    .HasColumnName("ID_CORRETORA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSeguradora)
                    .HasColumnName("ID_SEGURADORA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MesReferencia)
                    .HasColumnName("MES_REFERENCIA")
                    .HasColumnType("date");

                entity.Property(e => e.Ordem)
                    .IsRequired()
                    .HasColumnName("ORDEM")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Prc)
                    .HasColumnName("PRC")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Premio)
                    .HasColumnName("PREMIO")
                    .HasColumnType("decimal(30,0)");

                entity.Property(e => e.Ramo)
                    .HasColumnName("RAMO")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Segurado)
                    .HasColumnName("SEGURADO")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StatusContabil)
                    .IsRequired()
                    .HasColumnName("STATUS_CONTABIL")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Taxa).HasColumnName("TAXA");

                entity.Property(e => e.ValorCms)
                    .HasColumnName("VALOR_CMS")
                    .HasColumnType("decimal(20,0)");

                entity.Property(e => e.Vencto)
                    .HasColumnName("VENCTO")
                    .HasColumnType("date");

                entity.Property(e => e.Vigencia)
                    .HasColumnName("VIGENCIA")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<LeadsFollowUp>(entity =>
            {
                entity.HasIndex(e => e.PropertyId)
                    .HasName("FK_Properties");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LeadStatus)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(6000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

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
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ListDescription)
                    .HasColumnType("varchar(5000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ListType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CountryCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CountryName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.County)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Latitude)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Longitude)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Neighborhood)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.StateCode)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.StateName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            modelBuilder.Entity<LogAccess>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SourceId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasIndex(e => e.PropertyId);

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Score).HasColumnType("int(11)");

                entity.Property(e => e.SkipTraceDate).HasColumnType("datetime");

                entity.Property(e => e.SkipTraceSource)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

              //entity.Property(e => e.TenantId).HasColumnType("int(11)");
                entity.Property(e => e.TenantId)
                   .HasColumnName("TenantId")
                   .HasColumnType("int(11)");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");
                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertiesPhones_ibfk_1");
                
                entity.Property(e => e.Type)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasIndex(e => e.PropertyAddress)
                    .HasName("PropertiesAddress");

                entity.HasIndex(e => e.PropertyCity)
                    .HasName("PropertiesCity");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApnNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriticalStatus)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HotLead)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsMailingVacant)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsVacant)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastSalePrice)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastStaleDate)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MailingAddress)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MailingCity)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MailingCounty)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MailingState)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MailingZip)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatchCrm)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MlsStatus)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OptOut)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner2FirstName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner2LastName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerOccupied)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrimaryListSource)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrimaryListType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyCity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyCounty)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyState)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyType)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyTypeDetail)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyZip)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenLienBalance)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ZoningCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PropertiesList>(entity =>
            {
                entity.HasIndex(e => e.ListId)
                    .HasName("id_list");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("id_property");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

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
                entity.HasIndex(e => e.PropertyId)
                    .HasName("PropertyId");

                entity.HasIndex(e => e.TagId)
                    .HasName("TagId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

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
                entity.HasIndex(e => e.DepartmentId)
                    .HasName("DepartmentId");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("PropertyId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

                entity.HasIndex(e => e.UserAssignedId)
                    .HasName("UserAssignedId");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AssignedType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("varchar(767)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasColumnType("varchar(500)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.RepeatFinalDate).HasColumnType("datetime");

                entity.Property(e => e.RepeatFrequency)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TaskStatus)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserAssignedId)
                    .HasColumnType("varchar(767)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(767)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
                    

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

            modelBuilder.Entity<ProviderHistoryCall>(entity =>
            {
                entity.HasIndex(e => e.ProviderId)
                    .HasName("ProviderId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AgentName)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CallDisposition)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CallDuration).HasColumnType("int(11)");

                entity.Property(e => e.CallId)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CallRecordPath)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CallStartDate).HasColumnType("datetime");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.CampaignName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ContactDisposition)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ContactId).HasColumnType("int(11)");

                entity.Property(e => e.DestinationPhone)
                    .HasColumnType("varchar(25)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.DirectionType)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.OutboundPhoneId)
                    .HasColumnType("varchar(25)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.ProviderId).HasColumnType("int(11)");

                entity.Property(e => e.SystemDisposition)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderHistoryCalls)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProviderHistoryCalls_ibfk_2");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProviderHistoryCall)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProviderHistoryCalls_ibfk_1");
            });

            modelBuilder.Entity<RecycledCampaignsList>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CallStartTime).HasColumnType("datetime");

                entity.Property(e => e.CallType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.Cellphone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactSucess)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CycleNumber).HasColumnType("int(11)");

                entity.Property(e => e.DialNumberType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Disposition)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DispositionForRecyle)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Faxphone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Homephone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ListName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutboundCallerId)
                    .HasColumnName("OutboundCallerID")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneId).HasColumnType("int(11)");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.ReasonCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RecordingFileName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Recycle)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SecondaryVoicePhone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.User)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VoicePhone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Seguradora>(entity =>
            {
                entity.HasKey(e => e.IdSeguradora)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSeguradora)
                    .HasColumnName("idSeguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.NomeSeguradora)
                    .IsRequired()
                    .HasColumnName("nomeSeguradora")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ramo)
                    .IsRequired()
                    .HasColumnName("RAMO")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StatusSeguradora)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TagDescription)
                    .HasColumnType("varchar(5000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TagType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ThirdPartProvider>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ProviderType)
                    .IsRequired()
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransactionsCampaign>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx2");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<VehiclesOnMarket>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvailableStatus)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(15000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.ExtractTime)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FollowUp)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpUser)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(5000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Odometer).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Photos)
                    .HasColumnType("varchar(10000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Price).HasColumnType("decimal(10,0)");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.RadiusDistance)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SaleStatus)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Seller)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SellerType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SourceId).HasColumnType("bigint(20)");

                entity.Property(e => e.SourceName)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.SourceType)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Titlestatus)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Transmition)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.UrlVehicle)
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.VehicleFull)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.VehicleFullDecoded)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.VehicleMake)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.VehicleModel)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.VehicleSeries)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.VehicleYear)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");

                entity.Property(e => e.Vin)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

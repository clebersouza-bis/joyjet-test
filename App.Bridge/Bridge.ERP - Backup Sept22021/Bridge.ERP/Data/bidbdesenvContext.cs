using System;
using Bridge.ERP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bridge.ERP
{
    public partial class bidbdesenvContext : IdentityDbContext
    {
        public bidbdesenvContext()
        {
        }

        public bidbdesenvContext(DbContextOptions<bidbdesenvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<ContactsLocations> ContactsLocations { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CycleCampaignsTransactions> CycleCampaignsTransactions { get; set; }
        public virtual DbSet<ImportHistory> ImportHistory { get; set; }
        public virtual DbSet<Lancamento> Lancamento { get; set; }
        public virtual DbSet<LeadsFollowUps> LeadsFollowUps { get; set; }
        public virtual DbSet<Lists> Lists { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<LogAccess> LogAccess { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<PropertiesLists> PropertiesLists { get; set; }
        public virtual DbSet<PropertiesTags> PropertiesTags { get; set; }
        public virtual DbSet<RecycledCampaignsLists> RecycledCampaignsLists { get; set; }
        public virtual DbSet<Seguradora> Seguradora { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<TransactionsCampaigns> TransactionsCampaigns { get; set; }
        public virtual DbSet<VehiclesOnMarket> VehiclesOnMarket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=bidbdesenv.mysql.dbaas.com.br;Database=bidbdesenv;Uid=bidbdesenv;Pwd=b*[2021]");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.MarketType).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Pipeline).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
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
                    .HasMaxLength(255);

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
                    .HasMaxLength(45);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(45);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasIndex(e => e.Address)
                    .HasName("IndexAddress");

                entity.HasIndex(e => e.City)
                    .HasName("IndexCity");

                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactType).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(55);

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

                entity.Property(e => e.Vipcontact)
                    .HasColumnName("VIPContact")
                    .HasMaxLength(55);

                entity.Property(e => e.ZipCode).HasMaxLength(255);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("Contacts_ibfk_1");
            });

            modelBuilder.Entity<ContactsLocations>(entity =>
            {
                entity.HasIndex(e => e.LocationId)
                    .HasName("LocationId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

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

            modelBuilder.Entity<Customers>(entity =>
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
            });

            modelBuilder.Entity<CycleCampaignsTransactions>(entity =>
            {
                entity.HasIndex(e => e.CampaignId)
                    .HasName("CampaignId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

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

            modelBuilder.Entity<ImportHistory>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("TenantId");

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

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedCount).HasColumnType("int(11)");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ImportHistory)
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
                    .HasMaxLength(45);

                entity.Property(e => e.Endosso)
                    .IsRequired()
                    .HasColumnName("ENDOSSO")
                    .HasMaxLength(45);

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
                    .HasMaxLength(45);

                entity.Property(e => e.Prc)
                    .HasColumnName("PRC")
                    .HasMaxLength(45);

                entity.Property(e => e.Premio)
                    .HasColumnName("PREMIO")
                    .HasColumnType("decimal(30,0)");

                entity.Property(e => e.Ramo)
                    .HasColumnName("RAMO")
                    .HasMaxLength(45);

                entity.Property(e => e.Segurado)
                    .HasColumnName("SEGURADO")
                    .HasMaxLength(45);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(45);

                entity.Property(e => e.StatusContabil)
                    .IsRequired()
                    .HasColumnName("STATUS_CONTABIL")
                    .HasMaxLength(45);

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

            modelBuilder.Entity<LeadsFollowUps>(entity =>
            {
                entity.HasIndex(e => e.PropertyId)
                    .HasName("FK_Properties");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LeadStatus).HasMaxLength(55);

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Notes).HasColumnType("varchar(6000)");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.LeadsFollowUpsIdNavigation)
                    .HasForeignKey<LeadsFollowUps>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyId");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.LeadsFollowUpsProperty)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Properties");
            });

            modelBuilder.Entity<Lists>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ListDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ListType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Locations>(entity =>
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
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComputerId).HasMaxLength(255);

                entity.Property(e => e.SourceId).HasMaxLength(255);

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<Phones>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.Score).HasColumnType("int(11)");

                entity.Property(e => e.SkipTraceSource).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<Properties>(entity =>
            {
                entity.HasIndex(e => e.PropertyAddress)
                    .HasName("PropertiesAddress");

                entity.HasIndex(e => e.PropertyCity)
                    .HasName("PropertiesCity");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApnNumber).HasMaxLength(255);

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

                entity.Property(e => e.PropertyAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyCity)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyCounty).HasMaxLength(255);

                entity.Property(e => e.PropertyState)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyType).HasMaxLength(45);

                entity.Property(e => e.PropertyTypeDetail).HasMaxLength(255);

                entity.Property(e => e.PropertyZip).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenLienBalance).HasMaxLength(255);

                entity.Property(e => e.ZoningCode).HasMaxLength(255);
            });

            modelBuilder.Entity<PropertiesLists>(entity =>
            {
                entity.HasIndex(e => e.ListId)
                    .HasName("id_list");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("id_property");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

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

            modelBuilder.Entity<PropertiesTags>(entity =>
            {
                entity.HasIndex(e => e.PropertyId)
                    .HasName("PropertyId");

                entity.HasIndex(e => e.TagId)
                    .HasName("TagId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

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

            modelBuilder.Entity<RecycledCampaignsLists>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

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

                entity.Property(e => e.Note).HasColumnType("longtext");

                entity.Property(e => e.OutboundCallerId)
                    .HasColumnName("OutboundCallerID")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneId).HasColumnType("int(11)");

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.ReasonCode).HasMaxLength(255);

                entity.Property(e => e.RecordingFileName).HasMaxLength(255);

                entity.Property(e => e.Recycle).HasMaxLength(255);

                entity.Property(e => e.SecondaryVoicePhone).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");

                entity.Property(e => e.User).HasMaxLength(255);

                entity.Property(e => e.VoicePhone).HasMaxLength(255);
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
                    .HasMaxLength(45);

                entity.Property(e => e.NomeSeguradora)
                    .IsRequired()
                    .HasColumnName("nomeSeguradora")
                    .HasMaxLength(45);

                entity.Property(e => e.Ramo)
                    .IsRequired()
                    .HasColumnName("RAMO")
                    .HasMaxLength(45);

                entity.Property(e => e.StatusSeguradora)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.TagDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TagType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TransactionsCampaigns>(entity =>
            {
                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_Customers_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CampaignId).HasColumnType("int(11)");

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyId).HasColumnType("int(11)");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TenantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<VehiclesOnMarket>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvailableStatus).HasMaxLength(55);

                entity.Property(e => e.Description).HasColumnType("varchar(15000)");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.ExtractTime).HasMaxLength(255);

                entity.Property(e => e.FollowUp).HasMaxLength(55);

                entity.Property(e => e.FollowUpUser).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.Odometer).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Photos).HasColumnType("varchar(10000)");

                entity.Property(e => e.Price).HasColumnType("decimal(10,0)");

                entity.Property(e => e.RadiusDistance).HasMaxLength(255);

                entity.Property(e => e.SaleStatus).HasMaxLength(55);

                entity.Property(e => e.Seller).HasMaxLength(255);

                entity.Property(e => e.SellerType).HasMaxLength(255);

                entity.Property(e => e.SourceId).HasColumnType("bigint(20)");

                entity.Property(e => e.SourceName).HasMaxLength(55);

                entity.Property(e => e.SourceType).HasMaxLength(55);

                entity.Property(e => e.Titlestatus).HasMaxLength(255);

                entity.Property(e => e.Transmition).HasMaxLength(255);

                entity.Property(e => e.UrlVehicle).HasMaxLength(2000);

                entity.Property(e => e.VehicleFull).HasMaxLength(255);

                entity.Property(e => e.VehicleFullDecoded).HasMaxLength(255);

                entity.Property(e => e.VehicleMake).HasMaxLength(255);

                entity.Property(e => e.VehicleModel).HasMaxLength(255);

                entity.Property(e => e.VehicleSeries).HasMaxLength(255);

                entity.Property(e => e.VehicleYear).HasMaxLength(255);

                entity.Property(e => e.Vin).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

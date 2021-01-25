//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//#nullable disable

//namespace PowerDama.Types.DataGovernance
//{
//    public partial class BOACatalogContext : DbContext
//    {
//        public BOACatalogContext()
//        {
//        }

//        public BOACatalogContext(DbContextOptions<BOACatalogContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Accessibility> Accessibilities { get; set; }
//        public virtual DbSet<Activity> Activities { get; set; }
//        public virtual DbSet<Attribute> Attributes { get; set; }
//        public virtual DbSet<BusinessProcess> BusinessProcesses { get; set; }
//        public virtual DbSet<Clarification> Clarifications { get; set; }
//        public virtual DbSet<ColumnRule> ColumnRules { get; set; }
//        public virtual DbSet<CostIntroduction> CostIntroductions { get; set; }
//        public virtual DbSet<CustomerAgreement> CustomerAgreements { get; set; }
//        public virtual DbSet<CustomerDataRequest> CustomerDataRequests { get; set; }
//        public virtual DbSet<CustomerDataRequestDetail> CustomerDataRequestDetails { get; set; }
//        public virtual DbSet<DataCategory> DataCategories { get; set; }
//        public virtual DbSet<DataProcessingDataResponsibleRelationship> DataProcessingDataResponsibleRelationships { get; set; }
//        public virtual DbSet<DataType> DataTypes { get; set; }
//        public virtual DbSet<DataTypeLanguage> DataTypeLanguages { get; set; }
//        public virtual DbSet<DataTypeMatch> DataTypeMatches { get; set; }
//        public virtual DbSet<DatabaseLocation> DatabaseLocations { get; set; }
//        public virtual DbSet<Entity> Entities { get; set; }
//        public virtual DbSet<ExplicitConsent> ExplicitConsents { get; set; }
//        public virtual DbSet<InformationType> InformationTypes { get; set; }
//        public virtual DbSet<Integrity> Integrities { get; set; }
//        public virtual DbSet<Kvkkinventory> Kvkkinventories { get; set; }
//        public virtual DbSet<LegalBasis> LegalBases { get; set; }
//        public virtual DbSet<MeasuresTaken> MeasuresTakens { get; set; }
//        public virtual DbSet<Parameter> Parameters { get; set; }
//        public virtual DbSet<ProcessingPurpose> ProcessingPurposes { get; set; }
//        public virtual DbSet<Property> Properties { get; set; }
//        public virtual DbSet<PropertyValue> PropertyValues { get; set; }
//        public virtual DbSet<RelatedPerson> RelatedPeople { get; set; }
//        public virtual DbSet<RetentionTime> RetentionTimes { get; set; }
//        public virtual DbSet<ScriptDefinition> ScriptDefinitions { get; set; }
//        public virtual DbSet<ScriptInventory> ScriptInventories { get; set; }
//        public virtual DbSet<Sensitivity> Sensitivities { get; set; }
//        public virtual DbSet<Status> Statuses { get; set; }
//        public virtual DbSet<SupplyContract> SupplyContracts { get; set; }
//        public virtual DbSet<Table> Tables { get; set; }
//        public virtual DbSet<TableColumn> TableColumns { get; set; }
//        public virtual DbSet<TableColumnDataMask> TableColumnDataMasks { get; set; }
//        public virtual DbSet<TableColumnDataMaskBfix> TableColumnDataMaskBfixes { get; set; }
//        public virtual DbSet<TableColumnDataMaskDetail> TableColumnDataMaskDetails { get; set; }
//        public virtual DbSet<TableColumnDraft> TableColumnDrafts { get; set; }
//        public virtual DbSet<TableColumnProperty> TableColumnProperties { get; set; }
//        public virtual DbSet<TableDataMaskException> TableDataMaskExceptions { get; set; }
//        public virtual DbSet<TableDesignPackage> TableDesignPackages { get; set; }
//        public virtual DbSet<TableDraft> TableDrafts { get; set; }
//        public virtual DbSet<TableOld1> TableOld1s { get; set; }
//        public virtual DbSet<TableOld2> TableOld2s { get; set; }
//        public virtual DbSet<TableUseStatistic> TableUseStatistics { get; set; }
//        public virtual DbSet<TemplateType> TemplateTypes { get; set; }
//        public virtual DbSet<Term> Terms { get; set; }
//        public virtual DbSet<TermDataMask> TermDataMasks { get; set; }
//        public virtual DbSet<TermDataMaskWhiteList> TermDataMaskWhiteLists { get; set; }
//        public virtual DbSet<TermRecommendation> TermRecommendations { get; set; }
//        public virtual DbSet<TermRule> TermRules { get; set; }
//        public virtual DbSet<TermTextApprovalJournal> TermTextApprovalJournals { get; set; }
//        public virtual DbSet<TermWork> TermWorks { get; set; }
//        public virtual DbSet<TransferAbroad> TransferAbroads { get; set; }
//        public virtual DbSet<TransferredContactGroup> TransferredContactGroups { get; set; }
//        public virtual DbSet<UpdateItemAuthorizationForTableDdlscript> UpdateItemAuthorizationForTableDdlscripts { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BOACatalog;Trusted_Connection=True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<Accessibility>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Accessibility", "DTG");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Activity>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Activity", "DTG");

//                entity.Property(e => e.ActivityId).ValueGeneratedOnAdd();

//                entity.Property(e => e.ActivityName)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Attribute>(entity =>
//            {
//                entity.ToTable("Attribute", "DTG");

//                entity.Property(e => e.DataType)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.IsCollection).HasDefaultValueSql("((0))");

//                entity.Property(e => e.IsKey).HasDefaultValueSql("((0))");

//                entity.Property(e => e.Nullable).HasDefaultValueSql("((1))");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<BusinessProcess>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("BusinessProcess", "DTG");

//                entity.Property(e => e.BusinessProcessId).ValueGeneratedOnAdd();

//                entity.Property(e => e.BusinessProcessName)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Clarification>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Clarification", "DTG");

//                entity.Property(e => e.ClarificationId).ValueGeneratedOnAdd();

//                entity.Property(e => e.ClarificationName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ColumnRule>(entity =>
//            {
//                entity.ToTable("ColumnRule", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.DataType)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<CostIntroduction>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CostIntroduction", "DTG");

//                entity.Property(e => e.Amount)
//                    .HasColumnType("decimal(22, 2)")
//                    .HasColumnName("amount");

//                entity.Property(e => e.CostIntroductionId).ValueGeneratedOnAdd();

//                entity.Property(e => e.Costtype).HasColumnName("costtype");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false)
//                    .HasColumnName("description");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<CustomerAgreement>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CustomerAgreement", "DTG");

//                entity.Property(e => e.CustomerAgreementId).ValueGeneratedOnAdd();

//                entity.Property(e => e.CustomerAgreementName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<CustomerDataRequest>(entity =>
//            {
//                entity.HasKey(e => e.UniqueKeyForCustomer)
//                    .HasName("pkCustomerDataRequest");

//                entity.ToTable("CustomerDataRequest", "DTG");

//                entity.Property(e => e.UniqueKeyForCustomer)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CustomerDataRequestId).ValueGeneratedOnAdd();

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProcessBeginDate).HasColumnType("datetime");

//                entity.Property(e => e.ProcessEndDate).HasColumnType("datetime");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<CustomerDataRequestDetail>(entity =>
//            {
//                entity.ToTable("CustomerDataRequestDetail", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SearchValue)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<DataCategory>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("DataCategory", "DTG");

//                entity.Property(e => e.DataCategory1)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false)
//                    .HasColumnName("DataCategory");

//                entity.Property(e => e.DataCategoryId).ValueGeneratedOnAdd();

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<DataProcessingDataResponsibleRelationship>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("DataProcessingDataResponsibleRelationship", "DTG");

//                entity.Property(e => e.DataProcessingDataResponsibleRelationshipId).ValueGeneratedOnAdd();

//                entity.Property(e => e.DataProcessingDataResponsibleRelationshipName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<DataType>(entity =>
//            {
//                entity.ToTable("DataType", "DTG");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("NameEN");
//            });

//            modelBuilder.Entity<DataTypeLanguage>(entity =>
//            {
//                entity.ToTable("DataTypeLanguage", "DTG");

//                entity.Property(e => e.DataTypeLanguageId).ValueGeneratedOnAdd();

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("NameEN");
//            });

//            modelBuilder.Entity<DataTypeMatch>(entity =>
//            {
//                entity.HasKey(e => new { e.DataTypeId, e.DataTypeLanguageId })
//                    .HasName("PK_DataTypeMatching_1");

//                entity.ToTable("DataTypeMatch", "DTG");

//                entity.Property(e => e.Value)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<DatabaseLocation>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("DatabaseLocation", "DTG");

//                entity.Property(e => e.Dbname)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.Environment)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Location)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Type)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Entity>(entity =>
//            {
//                entity.ToTable("Entity", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Namespace)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ExplicitConsent>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("ExplicitConsent", "DTG");

//                entity.Property(e => e.ExplicitConsentId).ValueGeneratedOnAdd();

//                entity.Property(e => e.ExplicitConsentName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<InformationType>(entity =>
//            {
//                entity.HasKey(e => new { e.InformationTypeId, e.LanguageId })
//                    .HasName("PK_DTG_InformationType");

//                entity.ToTable("InformationType", "DTG");

//                entity.Property(e => e.LanguageId).HasDefaultValueSql("((1))");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Integrity>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Integrity", "DTG");

//                entity.Property(e => e.IntegrityId).HasColumnName("integrityId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Kvkkinventory>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KVKKInventory", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KvkkinventoryId)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("KVKKInventoryId");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<LegalBasis>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("LegalBasis", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.LegalBasisId).ValueGeneratedOnAdd();

//                entity.Property(e => e.LegalBasisName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<MeasuresTaken>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("MeasuresTaken", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.MeasuresTakenId).ValueGeneratedOnAdd();

//                entity.Property(e => e.MeasuresTakenName)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Parameter>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Parameter", "DTG");

//                entity.Property(e => e.ParamCode)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamDescription)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamType)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamValue)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamValue2)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamValue3)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamValue4)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParamValue5)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ProcessingPurpose>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("ProcessingPurpose", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProcessingPurpose1)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false)
//                    .HasColumnName("ProcessingPurpose");

//                entity.Property(e => e.ProcessingPurposeId).ValueGeneratedOnAdd();

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Property>(entity =>
//            {
//                entity.ToTable("Property", "DTG");

//                entity.Property(e => e.Description).HasMaxLength(500);

//                entity.Property(e => e.DescriptionEn)
//                    .HasMaxLength(500)
//                    .HasColumnName("DescriptionEN");

//                entity.Property(e => e.HostIp)
//                    .IsRequired()
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name).HasMaxLength(255);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(255)
//                    .HasColumnName("NameEN");

//                entity.Property(e => e.ParameterType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.PropertyCode)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<PropertyValue>(entity =>
//            {
//                entity.ToTable("PropertyValue", "DTG");

//                entity.Property(e => e.DateValue).HasColumnType("datetime");

//                entity.Property(e => e.HostIp)
//                    .IsRequired()
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.NumericValue).HasColumnType("decimal(10, 4)");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TextValue).HasMaxLength(255);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<RelatedPerson>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("RelatedPerson", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RelatedPersonId).ValueGeneratedOnAdd();

//                entity.Property(e => e.RelatedPersonName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<RetentionTime>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("RetentionTime", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RetentionTimeId).ValueGeneratedOnAdd();

//                entity.Property(e => e.RetentionTimePeriod)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ScriptDefinition>(entity =>
//            {
//                entity.ToTable("ScriptDefinition", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ScriptGroup)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ScriptTag)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.ScriptText)
//                    .IsRequired()
//                    .HasMaxLength(5000)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ScriptInventory>(entity =>
//            {
//                entity.ToTable("ScriptInventory", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DatabaseName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Sensitivity>(entity =>
//            {
//                entity.HasKey(e => new { e.SensitivityId, e.LanguageId })
//                    .HasName("PK_DTG_Sensitivity");

//                entity.ToTable("Sensitivity", "DTG");

//                entity.Property(e => e.LanguageId).HasDefaultValueSql("((1))");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Status>(entity =>
//            {
//                entity.ToTable("Status", "DTG");

//                entity.Property(e => e.StatusId).ValueGeneratedNever();

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("NameEN");
//            });

//            modelBuilder.Entity<SupplyContract>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("SupplyContract", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SupplyContractId).ValueGeneratedOnAdd();

//                entity.Property(e => e.SupplyContractName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Table>(entity =>
//            {
//                entity.ToTable("Table", "DTG");

//                entity.Property(e => e.Dbname)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.DevVersion).HasDefaultValueSql("((1))");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.IsEntity).HasDefaultValueSql("((0))");

//                entity.Property(e => e.LogTableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableColumn>(entity =>
//            {
//                entity.ToTable("TableColumn", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.DataType)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nullable).HasDefaultValueSql("((1))");
//            });

//            modelBuilder.Entity<TableColumnDataMask>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TableColumnDataMask", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Dbname)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.SchemaName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubsetCriteria)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubsetOperator)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.TableName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableColumnDataMaskBfix>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TableColumnDataMaskBFix", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DatabaseName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.PhysicalDataType)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableColumnDataMaskDetail>(entity =>
//            {
//                entity.ToTable("TableColumnDataMaskDetail", "DTG");

//                entity.Property(e => e.BugFix)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Clone)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ColumnName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.DataMaskType)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DataType)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DatabaseName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Development)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.FullColumnName)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.PreProduction)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Production)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Replication)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubsetCriteria)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubsetOperator)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.TableName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TermName)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.Test)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableColumnDraft>(entity =>
//            {
//                entity.ToTable("TableColumnDraft", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.DataType)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nullable).HasDefaultValueSql("((1))");
//            });

//            modelBuilder.Entity<TableColumnProperty>(entity =>
//            {
//                entity.ToTable("TableColumnProperty", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DatabaseName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.PropertyValue)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TableName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableDataMaskException>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TableDataMaskException", "DTG");

//                entity.Property(e => e.Dbname)
//                    .HasMaxLength(100)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.SchemaName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableDesignPackage>(entity =>
//            {
//                entity.ToTable("TableDesignPackage", "DTG");

//                entity.Property(e => e.Dbname)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.DevelopmentLocation)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RejectReason).IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Script).IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
//            });

//            modelBuilder.Entity<TableDraft>(entity =>
//            {
//                entity.ToTable("TableDraft", "DTG");

//                entity.Property(e => e.Dbname)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.DevVersion).HasDefaultValueSql("((1))");

//                entity.Property(e => e.DevelopmentLocation)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.IsEntity).HasDefaultValueSql("((0))");

//                entity.Property(e => e.LogTableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableOld1>(entity =>
//            {
//                entity.HasKey(e => e.TableId)
//                    .HasName("PK_Table1");

//                entity.ToTable("TableOld1", "DTG");

//                entity.Property(e => e.Dbname)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.LogTableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableOld2>(entity =>
//            {
//                entity.HasKey(e => e.TableId)
//                    .HasName("PK_Table2");

//                entity.ToTable("TableOld2", "DTG");

//                entity.Property(e => e.TableId).ValueGeneratedNever();

//                entity.Property(e => e.Dbname)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DBName");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.LogTableName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.SchemaName)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TableUseStatistic>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TableUseStatistics", "DTG");

//                entity.Property(e => e.CreateDate).HasColumnType("datetime");

//                entity.Property(e => e.DatabaseName).HasMaxLength(128);

//                entity.Property(e => e.ElapsedDayForLastSqlrestart).HasColumnName("ElapsedDayForLastSQLRestart");

//                entity.Property(e => e.LastUserUpdateDate).HasColumnType("datetime");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TableName).HasMaxLength(257);
//            });

//            modelBuilder.Entity<TemplateType>(entity =>
//            {
//                entity.ToTable("TemplateType", "DTG");

//                entity.Property(e => e.TemplateTypeId).ValueGeneratedOnAdd();

//                entity.Property(e => e.Description)
//                    .IsRequired()
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.DescriptionEn)
//                    .HasMaxLength(200)
//                    .IsUnicode(false)
//                    .HasColumnName("DescriptionEN");
//            });

//            modelBuilder.Entity<Term>(entity =>
//            {
//                entity.ToTable("Term", "DTG");

//                entity.Property(e => e.CopyWriterApproval).HasDefaultValueSql("((0))");

//                entity.Property(e => e.Description)
//                    .IsRequired()
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.DescriptionEn)
//                    .HasMaxLength(2000)
//                    .IsUnicode(false)
//                    .HasColumnName("DescriptionEN");

//                entity.Property(e => e.HashTag)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(200)
//                    .IsUnicode(false)
//                    .HasColumnName("NameEN");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TermCode)
//                    .IsRequired()
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TermDataMask>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TermDataMask", "DTG");

//                entity.Property(e => e.DataType)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TermDataMaskWhiteList>(entity =>
//            {
//                entity.HasKey(e => new { e.TermId, e.ColumnName })
//                    .HasName("pkTermDataMaskWhiteList");

//                entity.ToTable("TermDataMaskWhiteList", "DTG");

//                entity.Property(e => e.ColumnName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TermRecommendation>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TermRecommendation", "DTG");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.DescriptionEn)
//                    .HasMaxLength(2000)
//                    .IsUnicode(false)
//                    .HasColumnName("DescriptionEN");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(200)
//                    .IsUnicode(false)
//                    .HasColumnName("NameEN");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TermRecommendationId).ValueGeneratedOnAdd();

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TermRule>(entity =>
//            {
//                entity.ToTable("TermRule", "DTG");

//                entity.Property(e => e.Value)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TermTextApprovalJournal>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TermTextApprovalJournal", "DTG");

//                entity.Property(e => e.Description)
//                    .IsRequired()
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TermTextApprovalJournalId).ValueGeneratedOnAdd();

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TermWork>(entity =>
//            {
//                entity.HasKey(e => e.TermId);

//                entity.ToTable("TermWork", "DTG");

//                entity.Property(e => e.Description)
//                    .IsRequired()
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.DescriptionEn)
//                    .HasMaxLength(2000)
//                    .IsUnicode(false)
//                    .HasColumnName("DescriptionEN");

//                entity.Property(e => e.HashTag)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.NameEn)
//                    .HasMaxLength(200)
//                    .IsUnicode(false)
//                    .HasColumnName("NameEN");

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TermCode)
//                    .IsRequired()
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TransferAbroad>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TransferAbroad", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TransferAbroadId).ValueGeneratedOnAdd();

//                entity.Property(e => e.TransferAbroadName)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<TransferredContactGroup>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TransferredContactGroup", "DTG");

//                entity.Property(e => e.HostIp)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("HostIP");

//                entity.Property(e => e.HostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SystemDate).HasColumnType("datetime");

//                entity.Property(e => e.TransferredContactGroupId).ValueGeneratedOnAdd();

//                entity.Property(e => e.TransferredContactGroupName)
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateHostName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdateSystemDate).HasColumnType("datetime");

//                entity.Property(e => e.UpdateUserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserName)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<UpdateItemAuthorizationForTableDdlscript>(entity =>
//            {
//                entity.HasKey(e => e.UserCode)
//                    .HasName("pkUpdateItemAuthorizationForTableDDLScript");

//                entity.ToTable("UpdateItemAuthorizationForTableDDLScript", "DTG");

//                entity.Property(e => e.UserCode)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}

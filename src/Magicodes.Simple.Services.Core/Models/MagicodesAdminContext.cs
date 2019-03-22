using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Magicodes.Simple.Services.Host
{
    public partial class MagicodesAdminContext : DbContext
    {
        public MagicodesAdminContext()
        {
        }

        public MagicodesAdminContext(DbContextOptions<MagicodesAdminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbpAuditLogs> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJobs> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpEditions> AbpEditions { get; set; }
        public virtual DbSet<AbpEntityChangeSets> AbpEntityChangeSets { get; set; }
        public virtual DbSet<AbpEntityChanges> AbpEntityChanges { get; set; }
        public virtual DbSet<AbpEntityPropertyChanges> AbpEntityPropertyChanges { get; set; }
        public virtual DbSet<AbpFeatures> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguageTexts> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpLanguages> AbpLanguages { get; set; }
        public virtual DbSet<AbpNotificationSubscriptions> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpNotifications> AbpNotifications { get; set; }
        public virtual DbSet<AbpOrganizationUnits> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpPermissions> AbpPermissions { get; set; }
        public virtual DbSet<AbpPersistedGrants> AbpPersistedGrants { get; set; }
        public virtual DbSet<AbpRoleClaims> AbpRoleClaims { get; set; }
        public virtual DbSet<AbpRoles> AbpRoles { get; set; }
        public virtual DbSet<AbpSettings> AbpSettings { get; set; }
        public virtual DbSet<AbpTenantNotifications> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpTenants> AbpTenants { get; set; }
        public virtual DbSet<AbpUserAccounts> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserClaims> AbpUserClaims { get; set; }
        public virtual DbSet<AbpUserLoginAttempts> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserLogins> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserNotifications> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnits> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRoles> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUserTokens> AbpUserTokens { get; set; }
        public virtual DbSet<AbpUsers> AbpUsers { get; set; }
        public virtual DbSet<AddValueServiceInfos> AddValueServiceInfos { get; set; }
        public virtual DbSet<AppBinaryObjects> AppBinaryObjects { get; set; }
        public virtual DbSet<AppChatMessages> AppChatMessages { get; set; }
        public virtual DbSet<AppFriendships> AppFriendships { get; set; }
        public virtual DbSet<AppInvoices> AppInvoices { get; set; }
        public virtual DbSet<AppSubscriptionPayments> AppSubscriptionPayments { get; set; }
        public virtual DbSet<AppUserOpenIds> AppUserOpenIds { get; set; }
        public virtual DbSet<ArticleInfos> ArticleInfos { get; set; }
        public virtual DbSet<ArticleSourceInfos> ArticleSourceInfos { get; set; }
        public virtual DbSet<ArticleTagInfos> ArticleTagInfos { get; set; }
        public virtual DbSet<AttachmentInfos> AttachmentInfos { get; set; }
        public virtual DbSet<CleaningPortInfos> CleaningPortInfos { get; set; }
        public virtual DbSet<ColumnInfos> ColumnInfos { get; set; }
        public virtual DbSet<CurrencyInfos> CurrencyInfos { get; set; }
        public virtual DbSet<DistrictInfos> DistrictInfos { get; set; }
        public virtual DbSet<ExpressCompanyInfos> ExpressCompanyInfos { get; set; }
        public virtual DbSet<GoodsAttributeInfos> GoodsAttributeInfos { get; set; }
        public virtual DbSet<GoodsCatInfos> GoodsCatInfos { get; set; }
        public virtual DbSet<GoodsInfos> GoodsInfos { get; set; }
        public virtual DbSet<GoodsSpecs> GoodsSpecs { get; set; }
        public virtual DbSet<MeasurementUnitInfos> MeasurementUnitInfos { get; set; }
        public virtual DbSet<ObjectAttachmentInfos> ObjectAttachmentInfos { get; set; }
        public virtual DbSet<OrderGoodsInfos> OrderGoodsInfos { get; set; }
        public virtual DbSet<OrderPackageInfos> OrderPackageInfos { get; set; }
        public virtual DbSet<OrderRules> OrderRules { get; set; }
        public virtual DbSet<OrderServicesInfo> OrderServicesInfo { get; set; }
        public virtual DbSet<PackageOrderInfos> PackageOrderInfos { get; set; }
        public virtual DbSet<ProductCategoryInfos> ProductCategoryInfos { get; set; }
        public virtual DbSet<RateInfos> RateInfos { get; set; }
        public virtual DbSet<ReceiptAddressInfos> ReceiptAddressInfos { get; set; }
        public virtual DbSet<ReceiverInfos> ReceiverInfos { get; set; }
        public virtual DbSet<ServiceProductInfos> ServiceProductInfos { get; set; }
        public virtual DbSet<ServiceProductPriceFormulas> ServiceProductPriceFormulas { get; set; }
        public virtual DbSet<ServiceProductPrices> ServiceProductPrices { get; set; }
        public virtual DbSet<StorePackInfos> StorePackInfos { get; set; }
        public virtual DbSet<TaxFormulaInfos> TaxFormulaInfos { get; set; }
        public virtual DbSet<TaxNoInfos> TaxNoInfos { get; set; }
        public virtual DbSet<TransactionLogs> TransactionLogs { get; set; }
        public virtual DbSet<UserTypeInfos> UserTypeInfos { get; set; }
        public virtual DbSet<WarehouseAreaInfos> WarehouseAreaInfos { get; set; }
        public virtual DbSet<WarehouseInfos> WarehouseInfos { get; set; }
        public virtual DbSet<WarehousePositionInfos> WarehousePositionInfos { get; set; }
        public virtual DbSet<WeightUnitInfos> WeightUnitInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<AbpAuditLogs>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ExecutionDuration });

                entity.HasIndex(e => new { e.TenantId, e.ExecutionTime });

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJobs>(entity =>
            {
                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime });

                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<AbpEditions>(entity =>
            {
                entity.Property(e => e.AnnualPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MonthlyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<AbpEntityChangeSets>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.CreationTime });

                entity.HasIndex(e => new { e.TenantId, e.Reason });

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.Reason).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpEntityChanges>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeSetId);

                entity.HasIndex(e => new { e.EntityTypeFullName, e.EntityId });

                entity.Property(e => e.EntityId).HasMaxLength(48);

                entity.Property(e => e.EntityTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChangeSet)
                    .WithMany(p => p.AbpEntityChanges)
                    .HasForeignKey(d => d.EntityChangeSetId);
            });

            modelBuilder.Entity<AbpEntityPropertyChanges>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeId);

                entity.Property(e => e.NewValue).HasMaxLength(512);

                entity.Property(e => e.OriginalValue).HasMaxLength(512);

                entity.Property(e => e.PropertyName).HasMaxLength(96);

                entity.Property(e => e.PropertyTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.AbpEntityPropertyChanges)
                    .HasForeignKey(d => d.EntityChangeId);
            });

            modelBuilder.Entity<AbpFeatures>(entity =>
            {
                entity.HasIndex(e => new { e.EditionId, e.Name });

                entity.HasIndex(e => new { e.TenantId, e.Name });

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpLanguageTexts>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Source, e.LanguageName, e.Key });

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AbpLanguages>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Name });

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AbpNotificationSubscriptions>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId });

                entity.HasIndex(e => new { e.TenantId, e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId });

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnits>(entity =>
            {
                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => new { e.TenantId, e.Code });

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(95);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<AbpPermissions>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.TenantId, e.Name });

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpPersistedGrants>(entity =>
            {
                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type });

                entity.Property(e => e.Id)
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AbpRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => new { e.TenantId, e.ClaimType });

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpRoles>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId);

                entity.HasIndex(e => e.DeleterUserId);

                entity.HasIndex(e => e.LastModifierUserId);

                entity.HasIndex(e => new { e.TenantId, e.NormalizedName });

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NormalizedName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRolesCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRolesDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRolesLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpSettings>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.TenantId, e.Name });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpTenantNotifications>(entity =>
            {
                entity.HasIndex(e => e.TenantId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpTenants>(entity =>
            {
                entity.HasIndex(e => e.CreationTime);

                entity.HasIndex(e => e.CreatorUserId);

                entity.HasIndex(e => e.DeleterUserId);

                entity.HasIndex(e => e.EditionId);

                entity.HasIndex(e => e.LastModifierUserId);

                entity.HasIndex(e => e.SubscriptionEndDateUtc);

                entity.HasIndex(e => e.TenancyName);

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.LogoFileType).HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantsCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantsDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantsLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpUserAccounts>(entity =>
            {
                entity.HasIndex(e => e.EmailAddress);

                entity.HasIndex(e => e.UserName);

                entity.HasIndex(e => new { e.TenantId, e.EmailAddress });

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.HasIndex(e => new { e.TenantId, e.UserName });

                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.TenantId, e.ClaimType });

                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLoginAttempts>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.TenantId });

                entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result });

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<AbpUserLogins>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.HasIndex(e => new { e.TenantId, e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserNotifications>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime });

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpUserOrganizationUnits>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId });

                entity.HasIndex(e => new { e.TenantId, e.UserId });
            });

            modelBuilder.Entity<AbpUserRoles>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.TenantId, e.RoleId });

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserTokens>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUsers>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId);

                entity.HasIndex(e => e.DeleterUserId);

                entity.HasIndex(e => e.LastModifierUserId);

                entity.HasIndex(e => new { e.TenantId, e.NormalizedEmailAddress });

                entity.HasIndex(e => new { e.TenantId, e.NormalizedUserName });

                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.NormalizedEmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.SecurityStamp).HasMaxLength(128);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AddValueServiceInfos>(entity =>
            {
                entity.HasIndex(e => e.CurrencyInfoId1);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.Snumber)
                    .HasColumnName("SNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Tips).HasMaxLength(500);

                entity.HasOne(d => d.CurrencyInfoId1Navigation)
                    .WithMany(p => p.AddValueServiceInfos)
                    .HasForeignKey(d => d.CurrencyInfoId1);
            });

            modelBuilder.Entity<AppBinaryObjects>(entity =>
            {
                entity.HasIndex(e => e.TenantId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bytes).IsRequired();
            });

            modelBuilder.Entity<AppChatMessages>(entity =>
            {
                entity.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });

                entity.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });

                entity.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });

                entity.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<AppFriendships>(entity =>
            {
                entity.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });

                entity.HasIndex(e => new { e.FriendTenantId, e.UserId });

                entity.HasIndex(e => new { e.TenantId, e.FriendUserId });

                entity.HasIndex(e => new { e.TenantId, e.UserId });

                entity.Property(e => e.FriendUserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AppSubscriptionPayments>(entity =>
            {
                entity.HasIndex(e => e.EditionId);

                entity.HasIndex(e => new { e.PaymentId, e.Gateway });

                entity.HasIndex(e => new { e.Status, e.CreationTime });

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AppSubscriptionPayments)
                    .HasForeignKey(d => d.EditionId);
            });

            modelBuilder.Entity<AppUserOpenIds>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.OpenId).HasMaxLength(50);

                entity.Property(e => e.UnionId).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserOpenIds)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ArticleInfos>(entity =>
            {
                entity.HasIndex(e => e.ArticleSourceInfoId);

                entity.HasIndex(e => e.ColumnInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Introduction).HasMaxLength(200);

                entity.Property(e => e.KeyWords).HasMaxLength(200);

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SeoTitle).HasMaxLength(50);

                entity.Property(e => e.StaticPageUrl).HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.HasOne(d => d.ArticleSourceInfo)
                    .WithMany(p => p.ArticleInfos)
                    .HasForeignKey(d => d.ArticleSourceInfoId);

                entity.HasOne(d => d.ColumnInfo)
                    .WithMany(p => p.ArticleInfos)
                    .HasForeignKey(d => d.ColumnInfoId);
            });

            modelBuilder.Entity<ArticleSourceInfos>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ArticleTagInfos>(entity =>
            {
                entity.HasIndex(e => e.ArticleInfoId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ArticleInfo)
                    .WithMany(p => p.ArticleTagInfos)
                    .HasForeignKey(d => d.ArticleInfoId);
            });

            modelBuilder.Entity<AttachmentInfos>(entity =>
            {
                entity.Property(e => e.BlobName).HasMaxLength(50);

                entity.Property(e => e.ContainerName).HasMaxLength(50);

                entity.Property(e => e.ContentMd5)
                    .HasColumnName("ContentMD5")
                    .HasMaxLength(32);

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(255);
            });

            modelBuilder.Entity<CleaningPortInfos>(entity =>
            {
                entity.HasIndex(e => e.ExpressCompanyInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsNeedCardNo).HasColumnName("IsNeedCardNO");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.RepeatShr).HasColumnName("RepeatSHR");

                entity.Property(e => e.RepeatShrnumber).HasColumnName("RepeatSHRNumber");

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.TempleteName).HasMaxLength(50);

                entity.HasOne(d => d.ExpressCompanyInfo)
                    .WithMany(p => p.CleaningPortInfos)
                    .HasForeignKey(d => d.ExpressCompanyInfoId);
            });

            modelBuilder.Entity<ColumnInfos>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(200);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IconCls).HasMaxLength(20);

                entity.Property(e => e.Introduction).HasMaxLength(200);

                entity.Property(e => e.KeyWords).HasMaxLength(200);

                entity.Property(e => e.SeoTitle).HasMaxLength(50);

                entity.Property(e => e.StaticPageUrl).HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(255);
            });

            modelBuilder.Entity<CurrencyInfos>(entity =>
            {
                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.Symbol).HasMaxLength(1);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CurrencyInfos)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<DistrictInfos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ExpressCompanyInfos>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Parameter1).HasMaxLength(50);

                entity.Property(e => e.Parameter2).HasMaxLength(50);

                entity.Property(e => e.Parameter3).HasMaxLength(50);

                entity.Property(e => e.Parameter4).HasMaxLength(50);

                entity.Property(e => e.Parameter5).HasMaxLength(50);

                entity.Property(e => e.Parameter6).HasMaxLength(50);

                entity.Property(e => e.Parameter7).HasMaxLength(50);

                entity.Property(e => e.Parameter8).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.WebSite).HasMaxLength(80);
            });

            modelBuilder.Entity<GoodsAttributeInfos>(entity =>
            {
                entity.HasIndex(e => e.GoodsInfoId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.GoodsInfo)
                    .WithMany(p => p.GoodsAttributeInfos)
                    .HasForeignKey(d => d.GoodsInfoId);
            });

            modelBuilder.Entity<GoodsCatInfos>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<GoodsInfos>(entity =>
            {
                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sellpoint)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<GoodsSpecs>(entity =>
            {
                entity.HasIndex(e => e.GoodsInfoId);

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ImageUrls).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OriginalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.GoodsInfo)
                    .WithMany(p => p.GoodsSpecs)
                    .HasForeignKey(d => d.GoodsInfoId);
            });

            modelBuilder.Entity<MeasurementUnitInfos>(entity =>
            {
                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MeasurementUnitInfos)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<ObjectAttachmentInfos>(entity =>
            {
                entity.HasIndex(e => e.AttachmentInfoId);

                entity.HasOne(d => d.AttachmentInfo)
                    .WithMany(p => p.ObjectAttachmentInfos)
                    .HasForeignKey(d => d.AttachmentInfoId);
            });

            modelBuilder.Entity<OrderGoodsInfos>(entity =>
            {
                entity.HasIndex(e => e.BigProductCategoryInfoId);

                entity.HasIndex(e => e.PackageOrderInfoId);

                entity.HasIndex(e => e.SmallProductCategoryInfoId);

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.GoodsBuyUrl).HasMaxLength(50);

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GoodsPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductBrand).HasMaxLength(50);

                entity.Property(e => e.ProductUnit).HasMaxLength(50);

                entity.Property(e => e.ProductVersion).HasMaxLength(50);

                entity.HasOne(d => d.BigProductCategoryInfo)
                    .WithMany(p => p.OrderGoodsInfosBigProductCategoryInfo)
                    .HasForeignKey(d => d.BigProductCategoryInfoId);

                entity.HasOne(d => d.PackageOrderInfo)
                    .WithMany(p => p.OrderGoodsInfos)
                    .HasForeignKey(d => d.PackageOrderInfoId);

                entity.HasOne(d => d.SmallProductCategoryInfo)
                    .WithMany(p => p.OrderGoodsInfosSmallProductCategoryInfo)
                    .HasForeignKey(d => d.SmallProductCategoryInfoId);
            });

            modelBuilder.Entity<OrderPackageInfos>(entity =>
            {
                entity.HasIndex(e => e.WarehouseInfoId);

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PackageWeigh).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.OrderPackageInfos)
                    .HasForeignKey(d => d.WarehouseInfoId);
            });

            modelBuilder.Entity<OrderRules>(entity =>
            {
                entity.HasIndex(e => e.CleaningPortInfoId);

                entity.HasIndex(e => e.ServiceProductInfoId);

                entity.HasIndex(e => e.WarehouseInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ReviewValue1).HasMaxLength(500);

                entity.Property(e => e.ReviewValue2).HasMaxLength(500);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.CleaningPortInfo)
                    .WithMany(p => p.OrderRules)
                    .HasForeignKey(d => d.CleaningPortInfoId);

                entity.HasOne(d => d.ServiceProductInfo)
                    .WithMany(p => p.OrderRules)
                    .HasForeignKey(d => d.ServiceProductInfoId);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.OrderRules)
                    .HasForeignKey(d => d.WarehouseInfoId);
            });

            modelBuilder.Entity<OrderServicesInfo>(entity =>
            {
                entity.HasIndex(e => e.AddValueServiceInfoId);

                entity.HasIndex(e => e.CurrencyInfoId1);

                entity.HasIndex(e => e.PackageOrderInfoId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Snumber)
                    .HasColumnName("SNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Tips).HasMaxLength(500);

                entity.HasOne(d => d.AddValueServiceInfo)
                    .WithMany(p => p.OrderServicesInfo)
                    .HasForeignKey(d => d.AddValueServiceInfoId);

                entity.HasOne(d => d.CurrencyInfoId1Navigation)
                    .WithMany(p => p.OrderServicesInfo)
                    .HasForeignKey(d => d.CurrencyInfoId1);

                entity.HasOne(d => d.PackageOrderInfo)
                    .WithMany(p => p.OrderServicesInfo)
                    .HasForeignKey(d => d.PackageOrderInfoId);
            });

            modelBuilder.Entity<PackageOrderInfos>(entity =>
            {
                entity.HasIndex(e => e.ArriveDestinationCompanyInfoId);

                entity.HasIndex(e => e.CleaningPortInfoId);

                entity.HasIndex(e => e.PackageInfoId);

                entity.HasIndex(e => e.ReceiverInfoId);

                entity.HasIndex(e => e.ServiceProductInfoId);

                entity.HasIndex(e => e.WarehouseInfoId);

                entity.Property(e => e.AdditionalServicesFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ArriveDestinationCode).HasMaxLength(50);

                entity.Property(e => e.CancelRemark).HasMaxLength(500);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerRemark).HasMaxLength(500);

                entity.Property(e => e.CustomerServiceRemark).HasMaxLength(500);

                entity.Property(e => e.DeclaredTotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Eccode)
                    .HasColumnName("ECCode")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateTaxFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeByCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeByCoupon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ForecastCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FreightFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsuredValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PremiumAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiptTime).HasMaxLength(20);

                entity.Property(e => e.SeparateFitId).HasMaxLength(50);

                entity.Property(e => e.StoreCode).HasMaxLength(50);

                entity.Property(e => e.TaxFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxFeeByCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeeRemark)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ArriveDestinationCompanyInfo)
                    .WithMany(p => p.PackageOrderInfos)
                    .HasForeignKey(d => d.ArriveDestinationCompanyInfoId);

                entity.HasOne(d => d.CleaningPortInfo)
                    .WithMany(p => p.PackageOrderInfos)
                    .HasForeignKey(d => d.CleaningPortInfoId);

                entity.HasOne(d => d.PackageInfo)
                    .WithMany(p => p.PackageOrderInfos)
                    .HasForeignKey(d => d.PackageInfoId);

                entity.HasOne(d => d.ReceiverInfo)
                    .WithMany(p => p.PackageOrderInfos)
                    .HasForeignKey(d => d.ReceiverInfoId);

                entity.HasOne(d => d.ServiceProductInfo)
                    .WithMany(p => p.PackageOrderInfos)
                    .HasForeignKey(d => d.ServiceProductInfoId);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.PackageOrderInfos)
                    .HasForeignKey(d => d.WarehouseInfoId);
            });

            modelBuilder.Entity<ProductCategoryInfos>(entity =>
            {
                entity.HasIndex(e => e.CountryInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.ProductCategoryInfos)
                    .HasForeignKey(d => d.CountryInfoId);
            });

            modelBuilder.Entity<RateInfos>(entity =>
            {
                entity.HasIndex(e => e.SourceCurrencyId);

                entity.HasIndex(e => e.TargetCurrencyId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.SourceValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TargetValue).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SourceCurrency)
                    .WithMany(p => p.RateInfosSourceCurrency)
                    .HasForeignKey(d => d.SourceCurrencyId);

                entity.HasOne(d => d.TargetCurrency)
                    .WithMany(p => p.RateInfosTargetCurrency)
                    .HasForeignKey(d => d.TargetCurrencyId);
            });

            modelBuilder.Entity<ReceiptAddressInfos>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdNo).HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceiptAddressInfos)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ReceiverInfos>(entity =>
            {
                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DetailAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IdCardNo).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PaintMarker).HasMaxLength(50);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ServiceProductInfos>(entity =>
            {
                entity.HasIndex(e => e.CleaningPortInfoId);

                entity.HasIndex(e => e.FromCountryId);

                entity.HasIndex(e => e.ToCountryId);

                entity.HasIndex(e => e.WarehouseInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FromCountryId).HasColumnName("FromCountryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.Tips).HasMaxLength(500);

                entity.Property(e => e.ToCountryId).HasColumnName("ToCountryID");

                entity.Property(e => e.TransporTefficiency).HasMaxLength(20);

                entity.HasOne(d => d.CleaningPortInfo)
                    .WithMany(p => p.ServiceProductInfos)
                    .HasForeignKey(d => d.CleaningPortInfoId);

                entity.HasOne(d => d.FromCountry)
                    .WithMany(p => p.ServiceProductInfosFromCountry)
                    .HasForeignKey(d => d.FromCountryId);

                entity.HasOne(d => d.ToCountry)
                    .WithMany(p => p.ServiceProductInfosToCountry)
                    .HasForeignKey(d => d.ToCountryId);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.ServiceProductInfos)
                    .HasForeignKey(d => d.WarehouseInfoId);
            });

            modelBuilder.Entity<ServiceProductPriceFormulas>(entity =>
            {
                entity.HasIndex(e => e.ServiceProductPriceId);

                entity.Property(e => e.FormulaCondition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormulaExpression)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherFee).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ServiceProductPrice)
                    .WithMany(p => p.ServiceProductPriceFormulas)
                    .HasForeignKey(d => d.ServiceProductPriceId);
            });

            modelBuilder.Entity<ServiceProductPrices>(entity =>
            {
                entity.HasIndex(e => e.BigProductCategoryInfoId);

                entity.HasIndex(e => e.CurrencyInfoId);

                entity.HasIndex(e => e.FromCountryId);

                entity.HasIndex(e => e.FromProvinceId);

                entity.HasIndex(e => e.MeasurementUnitInfoId);

                entity.HasIndex(e => e.ServiceProductInfoId);

                entity.HasIndex(e => e.SmallProductCategoryInfoId);

                entity.HasIndex(e => e.ToCountryId);

                entity.HasIndex(e => e.ToProvinceId);

                entity.HasIndex(e => e.UserLevelInfoId);

                entity.HasIndex(e => e.WarehouseInfoId);

                entity.HasIndex(e => e.WeightUnitInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FeeExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FromCountryId).HasColumnName("FromCountryID");

                entity.Property(e => e.InsuranceRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ServiceFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.ToCountryId).HasColumnName("ToCountryID");

                entity.Property(e => e.WeightModelValue).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BigProductCategoryInfo)
                    .WithMany(p => p.ServiceProductPricesBigProductCategoryInfo)
                    .HasForeignKey(d => d.BigProductCategoryInfoId);

                entity.HasOne(d => d.CurrencyInfo)
                    .WithMany(p => p.ServiceProductPrices)
                    .HasForeignKey(d => d.CurrencyInfoId);

                entity.HasOne(d => d.FromCountry)
                    .WithMany(p => p.ServiceProductPricesFromCountry)
                    .HasForeignKey(d => d.FromCountryId);

                entity.HasOne(d => d.FromProvince)
                    .WithMany(p => p.ServiceProductPricesFromProvince)
                    .HasForeignKey(d => d.FromProvinceId);

                entity.HasOne(d => d.MeasurementUnitInfo)
                    .WithMany(p => p.ServiceProductPrices)
                    .HasForeignKey(d => d.MeasurementUnitInfoId);

                entity.HasOne(d => d.ServiceProductInfo)
                    .WithMany(p => p.ServiceProductPrices)
                    .HasForeignKey(d => d.ServiceProductInfoId);

                entity.HasOne(d => d.SmallProductCategoryInfo)
                    .WithMany(p => p.ServiceProductPricesSmallProductCategoryInfo)
                    .HasForeignKey(d => d.SmallProductCategoryInfoId);

                entity.HasOne(d => d.ToCountry)
                    .WithMany(p => p.ServiceProductPricesToCountry)
                    .HasForeignKey(d => d.ToCountryId);

                entity.HasOne(d => d.ToProvince)
                    .WithMany(p => p.ServiceProductPricesToProvince)
                    .HasForeignKey(d => d.ToProvinceId);

                entity.HasOne(d => d.UserLevelInfo)
                    .WithMany(p => p.ServiceProductPrices)
                    .HasForeignKey(d => d.UserLevelInfoId);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.ServiceProductPrices)
                    .HasForeignKey(d => d.WarehouseInfoId);

                entity.HasOne(d => d.WeightUnitInfo)
                    .WithMany(p => p.ServiceProductPrices)
                    .HasForeignKey(d => d.WeightUnitInfoId);
            });

            modelBuilder.Entity<StorePackInfos>(entity =>
            {
                entity.HasIndex(e => e.FristWarehouseInfoId);

                entity.HasIndex(e => e.PreviouWarehouseInfoId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.WarehouseAreaInfoId);

                entity.HasIndex(e => e.WarehouseInfoId);

                entity.HasIndex(e => e.WarehousePositionInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ForecastCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InStockTempleteName).HasMaxLength(50);

                entity.Property(e => e.InvoiceTempleteName).HasMaxLength(50);

                entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherInfoId).HasMaxLength(50);

                entity.Property(e => e.OutstoreWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PickingTempleteName).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.StoreCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserCode).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FristWarehouseInfo)
                    .WithMany(p => p.StorePackInfosFristWarehouseInfo)
                    .HasForeignKey(d => d.FristWarehouseInfoId);

                entity.HasOne(d => d.PreviouWarehouseInfo)
                    .WithMany(p => p.StorePackInfosPreviouWarehouseInfo)
                    .HasForeignKey(d => d.PreviouWarehouseInfoId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StorePackInfos)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.WarehouseAreaInfo)
                    .WithMany(p => p.StorePackInfos)
                    .HasForeignKey(d => d.WarehouseAreaInfoId);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.StorePackInfosWarehouseInfo)
                    .HasForeignKey(d => d.WarehouseInfoId);

                entity.HasOne(d => d.WarehousePositionInfo)
                    .WithMany(p => p.StorePackInfos)
                    .HasForeignKey(d => d.WarehousePositionInfoId);
            });

            modelBuilder.Entity<TaxFormulaInfos>(entity =>
            {
                entity.HasIndex(e => e.CleaningPortInfoId);

                entity.HasIndex(e => e.TaxNoInfoId);

                entity.Property(e => e.BuyValueFormula).HasMaxLength(200);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.TariffFormula).HasMaxLength(200);

                entity.HasOne(d => d.CleaningPortInfo)
                    .WithMany(p => p.TaxFormulaInfos)
                    .HasForeignKey(d => d.CleaningPortInfoId);

                entity.HasOne(d => d.TaxNoInfo)
                    .WithMany(p => p.TaxFormulaInfos)
                    .HasForeignKey(d => d.TaxNoInfoId);
            });

            modelBuilder.Entity<TaxNoInfos>(entity =>
            {
                entity.HasIndex(e => e.ProductCategoryInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ProductCategoryInfo)
                    .WithMany(p => p.TaxNoInfos)
                    .HasForeignKey(d => d.ProductCategoryInfoId);
            });

            modelBuilder.Entity<TransactionLogs>(entity =>
            {
                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CurrencyCurrencyValue)
                    .HasColumnName("Currency_CurrencyValue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencySymbol)
                    .HasColumnName("Currency_Symbol")
                    .HasMaxLength(5);

                entity.Property(e => e.CustomData).HasMaxLength(500);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OutTradeNo).HasMaxLength(50);

                entity.Property(e => e.TransactionId).HasMaxLength(50);
            });

            modelBuilder.Entity<UserTypeInfos>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MaxRebate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RebateRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.UpgradeAmountFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpgradeAmountTo).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<WarehouseAreaInfos>(entity =>
            {
                entity.HasIndex(e => e.WarehouseInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.WarehouseInfo)
                    .WithMany(p => p.WarehouseAreaInfos)
                    .HasForeignKey(d => d.WarehouseInfoId);
            });

            modelBuilder.Entity<WarehouseInfos>(entity =>
            {
                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Consignee).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OverdueFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Phone).HasMaxLength(25);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.Tips).HasMaxLength(500);

                entity.Property(e => e.TransportFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.WarehouseInfos)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<WarehousePositionInfos>(entity =>
            {
                entity.HasIndex(e => e.WarehouseAreaInfoId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.WarehouseAreaInfo)
                    .WithMany(p => p.WarehousePositionInfos)
                    .HasForeignKey(d => d.WarehouseAreaInfoId);
            });

            modelBuilder.Entity<WeightUnitInfos>(entity =>
            {
                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.WeightUnitInfos)
                    .HasForeignKey(d => d.CountryId);
            });
        }
    }
}

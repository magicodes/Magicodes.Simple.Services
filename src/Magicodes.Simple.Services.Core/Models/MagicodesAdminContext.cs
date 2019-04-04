using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Magicodes.Simple.Services.Core.Models
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
        public virtual DbSet<ColumnInfos> ColumnInfos { get; set; }
        public virtual DbSet<ObjectAttachmentInfos> ObjectAttachmentInfos { get; set; }
        public virtual DbSet<TransactionLogs> TransactionLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;  Database=Magicodes.Admin; Trusted_Connection=True;");
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

            modelBuilder.Entity<ObjectAttachmentInfos>(entity =>
            {
                entity.HasIndex(e => e.AttachmentInfoId);

                entity.HasOne(d => d.AttachmentInfo)
                    .WithMany(p => p.ObjectAttachmentInfos)
                    .HasForeignKey(d => d.AttachmentInfoId);
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
        }
    }
}

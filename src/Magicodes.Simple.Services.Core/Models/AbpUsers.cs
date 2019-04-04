using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AbpUsers
    {
        public AbpUsers()
        {
            AbpPermissions = new HashSet<AbpPermissions>();
            AbpRolesCreatorUser = new HashSet<AbpRoles>();
            AbpRolesDeleterUser = new HashSet<AbpRoles>();
            AbpRolesLastModifierUser = new HashSet<AbpRoles>();
            AbpSettings = new HashSet<AbpSettings>();
            AbpTenantsCreatorUser = new HashSet<AbpTenants>();
            AbpTenantsDeleterUser = new HashSet<AbpTenants>();
            AbpTenantsLastModifierUser = new HashSet<AbpTenants>();
            AbpUserClaims = new HashSet<AbpUserClaims>();
            AbpUserLogins = new HashSet<AbpUserLogins>();
            AbpUserRoles = new HashSet<AbpUserRoles>();
            AbpUserTokens = new HashSet<AbpUserTokens>();
            AppUserOpenIds = new HashSet<AppUserOpenIds>();
            InverseCreatorUser = new HashSet<AbpUsers>();
            InverseDeleterUser = new HashSet<AbpUsers>();
            InverseLastModifierUser = new HashSet<AbpUsers>();
        }

        public long Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string AuthenticationSource { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string EmailAddress { get; set; }
        public string EmailConfirmationCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsLockoutEnabled { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public string Name { get; set; }
        public string NormalizedEmailAddress { get; set; }
        public string NormalizedUserName { get; set; }
        public string Password { get; set; }
        public string PasswordResetCode { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? ProfilePictureId { get; set; }
        public string SecurityStamp { get; set; }
        public bool ShouldChangePasswordOnNextLogin { get; set; }
        public string Surname { get; set; }
        public int? TenantId { get; set; }
        public string UserName { get; set; }
        public string SignInToken { get; set; }
        public DateTime? SignInTokenExpireTimeUtc { get; set; }
        public string GoogleAuthenticatorKey { get; set; }
        public int Balance { get; set; }
        public int FrozenAmount { get; set; }

        public virtual AbpUsers CreatorUser { get; set; }
        public virtual AbpUsers DeleterUser { get; set; }
        public virtual AbpUsers LastModifierUser { get; set; }
        public virtual ICollection<AbpPermissions> AbpPermissions { get; set; }
        public virtual ICollection<AbpRoles> AbpRolesCreatorUser { get; set; }
        public virtual ICollection<AbpRoles> AbpRolesDeleterUser { get; set; }
        public virtual ICollection<AbpRoles> AbpRolesLastModifierUser { get; set; }
        public virtual ICollection<AbpSettings> AbpSettings { get; set; }
        public virtual ICollection<AbpTenants> AbpTenantsCreatorUser { get; set; }
        public virtual ICollection<AbpTenants> AbpTenantsDeleterUser { get; set; }
        public virtual ICollection<AbpTenants> AbpTenantsLastModifierUser { get; set; }
        public virtual ICollection<AbpUserClaims> AbpUserClaims { get; set; }
        public virtual ICollection<AbpUserLogins> AbpUserLogins { get; set; }
        public virtual ICollection<AbpUserRoles> AbpUserRoles { get; set; }
        public virtual ICollection<AbpUserTokens> AbpUserTokens { get; set; }
        public virtual ICollection<AppUserOpenIds> AppUserOpenIds { get; set; }
        public virtual ICollection<AbpUsers> InverseCreatorUser { get; set; }
        public virtual ICollection<AbpUsers> InverseDeleterUser { get; set; }
        public virtual ICollection<AbpUsers> InverseLastModifierUser { get; set; }
    }
}

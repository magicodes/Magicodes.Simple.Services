using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class AttachmentInfos
    {
        public AttachmentInfos()
        {
            ObjectAttachmentInfos = new HashSet<ObjectAttachmentInfos>();
        }

        public long Id { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public long FileLength { get; set; }
        public string ContainerName { get; set; }
        public string BlobName { get; set; }
        public string Url { get; set; }
        public int AttachmentType { get; set; }
        public string ContentMd5 { get; set; }
        public int AttachmentSorts { get; set; }

        public virtual ICollection<ObjectAttachmentInfos> ObjectAttachmentInfos { get; set; }
    }
}

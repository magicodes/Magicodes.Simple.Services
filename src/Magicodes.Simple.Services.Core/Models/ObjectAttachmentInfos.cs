using System;
using System.Collections.Generic;

namespace Magicodes.Simple.Services.Core.Models
{
    public partial class ObjectAttachmentInfos
    {
        public long Id { get; set; }
        public long ObjectId { get; set; }
        public long AttachmentInfoId { get; set; }
        public int ObjectType { get; set; }
        public bool IsCover { get; set; }

        public virtual AttachmentInfos AttachmentInfo { get; set; }
    }
}

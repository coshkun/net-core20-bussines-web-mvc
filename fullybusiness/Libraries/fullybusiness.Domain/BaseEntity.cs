using System;

namespace fullybusiness.Domain
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime CreationDate { get; set; }
    }
}
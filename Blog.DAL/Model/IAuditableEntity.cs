using System;

namespace Blog.DAL.Model
{
    public interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime? DeletedDate { get; set; }
        DateTime? UpdatedDate { get; set; }  
    }
}
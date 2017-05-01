using Blog.DAL.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Data.Entities
{
    public class AppUser: BaseEntity, IAuditableEntity, IStatus
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime LastActivityDate { get; set; }  
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
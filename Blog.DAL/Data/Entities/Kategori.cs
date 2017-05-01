using Blog.DAL.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Data.Entities
{
    public class Kategori : BaseEntity, IStatus
    {
        [MaxLength(100)]
        public string Ad { get; set; }
        [MaxLength(150)]
        public string Aciklama { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public ICollection<Makale> Makales { get; set; }    
    }
}
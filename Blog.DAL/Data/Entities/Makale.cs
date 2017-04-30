using Blog.DAL.Model;
using System;

namespace Blog.DAL.Data.Entities
{
    public class Makale : BaseEntity, IAuditableEntity, IStatus
    {
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Views { get; set; }  
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public int KategoriId { get; set; } 
        public Kategori Kategori { get; set; }
    }
}
using Blog.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Data.Entities
{
    public class Makale : BaseEntity, IAuditableEntity, IStatus
    {
        [MaxLength(250)]
        public string Baslik { get; set; }
        [MaxLength(250)]
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public int Like { get; set; } = 0;
        public int Dislike { get; set; } = 0;
        public int Views { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public int KategoriId { get; set; } 
        public Kategori Kategori { get; set; }


        public int? UserId { get; set; }
        public AppUser User { get; set; }

        public virtual ICollection<Etiket> Etikets{ get; set; } 
    }
}
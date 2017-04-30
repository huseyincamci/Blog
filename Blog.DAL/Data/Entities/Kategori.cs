using Blog.DAL.Model;
using System.Collections.Generic;

namespace Blog.DAL.Data.Entities
{
    public class Kategori : BaseEntity, IStatus
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }    
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Makale> Makales { get; set; }    
    }
}
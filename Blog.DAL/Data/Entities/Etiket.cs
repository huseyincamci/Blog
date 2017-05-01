using Blog.DAL.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Data.Entities
{
    public class Etiket : BaseEntity
    {
        [MaxLength(50)]
        public string Adi { get; set; }
        [MaxLength(150)]
        public string Aciklama { get; set; }
        
        public virtual ICollection<Makale> Makales { get; set; }   
    }
}
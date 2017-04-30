using Blog.DAL.Data.Entities;
using System;

namespace Blog.Web.UI.ViewModels
{
    public class MakaleViewModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Views { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Kategori Kategori { get; set; }
    }
}
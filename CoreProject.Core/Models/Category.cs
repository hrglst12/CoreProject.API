using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoreProject.Core.Models
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        public int Id { get; set; }

        public string  Name { get; set; }

        public bool IsDeleted { get; set; } // veritabanindan silmiycez, silme durumu tutulucak

        public ICollection<Product> Products { get; set; }// dizi olusturduk- category ve product baglanti kuruldu.bire cok iliski icin yazildi
    }
}

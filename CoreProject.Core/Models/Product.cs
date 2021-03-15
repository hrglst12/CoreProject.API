using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public string InnerBarcode { get; set; }

        //urun kategori sinifina ait olacagindan dolayi kategori sinifina referans veriyoruz.
        //virtual dememiniz sebebi sudur; entity framework Category uzerinden inherited kullanarak tracking yapical(degisiklikleri inceliycek,) izleme yapabilmesi icin 
        public virtual Category Category { get; set; } //category ve product baglanti kuruldu. bire cok iliski icin category tarafinda da yazildi
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdaYazilim.Entities.Concrete
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        
        public virtual ICollection<Sepet> Sepetler { get; set; }

        
    }
}

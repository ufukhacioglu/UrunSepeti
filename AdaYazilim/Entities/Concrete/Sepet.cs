using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdaYazilim.Entities.Concrete
{
    public class Sepet
    {
        public int SepetId { get; set; }
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
        
        public virtual ICollection<SepetUrun> SepetUrunler { get; set; }
    }
}

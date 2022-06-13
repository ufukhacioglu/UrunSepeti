namespace AdaYazilim.Entities.Concrete
{
    public class SepetUrun
    {
        public int SepetUrunId { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public int SepetId { get; set; }
        public virtual Sepet Sepet { get; set; }
    }
}

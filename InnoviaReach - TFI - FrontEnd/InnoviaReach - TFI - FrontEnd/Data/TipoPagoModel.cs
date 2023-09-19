namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class TipoPagoModel
    {
        public TipoPagoModel()
        {
            _mediosPagoModel = new HashSet<MedioDePagoModel>();
        }

        public string Descripcion { get; set; }
        public int TipoPago_ID { get; set; }
        public ICollection<MedioDePagoModel> _mediosPagoModel { get; set; }
    }
}

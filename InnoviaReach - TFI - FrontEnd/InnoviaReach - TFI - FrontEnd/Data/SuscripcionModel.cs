namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class SuscripcionModel
    {
        public SuscripcionModel()
        {
            suscripcionUsrdModels = new HashSet<SuscripcionUsuarioModel>();
        }
        public ICollection<SuscripcionUsuarioModel> suscripcionUsrdModels { get; set; }

        public string Descripcion { get; set; }
        public int Suscripcion_ID { get; set; }
    }
}

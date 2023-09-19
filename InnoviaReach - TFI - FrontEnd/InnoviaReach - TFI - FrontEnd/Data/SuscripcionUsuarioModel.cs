namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class SuscripcionUsuarioModel
    {
        public int ID { get; set; }
        public string User_ID { get; set; }
        public int Suscripcion_ID { get; set; }   
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public SuscripcionModel Suscripcion { get; set; }
        public Users Usuario { get; set; }

    }
}

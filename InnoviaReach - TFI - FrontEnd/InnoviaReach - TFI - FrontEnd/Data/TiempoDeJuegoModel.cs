namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class TiempoDeJuegoModel
    {
        public int CantidadHoras { get; set; }
        public int Tiempo_ID { get; set; }
        public DateTime UltimaFecha { get; set; }
        public string User_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public Users usuario { get; set; }
        public VideojuegoModel videojuego { get; set; }

    }
}

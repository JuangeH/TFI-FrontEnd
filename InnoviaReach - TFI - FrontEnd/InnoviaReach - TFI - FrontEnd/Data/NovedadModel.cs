namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class NovedadModel
    {
        public string Descripcion { get; set; }
        public int Novedad_ID { get; set; }
        public VideojuegoModel Videojuego { get; set; }
        public int Videojuego_ID { get; set; }
    }
}

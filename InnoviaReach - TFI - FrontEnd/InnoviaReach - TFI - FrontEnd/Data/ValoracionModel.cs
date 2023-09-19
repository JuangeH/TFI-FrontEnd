namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class ValoracionModel
    {
        public int Puntuacion { get; set; }
        public int Valoracion_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public VideojuegoModel Videojuego { get; set; } 
    }
}

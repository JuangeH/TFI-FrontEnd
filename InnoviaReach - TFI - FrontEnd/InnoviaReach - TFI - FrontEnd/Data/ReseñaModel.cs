namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class ReseñaModel
    {
        public string Descripcion { get; set; }
        public int Reseña_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public VideojuegoModel Videojuego { get; set; }
    }
}

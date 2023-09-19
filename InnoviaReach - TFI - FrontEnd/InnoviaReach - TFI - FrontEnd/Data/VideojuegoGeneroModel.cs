namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class VideojuegoGeneroModel
    {
        public int ID { get; set; }
        public int Genero_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public VideojuegoModel videojuego { get; set; }
        public GeneroModel generoModel { get; set; }
    }
}

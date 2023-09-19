namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class VideojuegoEstiloModel
    {
        public int ID { get; set; }
        public int Estilo_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public VideojuegoModel videojuego { get; set; }
        public EstiloModel estiloModel { get; set; }
    }
}

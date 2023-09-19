namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class VideojuegoInteresModel
    {
        public int ID { get; set; }
        public string User_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public Users usuario { get; set; }
        public VideojuegoModel videojuego { get; set; }
    }
}

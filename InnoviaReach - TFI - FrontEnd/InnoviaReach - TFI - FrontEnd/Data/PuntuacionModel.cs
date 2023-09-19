namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class PuntuacionModel
    {
        public int Comentario_ID { get; set; }
        public int Puntaje { get; set; }
        public int Puntuacion_ID { get; set; }
        public ComentarioModel comentario { get; set; }
    }
}

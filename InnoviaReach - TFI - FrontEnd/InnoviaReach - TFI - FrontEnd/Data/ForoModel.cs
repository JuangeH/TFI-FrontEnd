﻿namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class ForoModel
    {
        public ForoModel()
        {
            foroUsuarioModels = new HashSet<ForoUsuarioModel>();
            comentarioModels = new HashSet<ComentarioModel>();
        }
        public string Descripcion { get; set; }
        public int Foro_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public VideojuegoModel videojuego { get; set; }
        public ICollection<ForoUsuarioModel> foroUsuarioModels { get; set; }
        public ICollection<ComentarioModel> comentarioModels { get; set; }
    }
}
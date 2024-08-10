namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class ForoClass
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Creador { get; set; }
        public int CantidadParticipantes { get; set; }
        public int CantidadComentarios { get; set; }
        public double PuntuacionMedia { get; set; }
        public bool EsFavorito { get; set; }
        public List<ComentarioClass> Comentarios { get; set; } = new();
    }

    public class ComentarioClass
    {
        public int Id { get; set; }
        public int ForoId { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
        public int Puntuacion { get; set; }
        public DateTime Fecha { get; set; }
        public List<ComentarioClass> Respuestas { get; set; } = new();
    }

    public class UsuarioClass
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; } // Administrador, Creador, Usuario
        public List<int> ForosFavoritos { get; set; } = new();
    }

}

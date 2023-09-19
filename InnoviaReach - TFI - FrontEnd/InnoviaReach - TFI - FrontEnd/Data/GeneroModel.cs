namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class GeneroModel
    {
        public GeneroModel()
        {
            videojuegoGeneroModels = new HashSet<VideojuegoGeneroModel>();
        }
        public ICollection<VideojuegoGeneroModel> videojuegoGeneroModels { get; set; }
        public string Descripcion { get; set; }
        public int Genero_ID { get; set; }
    }
}

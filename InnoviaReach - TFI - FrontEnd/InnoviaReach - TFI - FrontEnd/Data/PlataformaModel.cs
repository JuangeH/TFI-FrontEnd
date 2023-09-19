namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class PlataformaModel
    {
        public PlataformaModel()
        {
            videojuegoModels = new HashSet<VideojuegoModel>();
        }
        public string Nombre { get; set; }
        public int Plataforma_ID { get; set; }
        public ICollection<VideojuegoModel> videojuegoModels { get; set; }
    }
}

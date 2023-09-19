namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class EstiloModel
    {
        public EstiloModel()
        {
            videojuegoEstiloModels = new HashSet<VideojuegoEstiloModel>();
        }
        public ICollection<VideojuegoEstiloModel> videojuegoEstiloModels { get; set; }
        public string Descripcion { get; set; }
        public int Estilo_ID { get; set; }
       


    }
}

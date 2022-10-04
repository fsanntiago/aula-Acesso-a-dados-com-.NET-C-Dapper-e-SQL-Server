namespace BaltaDataAccess.Models
{
    public class Career
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IList<CareerItem> CareerItems { get; set; }

        public Career()
        {
            CareerItems = new List<CareerItem>();  // Iniciar a lista no construtor para garantir que nao havera objeto nulo, quando for adicionar itemna lista
        }
    }
}

namespace LabSpace.Models
{
    public class Categoria
    {
        public int CategoriaId {get; set;}
        public string Nome {get; set;}
        public List<Produtos> Produtos {get; set;}
    }
}
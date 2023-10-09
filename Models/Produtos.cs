namespace LabSpace.Models
{
    public class Produtos
    {
        public int ProdutosId { get; set; }
        public string ProdutosNome { get; set; }
        public string ProdutosDescricao { get; set; }
        public string ImageUrl { get; set; }
        public string PequenaImagemUrl { get; set; }
        public double Preco {get; set;}
        public bool EmProducao {get; set;}
        public int CategoriaId {get; set;}
        public virtual Categoria Categoria {get; set;}
    }
}
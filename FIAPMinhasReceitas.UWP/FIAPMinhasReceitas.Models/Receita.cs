namespace FIAPMinhasReceitas.Models
{
    public enum Categoria
    {
        Bebida,
        Doce,
        Salgado
    }

    public class Receita
    {
        public string Titulo { get; set; }
        public Categoria Categoria { get; set; }
        public int MinutosPreparo { get; set; }
        public string Instrucoes { get; set; }
        public decimal Preco { get; set; }
    }
}

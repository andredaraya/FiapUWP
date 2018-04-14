using FIAPMinhasReceitas.Models.Abstracts;

namespace FIAPMinhasReceitas.Models
{
    public enum Categoria
    {
        Bebida,
        Doce,
        Salgado
    }

    public class Receita : NotifyableClass
    {
        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set { Set(ref _titulo, value); }
        }

        private Categoria _categoria;
        public Categoria Categoria
        {
            get { return _categoria; }
            set { Set(ref _categoria, value); }
        }

        private int _minutosPreparo;
        public int MinutosPreparo
        {
            get { return _minutosPreparo; }
            set { Set(ref _minutosPreparo, value); }
        }

        private string _instrucoes;
        public string Instrucoes
        {
            get { return _instrucoes; }
            set { Set(ref _instrucoes, value); }
        }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set { Set(ref _preco, value); }
        }
    }
}

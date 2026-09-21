 namespace  UniversoPagina.Data
{
     public class LivroRepository
    {
        private static  List<Livro> _tabelaLivros = new List<Livro>();
        private static int proximoID = 1; // variavel auxiliar

        public void  Adicionar(Livro livro) //método: adiciona livro na lista
        {
            livro.Id = proximoId++;
            _tabelaLivro.Add(livros);
        }
    }
}
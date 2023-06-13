public class Emprestimo
{   
    public Livro livro;
    public Pessoa pessoa;
    public DateTime dataEmprestimo;
    public DateTime dataDevolucao;
   
    public void EmprestarLivro(Livro livro, Pessoa pessoa, DateTime dataDevolucao)
    {
        if (livro.status == true)
        {
            this.livro = livro;
            this.pessoa = pessoa;
            this.dataEmprestimo = DateTime.Now;
            this.livro.status = false;
            Console.WriteLine("Livro emprestado");
        }
        else
        {
            Console.WriteLine("livro indisponível.");
        }
    }

    public void DevolverLivro(Livro livro, Pessoa pessoa, DateTime dataDevolucao)
    {
        if (livro.status == false)
        {
            this.livro = livro;
            this.pessoa = pessoa;
            this.dataDevolucao = DateTime.Now;
            this.livro.status = true;
            Console.WriteLine("Livro devolvido");
        }
        else
        {
            Console.WriteLine("livro disponível.");
        }
    }
}
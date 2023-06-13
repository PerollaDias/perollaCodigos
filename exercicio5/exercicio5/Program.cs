//Empréstimo-------------------------------------------------------------

Pessoa p = new Pessoa("Pérolla", "080706857", "perolladias");
Livro l = new Livro("java é a melhor","Pérolla", "2023", true,01);
Emprestimo Emprestimo = new Emprestimo();

Emprestimo.EmprestarLivro(l, p, new DateTime(2023, 03, 13));

Pessoa p2 = new Pessoa("Pérolla", "080706857", "perolladias");
Emprestimo Emprestimo2 = new Emprestimo();

Emprestimo.EmprestarLivro(l, p2, new DateTime(2023, 03, 13));

Console.WriteLine( );
//Devolução---------------------------------------------------------------

Pessoa p3 = new Pessoa("Pérolla", "080706857", "perolladias");
Livro l2 = new Livro("java é a melhor", "Pérolla", "2023", true, 01);
Emprestimo devolucao = new Emprestimo();

Emprestimo.DevolverLivro(l, p, new DateTime(2023, 03, 13));

Pessoa p4 = new Pessoa("Pérolla", "080706857", "perolladias");
Emprestimo devolucao2 = new Emprestimo();

Emprestimo.DevolverLivro(l, p2, new DateTime(2023, 03, 13));



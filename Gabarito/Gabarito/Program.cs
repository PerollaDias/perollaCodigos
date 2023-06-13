
Gabarito g = new Gabarito();

Prova p = new Prova(g);

Console.WriteLine("Informe o nome do aluno: ");
string nome = Console.ReadLine();

for(int i = 0; i < p.respostasAluno.Length; i++)
{
    Console.WriteLine("informe a resposta da questão: " + (i+1));
    char resposta = Convert.ToChar(Console.ReadLine());
    p.RespostaAluno(resposta);
}
Console.WriteLine("A quantidade de acertos foi: "+ (p.Acertos())+ " de 15 questões.");
Console.WriteLine((nome) + "A sua nota é: " + (p.Nota()));
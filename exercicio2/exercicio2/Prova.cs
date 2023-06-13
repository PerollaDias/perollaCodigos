public class Prova
{
    private Gabarito gabarito;
    private string[] RespostaAluno;
    private int questaoatual;

    public Prova(Gabarito gabarito)
    {
        this.gabarito = gabarito;
        RespostaAluno = new string[15];
        this.questaoatual = 0;
    }

    public void RespostaAlunos(string respostas)
    {
        RespostaAluno[questaoatual] = respostas;
        questaoatual++;
    }

    public int Acertos()
    {
        int acertos = 0;
        for(int i = 0; i < 15; i++)
        {
            if (RespostaAlunos[i] == gabarito.RespostaQuestao(i))
            {
                acertos++;
            }
        }
    }
}


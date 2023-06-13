class Prova
{
    private Gabarito gabarito;
    public char[] respostasAluno = new char[15];
    private int questaoAtual = 0;

    public Prova(Gabarito gabarito)
    {
        this.gabarito = gabarito;
    }

    public void RespostaAluno(char resposta)
    {
        for(int i = 0; i < respostasAluno.Length; i++)
        {
            if (respostasAluno[i] == 0)
            {
                respostasAluno[i] = resposta;
                break;
            }
        }
    }

    public int Acertos()
    {
        int acertos = 0;

        for (int i = 0; i < respostasAluno.Length; i++)
        {
            if (respostasAluno[i] == gabarito.RespostaQuestao(i))
            {
                acertos+=1;
            }
        }

        return acertos;
    }

    public double Nota()
    {
        double nota = 0;
        for(int i = 0; i < respostasAluno.Length; i++)
        {
            if (respostasAluno[i] == gabarito.RespostaQuestao(i))
            {
                if (i < 10)
                {
                    nota += 0.5;
                }
                else
                {
                    nota += 1;
                }
            }
        }
        return nota;
    }

    
}
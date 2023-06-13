public class Gabarito
{
    char[] gabaritocorreto = { 'a','c','d','e','a','b','c','a','c','e','c','b','c','a','d'};
    public char RespostaQuestao(int nquestao)
    {
        return this.gabaritocorreto[nquestao];
    }
    
}
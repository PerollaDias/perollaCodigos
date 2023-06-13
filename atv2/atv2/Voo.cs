public class Voo
{
    private DateTime dataVoo;
    private int numeroVoo;
    public bool [] passageiros = new bool[100];
    

    public Voo(DateTime dataVoo, int numeroVoo)
    {
        this.dataVoo = dataVoo;
        this.numeroVoo = numeroVoo;
        
    }

    public int GetVoo()
    {
        return this.numeroVoo;
    }

    public DateTime GetData()
    {
        return this.dataVoo;
    }
    
    public void SetVoo(DateTime dataVoo)
    {
        this.dataVoo = dataVoo;
    }

    public void SetData(int numeroVoo)
    {
        this.numeroVoo = numeroVoo;
    }

    public int ProximoLivre()
    {
        for (int i = 0; i < this.passageiros.Length; i++)
        {
            if(this.passageiros[i] == false)
            {
                return i+1;
            }
            
        }
        Console.WriteLine("Não há poltronas livres. ");
        return -1;
    }

    public bool Ocupar(int poltrona)
    {
        if (this.passageiros[poltrona] == false)
        {
            this.passageiros[poltrona] = true;
            Console.WriteLine("A poltrona está disponível");
            return true;
        }
        else
        {
            Console.WriteLine("cadeira já está ocupada. ");
           return false;
        }
    }

    public bool Verificar(int poltrona)
    {
        if (this.passageiros[poltrona] == false)
        {
            Console.WriteLine("A poltrona está disponível");
            return true;
        }
        else
        {
            Console.WriteLine("cadeira já está ocupada. ");
            return false;
        }
    }

    public int Vagas()
    {
        int cont = 0;   
        for (int i = 0; i < this.passageiros.Length; i++)
        {
            if (this.passageiros[i] == false)
            {
                cont += 1;
            }

        }
        return cont;
    }

}
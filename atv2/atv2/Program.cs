Voo voo = new Voo(DateTime.Now, 123);

while (true)
{
    Console.WriteLine("Menu:\n" +
   "1- Ver o próximo livre. \n" +
    "2- Verificar as poltronas. \n" +
    "3- Ocupar as poltronas. \n" +
    "4- Vagas disponíveis. \n");

    Console.WriteLine("Escolha uma opção: ");
    int opçaoEscolhida = Convert.ToInt32(Console.ReadLine());

    if (opçaoEscolhida == 1)
    {
        Console.WriteLine("o próximo livre é:" + voo.ProximoLivre() + "\n");
    }

    if (opçaoEscolhida == 2)
    {
        Console.WriteLine("informe a poltrona para verificar: ");
        int poltrona = Convert.ToInt32(Console.ReadLine());
        voo.Verificar(poltrona);
    }

    if (opçaoEscolhida == 3)
    {
        Console.WriteLine("informe a poltrona para ocupar: ");
        int poltrona = Convert.ToInt32(Console.ReadLine());
        voo.Ocupar(poltrona);
    }

    if (opçaoEscolhida == 4)
    {
        Console.WriteLine("o Vagas disponíveis é:" + voo.Vagas() + "\n");
    }
}
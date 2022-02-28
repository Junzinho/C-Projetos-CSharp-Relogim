// See https://aka.ms/new-console-template for more information
using System.Threading;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Champs, você quer que esse cronometro rode em Segundo ou Minuto? (S/M)");
    Console.WriteLine("Vou te quebrar o galho meu querido, pode colocar a quantidade de tempo e no final a letra M ou S");
    string unidade = Console.ReadLine().ToLower();
    int numeroDeCaracteres = unidade.Length;
    switch (numeroDeCaracteres)
    {
        case 1:
            switch (unidade)
            {
                case "s": Segundos(); break;
                case "m": Minutos(); break;
                default: Console.WriteLine("Meu parça, é minuto (m) ou segundo (s)..."); break;
            }; break;
        case 0: Console.WriteLine("Meu parça, é minuto (m) ou segundo (s)..."); break;
        default: Varios(unidade); break;
    }
    Console.ReadKey();
    Console.Clear();
    Menu();
}

static void Varios(string unity)
{
    char tipo = char.Parse(unity.Substring(unity.Length - 1, 1));
    int tempo = int.Parse(unity.Substring(0, unity.Length - 1));
    if (tipo == 'm')
    {
        tempo = tempo * 60;
    }
    else if (tipo == 's')
    { }
    else
    {
        Console.WriteLine("Meu parça, é minuto (m) ou segundo (s)...");
        Console.ReadKey();
        Menu();
    }
    Start(tempo);
}

static void Segundos()
{
    Console.WriteLine("Agora meu querido, quantos segundos você quer?");
    int tempo = int.Parse(Console.ReadLine());
    Start(tempo);

}

static void Minutos()
{
    Console.WriteLine("Agora meu querido, quantos minutos você quer?");
    int tempo = int.Parse(Console.ReadLine());
    tempo = tempo * 60;
    Start(tempo);
}


static void Start(int time)
{

    int tempoAgora = 0;

    while (tempoAgora <= time)
    {
        Console.Clear();
        Console.WriteLine(tempoAgora);
        Thread.Sleep(1000);
        tempoAgora++;


    }
    Console.Clear();
    Console.WriteLine("Cronometro finalizado, aperte enter para rodar novamente.");
    Console.ReadKey();
    Console.Clear();
    Menu();
}


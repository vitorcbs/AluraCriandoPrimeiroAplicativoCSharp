// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
// List<string> listaDasBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\n Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: 
            RegistrarBanda(); 
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            exibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau!");
            break;
        default: 
            Console.WriteLine("Opção inválida"); 
            break;
    }
}

ExibirMenu();


void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registrar Banda");
    Console.Write("Digite o noem da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();   
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Exibindo bandas registradas");
    //for (int x= 0; x < listaDasBandas.Count; x++)
   // {
     //   Console.WriteLine($"Banda: {listaDasBandas[x]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Pressione uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar banda");
    Console.Write("Digite o nome da banda: ");
    string bandaEscolhida = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        Console.Write($"Qual a nota que a {bandaEscolhida} merece?");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[bandaEscolhida].Add(nota);
        Console.WriteLine($"A nota foi registrada com sucesso para a banda {bandaEscolhida}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"A banda {bandaEscolhida} não existe");
        Console.WriteLine("Digite uma tecla para voltar ao menu princial");
        Console.ReadKey();
        Console.Clear();    
        ExibirMenu();
    }
}

void exibirMedia()
{
    Console.Clear();
    ExibirTitulo("Media da banda");
    Console.Write("Qual banda voce deseja ver a média de notas? ");
    string bandaEscolhida = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        double mediaBandaEscolhida = bandasRegistradas[$"{bandaEscolhida}"].Average();
        Console.WriteLine($"A média de notas da banda {bandaEscolhida} é {mediaBandaEscolhida}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"A banda {bandaEscolhida} não existe");
        Console.WriteLine("Digite uma tecla para voltar ao menu princial");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do
{
    Console.WriteLine("Digite um numero entro 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabens, voce acertou o numero");
        break;
    } else if (chute < numeroSecreto)
    {
        Console.WriteLine("O numero e maior!");
    }
    else
    {
        Console.WriteLine("O numero e menor");
    } 
} while(true);  
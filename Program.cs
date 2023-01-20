using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.OutputEncoding = System.Text.Encoding.UTF8;
Iphone iphone = new Iphone();
Nokia nokia = new Nokia();

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha o smartphone digitando a opção:");
    Console.WriteLine("1 - Iphone");
    Console.WriteLine("2 - Nokia");
    Console.WriteLine("3 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            iphone.MenuSmartphone();
            break;

        case "2":
            nokia.MenuSmartphone();
            break;

        case "3":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
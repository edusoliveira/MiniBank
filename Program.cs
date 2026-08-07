
while (true)
{
    ExibirMenu();
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        case "2":
        case "3":
        case "4":
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            break;
        case "5":
            Console.WriteLine("Obrigado por usar o MiniBank. Até logo!");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

static void ExibirMenu()
{
    Console.WriteLine("======================================================");
    Console.WriteLine("          MINI BANK - SEU BANCO DIGITAL");
    Console.WriteLine("======================================================");

    Console.WriteLine("1. Criar conta");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Sacar");
    Console.WriteLine("4. Ver saldo");
    Console.WriteLine("5. Sair");

    Console.WriteLine("Escolha uma opção: ");
}
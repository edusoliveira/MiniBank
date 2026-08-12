using MiniBank;
using System;
using System.Globalization;

while (true)
{
    ExibirMenu();
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            Conta conta = new Conta();

            Console.WriteLine("Digite o seu nome completo: ");
            conta.Titular = Console.ReadLine();
            Console.WriteLine("Agora, digite o seu saldo incial: ");
            conta.Saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Conta criada com sucesso!");
            Console.WriteLine($"Titular: {conta.Titular}");
            Console.WriteLine($"Saldo Inicial: {conta.Saldo:C}");
            break;
                 
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
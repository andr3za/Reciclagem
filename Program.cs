
using reciclagem;

Console.WriteLine("Reciclagem");

Reciclagem reciclagens = new Reciclagem();

bool menu = true;

while (menu)
{
    Console.Clear();

    Console.WriteLine("Bem vindo ao mundo da reciclagem!\n");
    Console.WriteLine("Escolha a opção desejada:\n");
    Console.WriteLine("1- Apresentação");
    Console.WriteLine("2- Quiz: Escolha a lixeira correta");
    Console.WriteLine("3- Quiz: Quem sou eu?");
    Console.WriteLine("4- Quiz: É reciclável ou não?");
    Console.WriteLine("5- Sair");

    int opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        reciclagens.Apresentacao();
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar:");
        Console.ReadKey();
    }

    else if (opcao == 2)
    {
        reciclagens.Quiz1();
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar:");
        Console.ReadKey();
    }

    else if (opcao == 3)
    {
        reciclagens.Quiz2();
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar:");
        Console.ReadKey();
    }

    else if (opcao == 4)
    {
        reciclagens.Quiz3();
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar:");
        Console.ReadKey();
    }


    else if (opcao == 5)
    {
        string sair = Console.ReadLine();
        menu = false;
    }

}

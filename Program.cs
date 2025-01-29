

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
    }
}

static void Open()
{

}

static void Edit()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo. (ESC para sair)");
    Console.WriteLine("-------------------------");
    string text = "";

    do // iteração e concatenação dos valores.
    {
        text += Console.ReadLine();
        text += Environment.NewLine; // quebra de linha
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.WriteLine(text);
}
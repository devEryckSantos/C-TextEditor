

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
        case 2: Edit();  break;
    }
}

static void Open()
{

}

static void Edit()
{

}
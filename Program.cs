

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
        case 2: Create(); break;
    }
}

static void Open()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo?");
    var path = Console.ReadLine();

    using (var file = new StreamReader(path)) // leitura do documento
    {
        string text = file.ReadToEnd(); // ler o documento até o final
        Console.WriteLine(text);
    }

    Console.ReadLine();
    Menu();
}

static void Create()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo. (ESC para sair)");
    Console.WriteLine("----------------------------------------");
    string text = "";

    do // iteração e concatenação dos valores.
    {
        text += Console.ReadLine();
        text += Environment.NewLine; // quebra de linha
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);
}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path)) // criação do arquivo
    {
        file.Write(text);
    }

    Console.WriteLine($"Aquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}
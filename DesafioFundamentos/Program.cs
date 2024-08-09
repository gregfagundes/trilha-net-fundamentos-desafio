using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear();
Console.Write("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial: R$ ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: R$ ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

string[] menuOpcoes = {
    " Digite a sua opção ",
    " 1 - Cadastrar veículo ",
    " 2 - Remover veículo ",
    " 3 - Listar veículos ",
    " 4 - Encerrar "
};

// Realiza o loop do menu
while (exibirMenu)
{
    CriarMenu(0, menuOpcoes);

    Console.Write("Digite a opção desejada: ");
    opcao = Console.ReadLine();


    if (int.TryParse(opcao, out int resultado))
    {
        if (resultado >= 1 && resultado <= menuOpcoes.Length - 1)
        {
            CriarMenu(resultado, menuOpcoes);
        }

    }
    switch (opcao)
    {
        case "1":
            Console.WriteLine();
            es.AdicionarVeiculo();
            break;

        case "2":
            Console.WriteLine();
            es.ListarVeiculos();
            Console.WriteLine();
            es.RemoverVeiculo();
            break;

        case "3":
            Console.WriteLine();
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

static void CriarMenu(int posicaoMenu, string[] menuOpcoes)
{
    Console.Clear();
    Console.WriteLine("###################### MENU ######################");

    for (int i = 0; i < menuOpcoes.Length; i++)
    {
        if (i == posicaoMenu)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(menuOpcoes[i]);
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine(menuOpcoes[i]);
        }
    }

    Console.WriteLine("##################################################");
}
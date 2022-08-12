using MaquinaDeBebidas;

Maquina maquina = new Maquina();

maquina.Refrigerante = 1;
maquina.Energetico = 1;
maquina.Agua = 1;
maquina.Suco = 1;
maquina.Cafe = 1;
bool loop = true;

while (loop)
{
    Console.WriteLine("Escolha uma das opções do menu:");
    Console.Write("1 - refrigerante R$:5,00 -- 2 - energético R$:10,00 -- 3 - água R$: 2,00 -- 4 - suco R$:5,00 -- 5 - café R$:2,50 -- (R) - Repor -- (S) - Sair: ");
    maquina.OpcaoMenu = Console.ReadLine();

    if (maquina.OpcaoMenu == "1")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "2")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "3")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "4")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "5")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "r")
    {
        Console.Clear();
        maquina.Repor();
    }
    if (maquina.OpcaoMenu == "s")
    {
        Console.Clear();
        Console.WriteLine($"Obrigado por usar nossa máquina. Seu total gasto foi de: {maquina.ValorTotal}");
        break;

    }
}
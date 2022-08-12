using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeBebidas
{
    public class Maquina
    {
        public string OpcaoMenu { get; set; }
        public int Refrigerante { get; set; }

        public int Suco { get; set; }

        public double Cafe { get; set; }

        public int Energetico { get; set; }

        public int Agua { get; set; }

        public double ValorTotal { get; set; }

        public void Comprar()
        {
            if(OpcaoMenu == "1" && Refrigerante > 0)
            {
                Refrigerante = 0;
                ValorTotal = ValorTotal + 5.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "1" && Refrigerante == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "2" && Energetico > 0)
            {
                Energetico = 0;
                ValorTotal = ValorTotal + 10.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "2" && Energetico == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "3" && Agua > 0)
            {
                Agua = 0;
                ValorTotal = ValorTotal + 2.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "3" && Agua == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "4" && Suco > 0)
            {
                Suco = 0;
                ValorTotal = ValorTotal + 5.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "4" && Suco == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "5" && Cafe > 0)
            {
                Cafe = 0;
                ValorTotal = ValorTotal + 2.50;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "5" && Cafe == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
        }
        public void Repor()
        {
            if (OpcaoMenu == "r")
            {
                Console.WriteLine("Digite o número do produto que deseja repor");
                string produtoR = Console.ReadLine();

                if (produtoR == "1" && Refrigerante == 0)
                {
                    Refrigerante++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "1" && Refrigerante > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "2" && Energetico == 0)
                {
                    Energetico++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "2" && Energetico > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "3")
                {
                    Agua++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "3" && Agua > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "4")
                {
                    Suco++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "4" && Suco > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "5")
                {
                    Cafe++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "5" && Cafe > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
            }

        }
    }
}

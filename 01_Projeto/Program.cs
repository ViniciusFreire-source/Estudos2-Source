using _01_Projeto.Tela;
using System;

namespace _01_Projeto
{
    class Program
    {
        static void Main(string[] args) //Desenvolvimento em camada
        {

            int opcoes = 0;
            while (opcoes != 5) 
            {
                Console.WriteLine("O que deseja fazer? \n1 = Cadastrar Cliente, \n2 = Lista de Clientes, \n3 = Cadastrar Funcionário, \n4 = Lista de Funcionários, \n5 = Fechar programa!");
                opcoes = int.Parse(Console.ReadLine());

                ManterCliente telaCliente = new ManterCliente();
                ManterFuncionario telaFuncionario = new ManterFuncionario();

            switch (opcoes)
                {
                case 1:
                    telaCliente.CadastrarCliente();
                    break;
                case 2:
                    telaCliente.ListarClientes();
                    break;
                case 3:
                    telaFuncionario.CadastrarFuncionario();
                    break;
                case 4:
                    telaFuncionario.ListarFuncionarios();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Comando Invalido!");
                    break;

                }
            }

        }
    }
}

using Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;
using _01_Projeto.Conversores;
using Lib.Arquivo;

namespace _01_Projeto.Tela
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE");
            
            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();

            Console.Write("CEP (digitar apenas numero) : ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            cliente.Endereco = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));



        }
        public void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE CLIENTES");
            string[] linhas = GerenciadorArquivo.LerArquivo("cliente");
            foreach (string linha in linhas)
            {
                Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linha);
                Console.WriteLine("NOME: " + cliente.Nome);
                Console.WriteLine("");
            }
        }
    }
}

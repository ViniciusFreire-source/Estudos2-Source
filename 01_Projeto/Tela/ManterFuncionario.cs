using System;
using System.Collections.Generic;
using System.Text;
using _01_Projeto.Conversores;
using Lib.Arquivo;
using Lib.Model;

namespace _01_Projeto.Tela
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.Write("CEP (digitar apenas numero) : ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            funcionario.Endereco = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Data de contratação: ");
            funcionario.DataContratacao = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
        }
        public void ListarFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE FUNCIONARIOS");
            string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");
            foreach (string linha in linhas)
            {
                Funcionario funcionario = Conversores.FuncionarioTexto.ConverterParaFuncionario(linha);
                Console.WriteLine("NOME: " + funcionario.Nome + " CARGO: " + funcionario.Cargo);
                Console.WriteLine("");
            }
        }
    }
}

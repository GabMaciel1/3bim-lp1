using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    internal class Program
    {
        struct Cadastro
        {
            public string Nome;
            public int Idade;
            public string Sexo;
            public string CPF;
            public string Telefone;
            public string Cidade;
            public string Estado;

            public Cadastro(string nome, int idade, string sexo, string cpf, string telefone, string cidade, string estado)
            {
                Nome = nome;
                Idade = idade;
                Sexo = sexo;
                CPF = cpf;
                Telefone = telefone;
                Cidade = cidade;
                Estado = estado;
            }

            public void ExibirCadastro()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Idade: {Idade}");
                Console.WriteLine($"Sexo: {Sexo}");
                Console.WriteLine($"CPF: {CPF}");
                Console.WriteLine($"Telefone: {Telefone}");
                Console.WriteLine($"Cidade: {Cidade}");
                Console.WriteLine($"Estado: {Estado}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Criar Cadastro");
            Console.WriteLine("2. Ler Cadastros");
            Console.WriteLine("3. Atualizar Cadastro");
            Console.WriteLine("4. Excluir Cadastro");
            Console.WriteLine("5. Sair");

            int decisao;
            decisao = int.Parse(Console.ReadLine());

            switch (decisao)
            {
                case 1:
                    Console.WriteLine("Criar Cadastro:");

                    Console.WriteLine("nome:");
                    string nome = Console.ReadLine();
                    while (Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"));
                        {
                        Console.WriteLine(" Nome invalido, digite apenas letras. Digite seu nome:");
string nome = Console.ReadLine();
                    }

                    Console.WriteLine("idade:");
                    int idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("sexo:");
                    string sexo = Console.ReadLine();

                    Console.WriteLine("cpf:");
                    string cpf = Console.ReadLine();

                    Console.WriteLine("telefone:");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("cidade:");
                    string cidade = Console.ReadLine();

                    Console.WriteLine("estado:");
                    string estado = Console.ReadLine();

                    Cadastro novoCadastro = new Cadastro(nome, idade, sexo, cpf, telefone, cidade, estado);
                    novoCadastro.ExibirCadastro();


                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}


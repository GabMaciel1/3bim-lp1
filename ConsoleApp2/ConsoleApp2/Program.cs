using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nome:
            //idade:
            //sexo:
            //cpf:
            //telefone:
            //cidade:
            //estado:
            Console.WriteLine("1. Criar Cadastro");
            Console.WriteLine("2. Ler Cadastros");
            Console.WriteLine("3. Atualizar Cadastro");
            Console.WriteLine("4. Excluir Cadastro");
            Console.WriteLine("5. Sair");

            //escolhendo qual opção do menu abrir
            int decisao;
            decisao = int.Parse(Console.ReadLine());

            switch (decisao)
            {
                case 1
                    : Console.WriteLine("Criar Cadastro:")

                        Console.WriteLine("nome:");
                        Console.ReadLine();

                    Console.WriteLine("idade:");
                    Console.ReadLine();

                    Console.WriteLine("sexo:");
                    Console.ReadLine();

                    Console.WriteLine("cpf:");
                    Console.ReadLine();

                    Console.WriteLine("telefone:");
                    Console.ReadLine();

                    Console.WriteLine("cidade:");
                    Console.ReadLine();

                    Console.WriteLine("estado:");
                    Console.ReadLine();







            }

        }
    }
}

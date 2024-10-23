using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //apresentação das opções do menu inicial
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
                case 1:
                    //--------CRIAR CADASTRO-------
                    //lista de cadastros criada
                    cadastro cadastroTeste = new cadastro();
                    cadastroTeste.nome = "Nicolas";
                    cadastroTeste.idade = "17";
                    //"sexo só podem ser dois", usar if else
                    cadastroTeste.sexo = "m";
                    cadastroTeste.cpf = "123456-78";
                    cadastroTeste.telefone = "(13) 1234-1234";
                    cadastroTeste.cidade = "Santos";
                    //estado só podem ter duas letras, usar if else
                    cadastroTeste.estado = "SP";
                    List<cadastro> ListaDeCadastros= new List<cadastro>();
                    ListaDeCadastros.Add(cadastroTeste);
                    //criando um novo cadastro
                    //falta colocar a formatação
                    
                    cadastro cadastro1 = new cadastro(); //uma opção é criar uma array de 99999 espaços
                    Console.WriteLine("1. Criar Cadastro");
                    Console.WriteLine("Nome:");
                    cadastro1.nome = Console.ReadLine();
                    cadastro1.idade = Console.ReadLine();
                        //"sexo só podem ser dois", usar if else
                    cadastro1.sexo = Console.ReadLine();
                    cadastro1.cpf = Console.ReadLine();
                    cadastro1.telefone = Console.ReadLine();
                    cadastro1.cidade = Console.ReadLine();
                        //estado só podem ter duas letras, usar if else
                    cadastro1.estado = Console.ReadLine();
                       
                    ListaDeCadastros.Add(cadastro1);
                        //como criar um novo cadastro sem excluir esse?
                    break;
                case 2:
                    //--------LER CADASTROS---------
                        //mostrar todos os cadastros usando foreach?
                        foreach (cadastro c in ListaDeCadastros)
                    {
                        Console.WriteLine("Cadastro {0}", c);
                    }
                    break;
                case 3:
                    //---------ATUALIZAR CADASTRO--------
                        //usar um switch case pra saber se o usuario quer
                        //alterar algum dado em especifico ou todos
                    break;
                case 4:
                    //---------EXCLUIR CADASTRO------------
                        //como fazer para preencher o cadastro de mesmo número?
                    break;
                case 5:
                    //-------------SAIR---------------------
                        //arranjar um jeito de sair da estrutura switch case
                        // e finalizar então o codigo com um aviso
                        // de que os cadastros não serão salvos
                    break;
                default:
                    //-----------------NUMERO NAO EXISTE-----------------
                        //informar que a opção não existe e fazer ele
                        // retornar ao comeco da estrutura switch case
                        // usando o goto?
                    break;
            
            }


        }
            //criando a estrutura do cadastro
         public struct cadastro
        {
                // falando quais dados o nosso cadastro vai ter
            public string nome { get; set; }
            public string idade { get; set; }
            public string sexo { get; set; }
            public string cpf { get; set; }
            public string telefone { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }


        }
    }
}

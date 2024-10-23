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


            //inicializando a array de cadastros
            Console.WriteLine("Digite quantos cadastros serão criados no total:");
            int m = int.Parse(Console.ReadLine());
            TipoCadastro[] cadArray = new TipoCadastro[m];


            switch (decisao) //no inicio de cada case, perguntar se ele quer voltar pro menu
            {
                case 1:
                    //--------CRIAR CADASTRO-------
                    //lista de cadastros criada


                    Console.WriteLine("Voce quer colocar os dados do cadastro de numero:");
                    int n = int.Parse(Console.ReadLine());
                    cadArray[n].nome = "abcd";
                    cadArray[n].idade = "20";
                    cadArray[n].sexo = "n";
                    cadArray[n].cpf = "1234567890";
                    cadArray[n].telefone = "13 23456";
                    cadArray[n].cidade = "Santos";
                    cadArray[n].estado = "SP";
                    Console.WriteLine("Seu cadastro foi criado!");
                    cadArray[n].info();

               
                    break;
                case 2:
                    //--------LER CADASTROS---------
                    //mostrar todos os cadastros usando foreach?
                    Console.WriteLine("Aqui está lista dos cadastros, tanto dos que ja estão preenchidos quanto dos que ainda nao estão.");
                    for (int i = 0; i > m; i++)
                    {
                        cadArray[i].info();
                    }
                    break;
                case 3:
                    //---------ATUALIZAR CADASTRO--------
                    //usar um switch case pra saber se o usuario quer

                    Console.WriteLine("Qual cadastro você quer atualizar?");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Este é o cadastro escolhido!");
                    cadArray[a].info();
                    Console.WriteLine("Tem certeza de que quer atualizar este cadastro? (escolha s/n)");
                    string confirmacao = Console.ReadLine();
                    if (confirmacao == "s")
                    {
                        //atualizar o cadastro
                    }else
                    {
                        //goto inicio do case 3
                    }
                    







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

    }
    struct TipoCadastro
    {
        public string nome; //apenas letras
        public string idade; //apenas números
        public string sexo; //"apenas M ou F"
        public string cpf; //deve ter 11 digitos, mas com validaçao do digito verificador
        public string telefone; // modelo (12) 12345-1234
        public string cidade; //apenas letras
        public string estado; // apenas duas letras

        public void info()
        {
            //adicionar formatação
            Console.WriteLine("Nome: {0}", this.nome);
            Console.WriteLine("Idade: {0}", this.idade);
            Console.WriteLine("Sexo: {0}", this.sexo);
            Console.WriteLine("Cpf: {0}", this.cpf);
            Console.WriteLine("Telefone: {0}", this.telefone);
            Console.WriteLine("Cidade: {0}", this.cidade);
            Console.WriteLine("Estado: {0}", this.estado);
            Console.WriteLine("--------------------------");
        }
    }
}

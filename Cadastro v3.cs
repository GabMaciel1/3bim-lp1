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
                    //declarando variavel n 
                    int n = 0;
                    string reescrever = "";

                    Console.WriteLine("Para começar, você gostaria de escolher qual dos 10 cadastros você vai preencher? (s/n)");
                    string confirmacao0 = Console.ReadLine();
                    if (confirmacao0 == "s" || confirmacao0 =="S")
                    {
                        Console.WriteLine("Qual o número do cadastro que você deseja preencher?");
                        n = int.Parse(Console.ReadLine());
                        if (cadArray[n].statusCadastro == "concluido")
                        {
                            Console.WriteLine("Este cadastro já está preenchido, deseja reescrevê-lo? (s/n)");
                            reescrever = Console.ReadLine();
                            if (reescrever == "n" || reescrever =="N")
                            {
                                //goto inicio da criaçao de cadastro
                            }
                            else
                            {
                                if (reescrever == "s" || reescrever=="S")
                                {
                                    //segue em frente
                                }
                                else
                                {
                                    Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                                    //goto volta pro inicio da criaçao de cadastro??
                                }
                                    
                            }

                        }
                    }
                    else
                    {
                            if (confirmacao0 == "n" || confirmacao0 == "N")
                        {
                           for (int i = cadArray.Length; i < 0; i--)
                            {
                                if (cadArray[i].statusCadastro != "concluido")
                                {
                                    n = i;
                                }
                            }
                        }else
                        {
                            Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                            //goto inicio da criação do cadastro
                        }
                    }
                    

                    Console.WriteLine("Olá você está na parte de criação de cadastros! Insira os seguintes dados: ");
                    Console.WriteLine("Nome: ");
                    cadArray[n].nome = Console.ReadLine();
                    Console.WriteLine("Idade: ");
                    cadArray[n].idade = Console.ReadLine();
                    Console.WriteLine("Sexo: ");
                    cadArray[n].sexo = Console.ReadLine();
                    Console.WriteLine("cpf: ");
                    cadArray[n].cpf = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    cadArray[n].telefone = Console.ReadLine();
                    Console.WriteLine("Cidade: ");
                    cadArray[n].cidade = Console.ReadLine();
                    Console.WriteLine("Estado: ");
                    cadArray[n].estado = Console.ReadLine();
                    Console.WriteLine("Digite a palavra 'concluido': ");
                    cadArray[n].statusCadastro = Console.ReadLine();

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
                    if (confirmacao == "s" || confirmacao == "S")
                    {
                        //atualizar o cadastro
                        cadArray[a].nome = Console.ReadLine();
                        cadArray[a].idade = Console.ReadLine();
                        cadArray[a].sexo = Console.ReadLine();
                        cadArray[a].cpf = Console.ReadLine();
                        cadArray[a].telefone = Console.ReadLine();
                        cadArray[a].cidade = Console.ReadLine();
                        cadArray[a].estado = Console.ReadLine();
                        Console.WriteLine("Seu cadastro foi atualizado!");
                        cadArray[a].info();

                    }
                    else
                    {
                        if (confirmacao == "n" || confirmacao == "N")
                        {
                            //goto inicio do case 3
                        }
                        else
                        {
                            Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                            //goto inicio do case 3
                        }

                    }








                    break;
                case 4:
                    //---------EXCLUIR CADASTRO------------

                    //inicialização de variaveis (porque elas nao podem ser inicializadas dentro do if)

                    int exclusao = 0;
                    string confirmacao2 = "";
                    string confirmacao3 = "";
                    string confirmacao4 = "";

                    Console.WriteLine("Olá! Você está na área de exlusão de cadastros, você gostaria de ver a lista de cadastros para se decidir se exluirá ou não algum? (s/n)");
                    confirmacao2 = Console.ReadLine();
                    if (confirmacao2 == "s")
                    {
                        for (int i = 0; i < cadArray.Length; i++)
                        {
                            cadArray[i].info();
                        }
                        Console.WriteLine("Tem certeza de que voê quer exluir os dados de algum cadstro, você não poderá voltar atrás! (s/n)");
                        confirmacao4 = Console.ReadLine();
                        if (confirmacao4 == "s" || confirmacao4 == "S")
                        {
                            Console.WriteLine("Então digite o número do cadastro que deseja exluir: ");
                            exclusao = int.Parse(Console.ReadLine());

                            cadArray[exclusao].nome = "";
                            cadArray[exclusao].idade = "";
                            cadArray[exclusao].sexo = "";
                            cadArray[exclusao].cpf = "";
                            cadArray[exclusao].telefone = "";
                            cadArray[exclusao].cidade = "";
                            cadArray[exclusao].estado = "";
                            Console.WriteLine("Seu cadastro foi excluído!");
                            Console.WriteLine("Agora ele está assim: ");
                            cadArray[exclusao].info();
                        }
                        else
                        {
                            if (confirmacao4 == "n" || confirmacao4 == "N")
                            {
                                //goto menu
                            }
                            else
                            {
                                Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                                //goto inicio do case 4

                            }


                        }


                    }
                    else
                    {
                        if (confirmacao2 == "n" || confirmacao2 == "N")
                        {
                            Console.WriteLine("Tem certeza de que voê quer exluir os dados de algum cadstro, você não poderá voltar atrás! (s/n)");
                            confirmacao4 = Console.ReadLine();
                            if (confirmacao4 == "s" || confirmacao4 =="S")
                            {
                                Console.WriteLine("Então digite o número do cadastro que deseja exluir: ");
                                exclusao = int.Parse(Console.ReadLine());

                                cadArray[exclusao].nome = "";
                                cadArray[exclusao].idade = "";
                                cadArray[exclusao].sexo = "";
                                cadArray[exclusao].cpf = "";
                                cadArray[exclusao].telefone = "";
                                cadArray[exclusao].cidade = "";
                                cadArray[exclusao].estado = "";
                                Console.WriteLine("Seu cadastro foi excluído!");
                                Console.WriteLine("Agora ele está assim: ");
                                cadArray[exclusao].info();

                            }
                            else
                            {
                                //goto menu
                            }


                        }






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
            public string statusCadastro; //só pode aceitar a palavra "concluido"

            public void info()
            {
                //adicionar formatação
                Console.WriteLine("Status do Cadastro: {0}", this.statusCadastro);
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
}


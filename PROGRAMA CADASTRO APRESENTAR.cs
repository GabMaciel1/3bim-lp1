using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //preparando o programa
            //inicializando e definindo a array de cadastros
            Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
            //Console.WriteLine("|                                                                                             |");
            Console.WriteLine("       Bom Dia! Seja muito bem vindo ao nosso programa super tecnológico de Cadastros!   ");
            Console.WriteLine();
            Console.WriteLine("             Para começar, por favor digite quantos cadastros você pretende criar! ");
            Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
            Console.Write("--> ");
            int qntdCadastros = int.Parse(Console.ReadLine());
            TipoCadastro[] cadArray = new TipoCadastro[qntdCadastros];
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                  -- Obrigado por informar! --");
            Console.WriteLine("                              (pressione qualquer tecla pra continuar)");
            Console.ReadKey();
            Console.Clear();

            //por uma questão de organização e de algoritmo de busca
            //estamos definindo os indices do cadastro como uma característica dele
            for (int i = 0; i < qntdCadastros; i++)
            {
                cadArray[i].indice = i;
            }

        menu: //aqui é basicamente o inicio do programa, o menu, onde é escolhida a interface!
            Console.Clear(); //limpando a interface para quem veio do GoTo.

            //apresentação das opções do menu inicial
            Console.WriteLine("Seja bem vindo ao nosso Programa de Cadastros!");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------- MENU ----------------------------------------");
            Console.WriteLine("                            1. Criar Cadastro                                        ");
            Console.WriteLine("                            2. Ler Cadastros                                         ");
            Console.WriteLine("                            3. Atualizar Cadastro                                    ");
            Console.WriteLine("                            4. Excluir Cadastro                                      ");
            Console.WriteLine("                            5. Sair                                                  ");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine();

            //escolhendo qual opção do menu abrir
            Console.WriteLine("Escolha uma das Interfaces digitando de 1 a 5.");
            Console.WriteLine("(você poderá voltar para o Menu depois)");
            string decisao = Console.ReadLine();
            //fazer alguma coisa para impedir que qualquer coisa alem dos numeros de 1 ate 5 sejam aceitos
            if (decisao == "1" || decisao == "2" || decisao == "3" || decisao == "4" || decisao == "5")
            {
                //codigo simplesmente continua
            }
            else
            { //cidadão escreveu o digito errado
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                Console.WriteLine("               Eita... Parece que a opção que você escolheu não existe...");
                Console.WriteLine("Mas fique despreocupado, você será redirecionado para a Interface do Menu Inicial!");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                Console.WriteLine();
                Console.WriteLine("    ...(pressione qualquer tecla para continuar)");
                Console.ReadKey();
                goto menu;
            }


            switch (decisao) //no inicio de cada case, perguntar se ele quer voltar pro menu
            {
                case "1":
                //--------CRIAR CADASTRO-------
                criacaoDeCadastro:
                    Console.Clear();
                    //lista de cadastros criada
                    //declarando variaveis usadas na seção 
                    int n = 0;
                    string reescrever = "";
                    string listavazia = "";

                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine("   Para começar, você gostaria de ESCOLHER ALGUM em específico dos {0} cadastros você vai preencher? (s/n)...", qntdCadastros);
                    string confirmacao0 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    if (confirmacao0 == "s" || confirmacao0 == "S")
                    {
                        Console.WriteLine();
                        Console.Write("Qual o NÚMERO do cadastro que você deseja preencher?");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");

                        if (cadArray[n].statusCadastro == "concluido")
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("       Este cadastro já está preenchido, deseja reescrevê-lo? (s/n)          ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            reescrever = Console.ReadLine();
                            if (reescrever == "n" || reescrever == "N")
                            {
                                goto criacaoDeCadastro;
                            }
                            else
                            {
                                if (reescrever == "s" || reescrever == "S")
                                {
                                    //segue em frente
                                }
                                else
                                {
                                    // o cidadao escreveu errado
                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                    Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                                    Console.WriteLine("            (pressione qualquer tecla para tentar de novo)");
                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                    Console.ReadKey();
                                    goto criacaoDeCadastro;
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
                        }
                        else
                        {
                            // o cidadao escreveu errado
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                            Console.WriteLine("            (pressione qualquer tecla para tentar de novo)");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadKey();
                            goto criacaoDeCadastro;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine("Chegou a hora de preencher o seu Cadastro! Insira os seguintes dados: ");
                    Console.Write("| Nome: ");
                    cadArray[n].nome = Console.ReadLine();
                    Console.Write("| Idade: ");
                    cadArray[n].idade = Console.ReadLine();                                                   //COLOCAR CRIAÇÃO DE CADASTRO V4
                    Console.Write("| Sexo: ");
                    cadArray[n].sexo = Console.ReadLine();
                    Console.Write("| CPF: ");
                    cadArray[n].cpf = Console.ReadLine();
                    Console.Write("| Telefone: ");
                    cadArray[n].telefone = Console.ReadLine();
                    Console.Write("| Cidade: ");
                    cadArray[n].cidade = Console.ReadLine();
                    Console.Write("| Estado: ");
                    cadArray[n].estado = Console.ReadLine();
                    Console.Write("| Digite a palavra 'concluido': "); //registrando a conclusão do cadastro para a Lista de Cadastros
                    cadArray[n].statusCadastro = Console.ReadLine();

                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine("                          --- Seu Cadastro foi aceito! ---                                    ");
                    Console.WriteLine("                     Obrigado por se Cadastrar em nosso programa!                             ");
                    Console.WriteLine("                            Aqui está o seu cadastro:                                         ");
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    cadArray[n].info();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       (pressione qualquer tecla para voltar ao Menu Inicial)                 ");
                    Console.ReadKey();

                    goto menu; //voltando para a tela do Menu Inicial

                    break;
                case "2":
                    //--------LER CADASTROS---------
                    //mostrar todos os cadastros usando for
                    Console.Clear();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine("                 Olá!! Você está na Interface de Leitura de Cadastros!                        ");
                    Console.WriteLine("                                Abaixo está a Lista dos Cadastros!                            ");
                    Console.WriteLine("                                                                                              ");
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");

                    //esse for vai percorrer todo o vetor de cadastros, mostrando todos eles, usando a funcao .info que vai dar os dados já formatados
                    for (int i = 0; i < qntdCadastros; i++)
                    {

                        cadArray[i].info();


                    }


                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    Já terminou sua leitura...?                               ");
                    Console.WriteLine("                           (aperte qualquer tecla para voltar ao Menu inicial)                ");

                    Console.ReadKey();

                    //voltando para o menu
                    goto menu;



                    break;
                case "3":
                //---------ATUALIZAR CADASTRO--------
                //usar um switch case pra saber se o usuario quer
                atualizarCadastro:
                    Console.Clear(); //limpando todas as informações anteriores para uma melhor visualização da interface atual
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine("               Olá!! Você está na Interface de Atualização de Cadastros!                      ");
                    Console.WriteLine("              Por acaso você gostaria de ver a Lista de Cadastros existente? (s/n)            ");
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.Write("--> ");
                    string confirmacao5 = Console.ReadLine();
                    if (confirmacao5 == "s" || confirmacao5 == "S")
                    {
                        for (int i = 0; i > qntdCadastros; i++)
                        {
                            Console.WriteLine("NOTE QUE SE NESTE ESPAÇO NÃO HOUVEREM CADASTROS, A LISTA ESÁ VAZIA");
                            if (cadArray[i].statusCadastro == "concluido")
                            {
                                cadArray[i].info();
                            }
                            Console.WriteLine();
                        }
                        // comentando pra ver o que muda Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    }
                    else
                    {
                        if (confirmacao5 == "n" || confirmacao5 == "N")
                        {
                            //fazer nada, siplesmente prosseguir
                        }
                        else
                        {
                            // o cidadao escreveu errado
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                            Console.WriteLine("            (pressione qualquer tecla para tentar de novo)                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadKey();
                            goto atualizarCadastro; //voltando para o comeco pra refazer o processo

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine("Qual cadastro você quer atualizar?...");
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.Write("--> ");
                    int atualizar = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine("Este é o cadastro escolhido!");
                    Console.WriteLine();
                    cadArray[atualizar].info();
                    Console.WriteLine();
                    Console.WriteLine("------------Tem CERTEZA de que quer atualizar este cadastro? (escolha s/n)--------------");
                    Console.Write("--> ");
                    string confirmacao = Console.ReadLine();
                    if (confirmacao == "s" || confirmacao == "S")
                    {
                        //atualizar o cadastro
                        Console.WriteLine();
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        Console.WriteLine();
                        Console.WriteLine("Chegou a hora de preencher o seu Cadastro! Insira os seguintes dados: ");
                        Console.WriteLine();
                        Console.Write("| Nome: ");
                        cadArray[atualizar].nome = Console.ReadLine();
                        Console.Write("| Idade: ");
                        cadArray[atualizar].idade = Console.ReadLine();                                                   //COLOCAR CRIAÇÃO DE CADASTRO V4
                        Console.Write("| Sexo: ");
                        cadArray[atualizar].sexo = Console.ReadLine();
                        Console.Write("| CPF: ");
                        cadArray[atualizar].cpf = Console.ReadLine();
                        Console.Write("| Telefone: ");
                        cadArray[atualizar].telefone = Console.ReadLine();
                        Console.Write("| Cidade: ");
                        cadArray[atualizar].cidade = Console.ReadLine();
                        Console.Write("| Estado: ");
                        cadArray[atualizar].estado = Console.ReadLine();

                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        Console.WriteLine();
                        Console.WriteLine("                          --- Seu Cadastro foi aceito! ---                                    ");
                        Console.WriteLine("                     Obrigado por se Cadastrar em nosso programa!                             ");
                        Console.WriteLine("                         Aqui está o seu cadastro atualizado:                                 ");
                        Console.WriteLine();
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        cadArray[atualizar].info();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                       (pressione qualquer tecla para voltar ao Menu Inicial)                 ");
                        Console.ReadKey(); ;
                        goto menu;

                    }
                    else
                    {
                        if (confirmacao == "n" || confirmacao == "N")
                        {
                            goto atualizarCadastro;
                        }
                        else
                        {
                            // o cidadao escreveu errado
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                            Console.WriteLine("            (pressione qualquer tecla para tentar de novo)");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadKey();
                            goto atualizarCadastro;
                        }
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        Console.WriteLine();
                        Console.WriteLine("Agora que já terminou seu trabalho por aqui....");
                        Console.WriteLine("Você será redirecionado para o Menu Inicial!");
                        Console.WriteLine();
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("(aperte qualquer tecla para continuar)");

                        goto menu; //voltando para o menu inicial depois de ter atualizado o cadastro desejado
                    }
                    break;
                case "4":
                //---------EXCLUIR CADASTRO------------


                excluirCadastro:
                    Console.Clear(); //limpando a interface para aqueles que vieram do menu

                    //inicialização de variaveis (porque elas nao podem ser inicializadas dentro do if)
                    int exclusao = 0;
                    string confirmacao2 = "";
                    string confirmacao3 = "";
                    string confirmacao4 = "";

                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine("                      Olá!! Você está na Interface de EXCLUSÃO de Cadastros!");
                    Console.WriteLine("      Você gostaria de ver a Lista de Cadastros para DECIDIR se exluirá ou não algum deles? (s/n)...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.Write("-->");
                    confirmacao2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    if (confirmacao2 == "s" || confirmacao2 == "S")
                    {
                        Console.WriteLine("NOTE QUE SE AQUI NÃO APARECER NENHUM CADASTRO, A LISTA ESTÁ VAZIA!");
                        Console.WriteLine();
                        for (int i = 0; i < cadArray.Length; i++)
                        {

                            if (cadArray[i].statusCadastro == "concluido")
                            {
                                cadArray[i].info();
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Tem certeza de que você quer exluir os dados de algum cadastro? Você não poderá voltar atrás! (s/n)...");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------");
                        Console.Write("-->");
                        confirmacao3 = Console.ReadLine();
                        Console.WriteLine();
                        if (confirmacao3 == "s" || confirmacao3 == "S")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Então digite o número do cadastro que deseja exluir: ");
                            Console.Write("-->");
                            exclusao = int.Parse(Console.ReadLine());
                            Console.WriteLine();


                            cadArray[exclusao].nome = "";
                            cadArray[exclusao].idade = "";
                            cadArray[exclusao].sexo = "";
                            cadArray[exclusao].cpf = "";
                            cadArray[exclusao].telefone = "";
                            cadArray[exclusao].cidade = "";
                            cadArray[exclusao].estado = "";
                            cadArray[exclusao].statusCadastro = "incompleto";
                            Console.WriteLine("------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                       Seu cadastro foi excluído!");
                            Console.WriteLine("                                         Agora ele está assim: ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine();
                            cadArray[exclusao].info();
                            Console.ReadKey();
                        }
                        else
                        {
                            if (confirmacao4 == "n" || confirmacao4 == "N")
                            {
                                goto menu;
                            }
                            else
                            {
                                // o cidadao escreveu errado
                                Console.WriteLine("-----------------------------------------------------------------------------");
                                Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                                Console.WriteLine("            (pressione qualquer tecla para tentar de novo)                   ");
                                Console.WriteLine("-----------------------------------------------------------------------------");
                                Console.ReadKey();
                                goto excluirCadastro;   //voltando para o começo da interface de exclusão de cadastro

                            }


                        }


                    }
                    else
                    {
                        if (confirmacao2 == "n" || confirmacao2 == "N")
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Tem certeza de que voê quer exluir os dados de algum cadstro, você não poderá voltar atrás! (s/n)");
                            confirmacao4 = Console.ReadLine();
                            Console.WriteLine();
                            if (confirmacao4 == "s" || confirmacao4 == "S")
                            {
                                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                                Console.Write("Então digite o número do cadastro que deseja exluir: ");
                                exclusao = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                cadArray[exclusao].nome = "";
                                cadArray[exclusao].idade = "";
                                cadArray[exclusao].sexo = "";
                                cadArray[exclusao].cpf = "";
                                cadArray[exclusao].telefone = "";
                                cadArray[exclusao].cidade = "";
                                cadArray[exclusao].estado = "";
                                cadArray[exclusao].statusCadastro = "incompleto";
                                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("                          Seu cadastro foi excluído!");
                                Console.WriteLine("                              Agora ele está assim: ");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                                Console.WriteLine();
                                Console.WriteLine();
                                cadArray[exclusao].info();

                            }
                            else
                            {
                                goto menu;
                            }
                            goto menu;

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        Console.WriteLine("Agora você será redirecionado ao Menu Inicial, podendo voltar aqui se quiser.");
                        Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                  (aperte qualquer tecla para continuar)");
                        Console.ReadKey();
                        goto menu;
                    }
                    goto menu;
                    break;
                case "5":
                    //-------------SAIR---------------------
                    //arranjar um jeito de sair da estrutura switch case
                    // e finalizar então o codigo com um aviso
                    // de que os cadastros não serão salvos
                    Console.Clear(); //limpando a interface para melhor visualização

                    //aqui o usuário é redirecionado para fora da estrutura switch case
                    //lá ele terá a opção de sair do código de vez ou de voltar para o menu inicial
                    goto saidaDoCodigo;

                    break;
                default:
                    //-----------------NUMERO NAO EXISTE-----------------
                    //informar que a opção não existe e fazer ele
                    // retornar ao comeco da estrutura switch case (menu)

                    //explicando para o úsuario o que aconteceu!

                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine("Eita... Parece que a opção que você escolheu não existe...");
                    Console.WriteLine("Mas fique despreocupado, te redicionaremos para a Interface do Menu Inicial.");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine("...(pressione qualquer tecla para continuar)");
                    Console.ReadKey();
                    goto menu; //voltando para o menu inicial
                    break;
            }
        saidaDoCodigo:
            Console.Clear(); //limpando a tela para uma melhor visualização da interface atual
            Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
            Console.WriteLine("                   Você tem certeza que quer sair do programa? (s/n)");
            Console.WriteLine("                    ->(todo o progresso de cadastros será perdido)<-");
            Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
            string certeza = Console.ReadLine();
            if (certeza == "s" || certeza == "S")
            {
                Console.Clear(); //limpando a tela para os agradecimentos finais
                Console.WriteLine("                 ------------- Você saiu do Sistema de Cadastros! -------------");
                Console.WriteLine();
                Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                Console.WriteLine();
                Console.WriteLine("                 Muito obrigado por usar o nosso código, apreciamos o tempo dedicado!");
                Console.WriteLine("                            Seja muito bem vindo a usá-lo novamente!!");
                Console.WriteLine();
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine();
                Console.WriteLine("                         Nicolas Barbosa Tomaselli Pita");
                Console.WriteLine("                         Gabrielly Regis");
                Console.WriteLine("                         Bruna ");
                Console.WriteLine("                         Nycolas Aguiar");
                Console.WriteLine("                         Paulo Borges");
                Console.WriteLine();
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine();
                Console.WriteLine("                             .............Agradecem!!!.............");
                Console.WriteLine();
                Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                Console.WriteLine();
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine("...(aperte qualquer tecla para continuar, e sair do código)");
                Console.ReadKey();

            }
            else
            {
                if (certeza == "n" || certeza == "N")
                {
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine("                Que bom que pretende usar nosso Sistema de Cadastros por mais tempo!");
                    Console.WriteLine("                     Você será redirecionado para a Interface Inicial (Menu).");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine("|+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+|");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                      (pressione qualquer tecla para continuar)");
                    Console.ReadKey();
                    goto menu; //voltando a interface inicial (Menu)
                }
                else
                {
                    // o cidadao escreveu errado
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("Por favor escreva no formato s/n, onde 's' significa sim e 'n' significa não!");
                    Console.WriteLine("            (pressione qualquer tecla para tentar de novo)");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.ReadKey();
                    goto saidaDoCodigo;
                }
            }




        }
    }
}

//definindo a struct cadastro
//definir o cadastro como uma struct é uma ótima forma de automatizar todos os processos
//que envolvem o uso de qualquer informação relacionada ao cadastro
struct TipoCadastro
{

    //cada cadastro armazenará as seguintes informações, e terão as segintes limitações:
    public int indice; //este é mais uma caracteristica criada para faciitar a busca por cadastros
    public string nome; //apenas letras
    public string idade; //apenas números
    public string sexo; //"apenas M ou F"
    public string cpf; //deve ter 11 digitos, mas com validaçao do digito verificador
    public string telefone; // modelo (12) 12345-1234
    public string cidade; //apenas letras
    public string estado; // apenas duas letras

    //OBSERVAÇÃO essa string foi criada para resolvermos um problema com a escolha do preenchimento do cadastro de menor ìndice
    public string statusCadastro; //só pode aceitar a palavra "concluido" e "inconcluido"

    //aqui nós estamos definindo uma função que nós dará todos os dados relacionados ao cadastro
    //essa função será super útil pois é muita prática de ser usada e vai nos economizará centenas de caracteres
    public void info()
    {
        //aqui está contido os dados de um cadastro, estando formatado e tudo mais
        Console.WriteLine("--------------------------");
        Console.WriteLine("Cadastro de Número: {0}", this.indice);
        Console.WriteLine("Status do Cadastro: {0}", this.statusCadastro);
        Console.WriteLine("| Nome: {0}", this.nome);
        Console.WriteLine("| Idade: {0}", this.idade);
        Console.WriteLine("| Sexo: {0}", this.sexo);
        Console.WriteLine("| Cpf: {0}", this.cpf);
        Console.WriteLine("| Telefone: {0}", this.telefone);
        Console.WriteLine("| Cidade: {0}", this.cidade);
        Console.WriteLine("| Estado: {0}", this.estado);
        Console.WriteLine("--------------------------");
    }
}
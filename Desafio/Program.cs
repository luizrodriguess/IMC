using System;
using System.Globalization;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "", sexo = "", opcao = "";
            float imc = 0, peso = 0, altura = 0;
            int idade = 0;
            string[] categoria = { " " };
            string[] classificacaoImc = { " " };
            string[] riscos = { " " };
            string[] recomendacaoInicial = { " " };



            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu sexo");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite a sua idade");
            idade = int.Parse(Console.ReadLine());
            while (idade <= 0)//Verificação de idade, caso alguem digite uma idade negativa
            {
                Console.WriteLine("Idade invalida, tente novamente");
                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite a sua altura");
            altura = float.Parse(Console.ReadLine());
            while (altura <= 0) //Verificação de altura, caso alguem digite uma altura negativa
            {
                Console.WriteLine("Altura invalida, tente novamente");
                altura = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());
            while (peso <= 0) //Verificação de peso, caso alguem digite um peso negativo ou igual a zero
            {
                Console.WriteLine("Peso invalido, tente novamente");
                peso = float.Parse(Console.ReadLine());
            }






            imc = (peso / (altura * altura));

            //Verificação de categoria
            for (int i = 0; i < categoria.Length; i++)
            {

                if (idade < 12)
                {
                    categoria[i] = "Infantil";
                }
                else if (idade >= 12 && idade <= 20)
                {
                    categoria[i] = "Juvenil";
                }
                else if (idade >= 21 && idade <= 65)
                {
                    categoria[i] = "Adulto";
                }
                else if (idade > 65)
                {
                    categoria[i] = "Idoso";
                }

            }

            //Classificação IMC
            for (int i = 0; i < classificacaoImc.Length; i++)
            {
                if (imc < 20)
                {
                    classificacaoImc[i] = "abaixo de 20";
                }
                else if (imc >= 20 && imc <= 24)
                {
                    classificacaoImc[i] = "entre 20 e 24";
                }
                else if (imc >= 25 && imc <= 29)
                {
                    classificacaoImc[i] = "entre 25 e 29";
                }
                else if (imc >= 30 && imc <= 35)
                {
                    classificacaoImc[i] = "entre 30 e 35";
                }
                else if (imc > 35)
                {
                    classificacaoImc[i] = "acima de 35";
                }
            }

            //Verificação dos riscos e recomendações
            for (int i = 0; i < riscos.Length; i++)
            {
                for (int j = 0; j < recomendacaoInicial.Length; j++)
                {
                    if (imc < 20)
                    {
                        riscos[i] = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso. ";
                        recomendacaoInicial[j] = "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional. ";
                    }
                    else if (imc >= 20 && imc <= 24)
                    {
                        riscos[i] = "Seu peso está ideal para suas referências. ";
                        recomendacaoInicial[j] = "Mantenha uma dieta saudável e faça seus exames periódicos. ";
                    }
                    else if (imc >= 25 && imc <= 29)
                    {
                        riscos[i] = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                        recomendacaoInicial[j] = "Adote um tratamento baseado em dieta balanceada, exercício físico edicação. A ajuda de um profissional pode ser interessante";
                    }
                    else if (imc >= 30 && imc <= 35)
                    {
                        riscos[i] = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                        recomendacaoInicial[j] = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino). ";
                    }
                    else if (imc > 35)
                    {
                        riscos[i] = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
                        recomendacaoInicial[j] = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino). ";
                    }
                }
            }


            Console.WriteLine("DIAGNÓSTICO PRÉVIO\n");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine(String.Format("Categoria: {0} \n", categoria));
            Console.WriteLine(String.Format("IMC Desejável: {0} \n", classificacaoImc));
            Console.WriteLine("Resultado IMC: " + imc.ToString("F2") + "\n");
            Console.WriteLine(String.Format("Riscos: {0}\n", riscos));
            Console.WriteLine(String.Format("Recomendação inicial: {0}\n\n", recomendacaoInicial));
            Console.WriteLine("Deseja fazer outro diagnostico??\n");
            Console.WriteLine("Opção 1 para refazer o diagnostico ou opção 2 para encerrar o programa:\n");

            opcao = Console.ReadLine();
            refazerDiagnostico(nome, sexo, idade, altura, peso, imc, categoria, classificacaoImc, riscos, recomendacaoInicial, opcao);









        }

        //Função que refaz o diagnostico de acordo com a validação que voce escolheu
        public static void refazerDiagnostico(string nome, string sexo, float idade, float altura, float peso, float imc, string[] categoria, string[] classificacaoImc, string[] riscos, string[] recomendacaoInicial, string opcao)
        {
            //Primeira validação
            while (validarEntradas(opcao) == false)
            {
                Console.WriteLine("Opção invalida, tente novamente!");
                opcao = Console.ReadLine();


            }

            while (opcao != "2")
            {


                Console.WriteLine("Digite o seu nome");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o seu sexo");
                sexo = Console.ReadLine();

                Console.WriteLine("Digite a sua idade");
                idade = int.Parse(Console.ReadLine());
                while (idade <= 0) //Verificação de idade, caso alguem digite uma idade negativa
                {
                    Console.WriteLine("Idade invalida, tente novamente");
                    idade = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite a sua altura");
                altura = float.Parse(Console.ReadLine());
                while (altura <= 0)//Verificação de altura, caso alguem digite altura negativa
                {
                    Console.WriteLine("Altura invalida, tente novamente");
                    altura = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite o seu peso");
                peso = float.Parse(Console.ReadLine());
                while (peso <= 0)//Verificação de peso, caso alguem digite um peso negativo ou igual a zero
                {
                    Console.WriteLine("Peso invalido, tente novamente");
                    peso = float.Parse(Console.ReadLine());
                }






                imc = (peso / (altura * altura));

                //Verificação de categoria
                for (int i = 0; i < categoria.Length; i++)
                {

                    if (idade < 12)
                    {
                        categoria[i] = "Infantil";
                    }
                    else if (idade >= 12 && idade <= 20)
                    {
                        categoria[i] = "Juvenil";
                    }
                    else if (idade >= 21 && idade <= 65)
                    {
                        categoria[i] = "Adulto";
                    }
                    else if (idade > 65)
                    {
                        categoria[i] = "Idoso";
                    }

                }

                //Classificação IMC
                for (int i = 0; i < classificacaoImc.Length; i++)
                {
                    if (imc < 20)
                    {
                        classificacaoImc[i] = "abaixo de 20";
                    }
                    else if (imc >= 20 && imc <= 24)
                    {
                        classificacaoImc[i] = "entre 20 e 24";
                    }
                    else if (imc >= 25 && imc <= 29)
                    {
                        classificacaoImc[i] = "entre 25 e 29";
                    }
                    else if (imc >= 30 && imc <= 35)
                    {
                        classificacaoImc[i] = "entre 30 e 35";
                    }
                    else if (imc > 35)
                    {
                        classificacaoImc[i] = "acima de 35";
                    }
                }

                //Verificação dos riscos e recomendações
                for (int i = 0; i < riscos.Length; i++)
                {
                    for (int j = 0; j < recomendacaoInicial.Length; j++)
                    {
                        if (imc < 20)
                        {
                            riscos[i] = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso. ";
                            recomendacaoInicial[j] = "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional. ";
                        }
                        else if (imc >= 20 && imc <= 24)
                        {
                            riscos[i] = "Seu peso está ideal para suas referências. ";
                            recomendacaoInicial[j] = "Mantenha uma dieta saudável e faça seus exames periódicos. ";
                        }
                        else if (imc >= 25 && imc <= 29)
                        {
                            riscos[i] = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                            recomendacaoInicial[j] = "Adote um tratamento baseado em dieta balanceada, exercício físico edicação. A ajuda de um profissional pode ser interessante";
                        }
                        else if (imc >= 30 && imc <= 35)
                        {
                            riscos[i] = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                            recomendacaoInicial[j] = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino). ";
                        }
                        else if (imc > 35)
                        {
                            riscos[i] = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
                            recomendacaoInicial[j] = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino). ";
                        }
                    }
                }


                Console.WriteLine("DIAGNÓSTICO PRÉVIO\n");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Sexo: " + sexo);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Peso: " + peso);
                Console.WriteLine(String.Format("Categoria: {0} \n", categoria));
                Console.WriteLine(String.Format("IMC Desejável: {0} \n", classificacaoImc));
                Console.WriteLine("Resultado IMC: " + imc.ToString("F2") + "\n");
                Console.WriteLine(String.Format("Riscos: {0}\n", riscos));
                Console.WriteLine(String.Format("Recomendação inicial: {0}\n\n", recomendacaoInicial));
                Console.WriteLine("Deseja fazer outro diagnostico??\n");
                Console.WriteLine("Opção 1 para refazer o diagnostico ou opção 2 para encerrar o programa:\n");

                opcao = Console.ReadLine();

                //ultima validação
                while (validarEntradas(opcao) == false)
                {
                    Console.WriteLine("Opção invalida, tente novamente!");
                    opcao = Console.ReadLine();


                }
            }

        }

        //Função que valida as entradas para saber se o programa vai reiniciar ou não
        public static bool validarEntradas(string opcao)
        {
            string[] opcoesValidas = { "1", "2" };
            bool opcaoValida = false;
            foreach (string opco in opcoesValidas)
            {
                if (opco == opcao)
                {
                    opcaoValida = true;
                    break;
                }
            }
            return opcaoValida;
        }
    }
}
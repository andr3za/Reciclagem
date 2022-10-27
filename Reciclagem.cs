using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reciclagem
{
    public class Reciclagem
    {
        bool menu = true;
        public int Acertos { get; set; }


        public void Apresentacao()
        {
            while (menu)
            {
                Console.Clear();

                Console.WriteLine("Olá! Seja-bem vindo!\n");
                Console.WriteLine("Vou te ensinar a separar os resíduos corretamente, para que eles possam ser reciclados. Selecione uma lixeira e aprenda o que deve ser descartado nela.\n");
                Console.WriteLine("1 - Verde");
                Console.WriteLine("2 - Amarela");
                Console.WriteLine("3 - Vermelha");
                Console.WriteLine("4 - Azul");
                Console.WriteLine("5 - Marrom");
                Console.WriteLine("6 - Iniciar Quiz");
                Console.WriteLine("7 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("LIXEIRA VERDE:\nA lixeira verde serve para os resíduos de vidro, como garrafas, copos e quaisquer tipo de embalagens de vidro.\n");
                    Console.WriteLine("Aperte qualquer tecla para continuar\n");
                    Console.ReadKey();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("LIXEIRA AMARELA:\nA lixeira amarela serve para os resíduos de metal, como latas de refrigerante, talheres, ferramentas e quaisquer tipo de embalagens de metal.\n");
                    Console.WriteLine("Aperte qualquer tecla para continuar\n");
                    Console.ReadKey();
                }

                else if (opcao == 3)
                {
                    Console.WriteLine("LIXEIRA VERMELHA:\nA lixeira vermelha serve para os resíduos de plástico, como sacolas, embalagens e garrafas PET, entre outros.\n");
                    Console.WriteLine("Aperte qualquer tecla para continuar\n");
                    Console.ReadKey();
                }

                else if (opcao == 4)
                {
                    Console.WriteLine("LIXEIRA AZUL:\nA lixeira azul serve para os resíduos de papel, como revistas, caixas e embalagens de papel.\n");
                    Console.WriteLine("Aperte qualquer tecla para continuar\n");
                    Console.ReadKey();
                }

                else if (opcao == 5)
                {
                    Console.WriteLine("LIXEIRA MARROM:\nA lixeira marrom serve para os resíduos orgânicos, como restos de comida, cascas de frutas, folhas secas, entre outros.\n");
                    Console.WriteLine("Aperte qualquer tecla para continuar\n");
                    Console.ReadKey();
                }

                else if (opcao == 6)
                {
                    Quiz1();
                }

                else if (opcao == 7)
                {
                    Console.WriteLine("Obrigada pela visita!");
                    menu = false;
                }
            }
        }


        public void Quiz1()
        {
            Console.WriteLine("Muito bem! Agora você já sabe separar os resíduos para uma coleta seletiva. Vamos praticar?\n");
            Console.WriteLine("Aperte 1 para iniciar:\n");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("\nEscolha a lixeira em que o item deve ser descartado adequadamente:\nLembrando que você tem 3 tentativas para acertar.\n");

                string resposta;
                resposta = Perguntas(1);

                if (resposta == "C")
                {
                    goto pergunta2;
                }

                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é lixeira MARROM.\nPasse para a próxima pergunta!\n");
                }
                pergunta2:
                resposta = Perguntas(2);

                if (resposta == "C")
                {
                    goto pergunta3;

                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é lixeira VERMELHA.\nPasse para a próxima pergunta!\n");
                }
                pergunta3:
                resposta = Perguntas(3);

                if (resposta == "C")
                {
                    goto pergunta4;
                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é lixeira AMARELA.\nPasse para a próxima pergunta!\n");
                }
                pergunta4:
                resposta = Perguntas(4);
                if (resposta == "C")
                {
                    goto pergunta5;

                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas. Passe para a próxima pergunta!\n");
                }
                pergunta5:
                resposta = Perguntas(5);
                if (resposta == "C")
                {
                    Console.WriteLine($"Parabéns, você chegou ao final do Quiz e acertou {Acertos} perguntas.\n");
                }
                else
                {
                    Console.WriteLine($"Infelizmente você usou todas as tentativas.\nA resposta correta é lixeira AZUL.\nParabéns, você chegou ao final do quiz e acertou {Acertos} perguntas.\nAté a próxima!");
                }
            }
        }

        public string Perguntas(int opcao)
        {
            int resposta;

            if (opcao == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Resíduo: maçã\n");
                    Console.WriteLine("1 - Verde");
                    Console.WriteLine("2 - Amarela");
                    Console.WriteLine("3 - Vermelha");
                    Console.WriteLine("4 - Azul");
                    Console.WriteLine("5 - Marrom");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 5)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }
            else if (opcao == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Resíduo: garrafa pet\n");
                    Console.WriteLine("1 - Verde");
                    Console.WriteLine("2 - Amarela");
                    Console.WriteLine("3 - Vermelha");
                    Console.WriteLine("4 - Azul");
                    Console.WriteLine("5 - Marrom");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 3)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Resíduo: colher\n");
                    Console.WriteLine("1 - Verde");
                    Console.WriteLine("2 - Amarela");
                    Console.WriteLine("3 - Vermelha");
                    Console.WriteLine("4 - Azul");
                    Console.WriteLine("5 - Marrom");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 2)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Resíduo: caixa de sapato\n");
                    Console.WriteLine("1 - Verde");
                    Console.WriteLine("2 - Amarela");
                    Console.WriteLine("3 - Vermelha");
                    Console.WriteLine("4 - Azul");
                    Console.WriteLine("5 - Marrom");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 4)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Resíduo: vidro de conserva\n");
                    Console.WriteLine("1 - Verde");
                    Console.WriteLine("2 - Amarela");
                    Console.WriteLine("3 - Vermelha");
                    Console.WriteLine("4 - Azul");
                    Console.WriteLine("5 - Marrom");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 1)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";

            }
            return "";
        }



        public void Quiz2()
        {
            Console.WriteLine("Vamos testar seus conhecimentos sobre a história de cada resíduo.\nBoa sorte!\n");
            Console.WriteLine("Aperte 1 para iniciar:\n");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("\nEscolha de qual resíduo se refere as características descritas abaixo:\nLembrando que você tem 3 tentativas para acertar.\n");

                string resposta;
                resposta = Perguntas2(1);

                if (resposta == "C")
                {
                    goto pergunta2;
                }

                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é PAPEL.\nPasse para a próxima pergunta!\n");
                }
                pergunta2:
                resposta = Perguntas2(2);

                if (resposta == "C")
                {
                    goto pergunta3;                    
                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta PLÁSTICO.\nPasse para a próxima pergunta!\n");
                }
                pergunta3:
                resposta = Perguntas2(3);

                if (resposta == "C")
                {
                    goto pergunta4;                    
                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é ORGÂNICO.\nPasse para a próxima pergunta!\n");
                }
                pergunta4:
                resposta = Perguntas2(4);
                if (resposta == "C")
                {
                    goto pergunta5;

                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta VIDRO.\nPasse para a próxima pergunta!\n");
                }
                pergunta5:
                resposta = Perguntas2(5);
                if (resposta == "C")
                {
                    Console.WriteLine($"Parabéns, você chegou ao final do Quiz e acertou {Acertos} perguntas.\n");
                }
                else
                {
                    Console.WriteLine($"Infelizmente você usou todas as tentativas.\nA resposta correta METAL.\nVocê acertou {Acertos} perguntas.\n");
                }                                
                
            }
        }
        public string Perguntas2(int opcao)
        {
            int resposta;
            if (opcao == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("QUEM SOU EU?\nSou fabricado a partir da celulose, uma substância encontrada nas árvores.\n");
                    Console.WriteLine("1 - Metal");
                    Console.WriteLine("2 - Plástico");
                    Console.WriteLine("3 - Papel");
                    Console.WriteLine("4 - Vidro");
                    Console.WriteLine("5 - Orgânicos");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 3)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }
            else if (opcao == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("QUEM SOU EU?\nDemoro aproximadamente 400 anos para me decompor na natureza.\n");
                    Console.WriteLine("1 - Metal");
                    Console.WriteLine("2 - Plástico");
                    Console.WriteLine("3 - Papel");
                    Console.WriteLine("4 - Vidro");
                    Console.WriteLine("5 - Orgânicos");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 2)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("QUEM SOU EU?\nComigo, é possível fazer compostagem ou adubar a horta de sua casa.\n");
                    Console.WriteLine("1 - Metal");
                    Console.WriteLine("2 - Plástico");
                    Console.WriteLine("3 - Papel");
                    Console.WriteLine("4 - Vidro");
                    Console.WriteLine("5 - Orgânicos");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 5)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("QUEM SOU EU?\nSou sensível, se me deixar cair vou quebrar e se você não tomar cuidade, pode ser cortar\n");
                    Console.WriteLine("1 - Metal");
                    Console.WriteLine("2 - Plástico");
                    Console.WriteLine("3 - Papel");
                    Console.WriteLine("4 - Vidro");
                    Console.WriteLine("5 - Orgânicos");
                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 4)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("QUEM SOU EU?\nSou usado para guardar refrigerantes, sucos entre outros, por dentro sou prateado\n");
                    Console.WriteLine("1 - Metal");
                    Console.WriteLine("2 - Plástico");
                    Console.WriteLine("3 - Papel");
                    Console.WriteLine("4 - Vidro");
                    Console.WriteLine("5 - Orgânicos");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 1)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";

            }
            return "";
        }




        public void Quiz3()
        {
            Console.WriteLine("Você sabia que nem todos os materias são recicláveis? Isso porque são compostos por matérias químicas indissolúveis ou quando não podem ser separados.\nAlguns exemplo: fotografias, isopor, espelhos, prego, grampos, pilhas, dentre outros.\n");
            Console.WriteLine("Vamos testar seus conhecimentos?\nBoa Sorte!\n");
            Console.WriteLine("Aperte 1 para iniciar:\n");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("\nInforme se o produto informado abaixo é Reciclável ou Não Reciclável!\nLembrando que você tem 3 tentativas para acertar.\n");

                string resposta;
                resposta = Perguntas3(1);

                if (resposta == "C")
                {
                    goto pergunta2;                    
                }

                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é RECICLÁVEL.\nPasse para a próxima pergunta!\n");
                }
                pergunta2:
                resposta = Perguntas3(2);

                if (resposta == "C")
                {
                    goto pergunta3;                    
                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é NÃO RECICLÁVEL.\nPasse para a próxima pergunta!\n");
                }
                pergunta3:
                resposta = Perguntas3(3);

                if (resposta == "C")
                {
                    goto pergunta4;
                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é NÃO RECICLÁVEL.\nPasse para a próxima pergunta!\n");
                }
                pergunta4:
                resposta = Perguntas3(4);
                if (resposta == "C")
                {
                    goto pergunta5;
                }
                else
                {
                    Console.WriteLine("Infelizmente você usou todas as tentativas.\nA resposta correta é RECICLÁVEL.\nPasse para a próxima pergunta!\n");
                }
                pergunta5:
                resposta = Perguntas3(5);
                if (resposta == "C")
                {
                    Console.WriteLine($"Parabéns, você chegou ao final do Quiz e acertou {Acertos} perguntas.\n");
                }
                else
                {
                    Console.WriteLine($"Infelizmente você usou todas as tentativas.\nA resposta correta é NÃO RECICLÁVEL.\nVocê acertou {Acertos} perguntas.\n");
                }
            }
        }
        public string Perguntas3(int opcao)
        {
            int resposta;
            if (opcao == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Material: Caixa de leite\n");
                    Console.WriteLine("1 - Reciclável");
                    Console.WriteLine("2 - Não Reciclável");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 1)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }
            else if (opcao == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Material: Isopor\n");
                    Console.WriteLine("1 - Reciclável");
                    Console.WriteLine("2 - Não Reciclável");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 2)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Material: Espelho\n");
                    Console.WriteLine("1 - Reciclável");
                    Console.WriteLine("2 - Não Reciclável");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 2)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Material: Tampa de garrafa\n");
                    Console.WriteLine("1 - Reciclável");
                    Console.WriteLine("2 - Não Reciclável");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 1)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }

            else if (opcao == 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Material: Pilha\n");
                    Console.WriteLine("1 - Reciclável");
                    Console.WriteLine("2 - Não Reciclável");

                    resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == 2)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n");
                        Acertos++;

                        return "C";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops, opção errada, tente novamente!\n");
                    }
                }
                return "E";
            }
            return "";
        }
    }
}
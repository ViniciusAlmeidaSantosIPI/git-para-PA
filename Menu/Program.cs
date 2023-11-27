
using System;
using System.Threading;



namespace menu_basico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string resp;

            do
            {
                Console.Clear();
                Console.WriteLine("************************");
                Console.WriteLine("* Menu");
                Console.WriteLine("Ordem alfabética [1]");
                Console.WriteLine("Contador de vogal [2]");
                Console.WriteLine("Codificador ZenitPolar [3]");
                Console.WriteLine("Letreiro [4]");
                Console.WriteLine("Desliza [5]");
                Console.WriteLine("Nomes em Maiusclo [6]");
                Console.WriteLine("Sair [7]");
                Console.WriteLine("************************");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        OrdenarNomes();
                        break;
                    case 2:
                        ContarLetras();
                        break;
                    case 3:
                        ZenitPolar();
                        break;
                    case 4:
                        DeslizerPalavra();
                        break;
                    case 5:
                        DeslizarLetra();
                        break;
                    case 6:
                        Maiusculo();
                        break;
                    case 7:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;
                }

                if (opc != 7)
                {
                    Console.WriteLine("Deseja voltar ao menu principal? s/n");
                    resp = Console.ReadLine().ToLower();
                }
                else
                {
                    resp = "n";
                }
            } while (resp == "s" || resp == "sim");
        }


        static void OrdenarNomes()
        {
            string lista, x, resposta;

            Console.Clear();
            do
            {
                Console.WriteLine("Escreva uma lista de nomes separados por ',' ");
                lista = Console.ReadLine();
                string fraseSemEspacos = lista.Replace(" ", "");
                string[] nome = fraseSemEspacos.Split(',');

                for (int i = 0; i < nome.Length - 1; i++)
                {
                    for (int p = nome.Length - 1; p > 0; p--)
                    {
                        if (nome[p].CompareTo(nome[p - 1]) < 0)
                        {
                            x = nome[p];
                            nome[p] = nome[p - 1];
                            nome[p - 1] = x;
                        }
                    }
                }
                for (int i = 0; i < nome.Length; i++)
                {
                    Console.WriteLine(i + 1 + " -> " + nome[i]);
                    Thread.Sleep(800);
                }

                Console.Write("Quer continuar?: ");
                resposta = Console.ReadLine().ToLower();
            } while (resposta == "s" || resposta == "sim");
        }

        static void ContarLetras()
        {
            string frase, resp;

            int contadorEspacos = 0;
            int contadorVogaisA = 0, contadorVogaisE = 0, contadorVogaisI = 0, contadorVogaisO = 0, contadorVogaisU = 0;

            Console.Clear();
            do
            {
                Console.WriteLine("Digite uma frase: ");
                frase = Console.ReadLine();

                string fraseSemEspacos = frase.Replace(" ", "");


                for (int i = 0; i < frase.Length; i++)
                {

                    char caractere = frase[i];
                    if (char.ToLower(caractere) == 'a' ||
                        char.ToLower(caractere) == 'ã' ||
                        char.ToLower(caractere) == 'á' ||
                        char.ToLower(caractere) == 'à' ||
                        char.ToLower(caractere) == 'â')
                    {
                        contadorVogaisA++;
                    }
                    else if (char.ToLower(caractere) == 'e' ||
                             char.ToLower(caractere) == 'é' ||
                             char.ToLower(caractere) == 'è' ||
                             char.ToLower(caractere) == 'ê')
                    {
                        contadorVogaisE++;
                    }
                    else if (char.ToLower(caractere) == 'i' ||
                             char.ToLower(caractere) == 'í' ||
                             char.ToLower(caractere) == 'ì' ||
                             char.ToLower(caractere) == 'î')
                    {
                        contadorVogaisI++;
                    }
                    else if (char.ToLower(caractere) == 'o' ||
                             char.ToLower(caractere) == 'õ' ||
                             char.ToLower(caractere) == 'ó' ||
                             char.ToLower(caractere) == 'ò' ||
                             char.ToLower(caractere) == 'ô')
                    {
                        contadorVogaisO++;
                    }
                    else if (char.ToLower(caractere) == 'u' ||
                             char.ToLower(caractere) == 'ú' ||
                             char.ToLower(caractere) == 'ù' ||
                             char.ToLower(caractere) == 'û')
                    {
                        contadorVogaisU++;
                    }
                    else if ((char.IsWhiteSpace(caractere)))
                    {
                        contadorEspacos++;
                    }

                }


                Console.WriteLine("A frase que foi digitada tem " + fraseSemEspacos.Length + " caracteres.");
                Console.WriteLine("O total de " + contadorVogaisA++ + " vogais 'a' ou suas variações acentuadas.");
                Console.WriteLine("O total de " + contadorVogaisE++ + " vogais 'e' ou suas variações acentuadas.");
                Console.WriteLine("O total de " + contadorVogaisI++ + " vogais 'i' ou suas variações acentuadas.");
                Console.WriteLine("O total de " + contadorVogaisO++ + " vogais 'o' ou suas variações acentuadas.");
                Console.WriteLine("E o total de " + contadorVogaisU++ + " vogais 'u' ou suas variações acentuadas.");

                Console.Write("\nQuer continuar?: ");
                resp = Console.ReadLine().ToLower();
            } while (resp == "s" || resp == "sim");
        }

        static void ZenitPolar()
        {
            string frase;
            string letra;
            string fraseFinal = "";
            string resp;

            do
            {
                Console.Clear();
                Console.WriteLine("digite uma frase: ");
                frase = Console.ReadLine();
                frase = frase.ToLower();

                for (int i = 0; i < frase.Length; i++)
                {

                    letra = frase.Substring(i, 1).ToLower();

                    switch (letra)
                    {
                        case "p":
                            {
                                fraseFinal += "z";
                                break;
                            }
                        case "o":
                            {
                                fraseFinal += "e";
                                break;
                            }
                        case "l":
                            {
                                fraseFinal += "n";
                                break;
                            }
                        case "a":
                            {
                                fraseFinal += "i";
                                break;
                            }
                        case "r":
                            {
                                fraseFinal += "t";
                                break;
                            }
                        case "z":
                            {
                                fraseFinal += "p";
                                break;
                            }
                        case "e":
                            {
                                fraseFinal += "o";
                                break;
                            }
                        case "n":
                            {
                                fraseFinal += "l";
                                break;
                            }
                        case "i":
                            {
                                fraseFinal += "a";
                                break;
                            }
                        case "t":
                            {
                                fraseFinal += "r";
                                break;
                            }
                        default:
                            {
                                fraseFinal += letra;
                                break;
                            }
                    }
                }
                Console.WriteLine("\nsua frase é " + fraseFinal);

                Console.Write("\nQuer continuar?: ");
                resp = Console.ReadLine().ToLower();
            } while (resp == "s" || resp == "sim");
        }

        static void DeslizerPalavra()
        {
            string resp;
            string frase;
            int tamanho;

            do
            {
                Console.Clear();
                Console.WriteLine("escreva uma frase: ");
                frase = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("precione espaço para parar o programa:");

                tamanho = frase.Length;
                frase = new string(' ', 3 * tamanho) + frase;

                while (!Console.KeyAvailable)
                {
                    Console.SetCursorPosition(11, 10);
                    Console.Write(frase.Substring(0, 3 * tamanho));
                    Thread.Sleep(200);
                    frase = frase.Substring(1) + frase.Substring(0, 1);
                }

                Console.WriteLine("\n\nQuer continuar?");
                resp = Console.ReadLine();
                string respf = resp.Replace(" ", "");
                resp = respf.ToLower();
            } while (resp == "s" || resp == "sim");

        }

        static void DeslizarLetra()
        {
            string resp;
            do
            {
                Console.Clear();
                string frase;
                int x = 7;
                int deslizar2;

                Console.WriteLine("digite uma frase: ");
                frase = Console.ReadLine();
                Console.WriteLine("quanto você quer andar?(ela tem que ser maior que a frase):  ");
                deslizar2 = Convert.ToInt16(Console.ReadLine()) + x;

                for (int i = 0; i < frase.Length; i++)
                {
                    char letra = frase[i];

                    for (int deslizar = deslizar2; deslizar >= x; deslizar--)
                    {
                        Console.SetCursorPosition(deslizar, 10);
                        Console.WriteLine(letra);
                        System.Threading.Thread.Sleep(400);
                        Console.SetCursorPosition(deslizar, 10);
                        if (deslizar > x)
                        {
                            Console.WriteLine(" ");
                        }
                    }
                    x++;
                }
                Console.WriteLine("\nQuer continuar? ");
                resp = Console.ReadLine();
                resp = resp.ToLower();

            } while (resp == "s" || resp == "sim");
        }

        static void Maiusculo()
        {
            string resp;
            do
            {
                Console.Clear();
                Console.WriteLine("Escreva o nome:");
                string nome = Console.ReadLine();
                string[] sepa = nome.Split();
                int f = 0;
                for (int i = 0; i < sepa.Length; i++)

                {
                    string palavra = sepa[i];
                    if (palavra.StartsWith("de", StringComparison.OrdinalIgnoreCase) ||
                        palavra.StartsWith("da", StringComparison.OrdinalIgnoreCase) ||
                        palavra.StartsWith("do", StringComparison.OrdinalIgnoreCase) ||
                        palavra.StartsWith("dos", StringComparison.OrdinalIgnoreCase))
                    {
                        f++;
                    }
                    else if (!string.IsNullOrEmpty(palavra))
                    {
                        sepa[i] = char.ToUpper(palavra[0]) + palavra.Substring(1);
                    }
                }
                string nomeCorrigido = string.Join(" ", sepa);
                Console.WriteLine(nomeCorrigido);
                Console.WriteLine("\nQuer continuar? ");
                resp = Console.ReadLine();
                resp = resp.ToLower();
            } while (resp == "s" || resp == "sim");
        }
    }
}
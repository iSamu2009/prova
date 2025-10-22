using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES23stringhe
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                int scelta, contV = 0, contC = 0, contS = 0;
                string frase, f;
                frase = InputFrase();

                do
                {
                    Console.WriteLine("1. Al contrario");
                    Console.WriteLine("2. Conta vocali, consonanti e spazi");
                    Console.WriteLine("3. Verifica se è una palindroma");
                    Console.WriteLine("4. Fine");
                    do
                    {
                        Console.Write("Fai la tua scelta: ");

                    } while (!int.TryParse(Console.ReadLine(), out scelta));
                    switch (scelta)
                    {
                        case 1:
                            f = Contrario(frase);
                            Console.WriteLine(f);
                            break;
                        case 2:
                            ContaCaratteri(frase, ref contC, ref contV, ref contS);
                            Console.WriteLine("Le vocali sono " + contV.ToString() + ", le consonanti sono " + contC.ToString() + " e gli spazi sono " + contS.ToString());
                            break;
                        case 3:
                            if (Palindroma(frase))
                            {
                                Console.WriteLine("La frase è palindroma");
                            }
                            else
                            {
                                Console.WriteLine("La frase non è palindroma");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Arrivederci!");
                            break;
                        default:
                            Console.WriteLine("Scelta non valida");
                            break;

                    }
                    Console.ReadKey();

                } while (scelta != 4);



            }

            private static string InputFrase()
            {
                string s = "";
                do
                {
                    Console.Write("Inserire una frase o una frase: ");
                    s = Console.ReadLine().Trim().ToUpper(); //Trim() toglie gli spazi iniziali e finali, invece ToUpper() mette tutto maiuscolo
                } while (s.Length < 2);
                return s;
            }

            private static bool Palindroma(string frase)
            {
                bool pal;
                string s = "";
                for (int i = frase.Length - 1; i >= 0; i--)
                {
                    s = s + frase[i];
                }
                if (frase == s)
                {
                    pal = true;
                }
                else
                {
                    pal = false;
                }
                return pal;

            }

            private static void ContaCaratteri(string frase, ref int contC, ref int contV, ref int contS)
            {
                char c;
                for (int i = 0; i < frase.Length; i++)
                {
                    c = frase[i];
                    switch (c)
                    {
                        case 'A':
                            contV++;
                            break;
                        case 'E':
                            contV++;
                            break;
                        case 'I':
                            contV++;
                            break;
                        case 'O':
                            contV++;
                            break;
                        case 'U':
                            contV++;
                            break;
                        case ' ':
                            contS++;
                            break;
                        default:
                            contC++;
                            break;

                    }
                }
            }

            private static string Contrario(string frase)
            {
                string s = "";
                for (int i = frase.Length - 1; i >= 0; i--)
                {
                    s = s + frase[i];
                }
                return s;
            }
        }
    }
    


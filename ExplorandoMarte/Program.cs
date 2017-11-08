using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoMarte
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            do
            {
                //Entrada de dados

                //Coordenada do ponto superior-direito 
                int pontoxSD = 5;
                int pontoySD = 5;

                int pontoxAtual = 0, pontoyAtual = 0;
                char direcaoAtual = 'N';
                string comando = string.Empty;

                Console.Write("Digite sua posição inicial x: ");
                pontoxAtual = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite sua posição inicial y: ");
                pontoyAtual = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite sua posição inicial direção: ");
                direcaoAtual = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.Write("Digite seu comando: ");
                comando = Console.ReadLine().ToUpper();

                RecebeComando(comando, pontoxAtual, pontoyAtual, direcaoAtual);

                Console.Write("\nDigite exit para sair, ou aperte enter para adicionar uma nova sonda.");
                command = Console.ReadLine().ToLower();
            } while (command != "exit");
            
        
        }


        private static void RecebeComando(string comando, int pontoxAtual, int pontoyAtual, char direcaoAtual)
        {
            char comandoAtual = 'A';
            for (int i = 0; i < comando.Length; i++)
            {
                comandoAtual = comando[i];

                char sinal = '+';

                if (direcaoAtual == 'N')
                {
                    if (comandoAtual == 'L')
                    {
                        sinal = '-';
                        direcaoAtual = 'W';
                    }
                    else if (comandoAtual == 'R')
                    {
                        sinal = '+';
                        direcaoAtual = 'E';
                    }
                    else if (comandoAtual == 'M')
                    {
                        pontoyAtual += 1;
                    }
                }
                else if (direcaoAtual == 'S')
                {
                    if (comandoAtual == 'L')
                    {
                        sinal = '+';
                        direcaoAtual = 'E';
                    }
                    else if (comandoAtual == 'R')
                    {
                        sinal = '-';
                        direcaoAtual = 'W';
                    }
                    else if (comandoAtual == 'M')
                    {
                        pontoyAtual -= 1;
                    }
                }
                else if (direcaoAtual == 'E')
                {
                    if (comandoAtual == 'L')
                    {
                        sinal = '+';
                        direcaoAtual = 'N';
                    }
                    else if (comandoAtual == 'R')
                    {
                        sinal = '-';
                        direcaoAtual = 'S';
                    }
                    else if (comandoAtual == 'M')
                    {
                        pontoxAtual += 1;
                    }
                }
                else if (direcaoAtual == 'W')
                {
                    if (comandoAtual == 'L')
                    {
                        sinal = '-';
                        direcaoAtual = 'S';
                    }
                    else if (comandoAtual == 'R')
                    {
                        sinal = '+';
                        direcaoAtual = 'N';
                    }
                    else if (comandoAtual == 'M')
                    {
                        pontoxAtual -= 1;
                    }
                }

            }
            
            string coordenada = '(' + pontoxAtual.ToString() + ' ' + pontoyAtual.ToString() + ' '+ direcaoAtual.ToString() + ')';

            Console.Write(coordenada);
        }
    }
}

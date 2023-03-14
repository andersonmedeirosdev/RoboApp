using System.Xml;

namespace RoboApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            char direcao = 'N';
            string coordenadas;

            Console.WriteLine("Digite a posição inicial do robô.");
            Console.WriteLine("A posição inicial do robô são 2 dígitos e uma letra indicando a direção N, S, L, O.");

            Console.Write("Posição 1 inicial do robô: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Posição 2 inicial do robô: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Direção do robô: ");
            direcao = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Para virar o robô para a esquerda digite 'E' para direita 'D' e para movimentar 'M'");
            Console.WriteLine("Digite os comandos do robô.");
            coordenadas = Console.ReadLine();

            char[] coordenadas1 = coordenadas.ToCharArray();

            for (int i = 0; i < Convert.ToInt32(coordenadas1.Length); i++)
            {
                char C = coordenadas1[i];

                if (C == 'E')
                {
                    switch (direcao)
                    {
                        case 'N':
                            direcao = 'O';
                            break;
                        case 'S':
                            direcao = 'L';
                            break;
                        case 'L':
                            direcao = 'N';
                            break;
                        case 'O':
                            direcao = 'S';
                            break;
                    }
                }
                else if (C == 'D')
                {
                    switch (direcao)
                    {
                        case 'N':
                            direcao = 'L';
                            break;
                        case 'S':
                            direcao = 'O';
                            break;
                        case 'L':
                            direcao = 'S';
                            break;
                        case 'O':
                            direcao = 'N';
                            break;
                    }
                }
                else if (C == 'M')
                {
                    switch (direcao)
                    {
                        case 'N':
                            y = y + 1;
                            break;
                        case 'S':
                            y = y - 1;
                            break;
                        case 'L':
                            x = x + 1;
                            break;
                        case 'O':
                            x = x - 1;
                            break;
                    }
                }

            }

            //Robô 2.

            int x2 = 0, y2 = 0;
            char direcao2 = 'N';
            string coordenadas2;

            Console.WriteLine("Digite a posição inicial do robô 2.");

            Console.Write("Posição 1 inicial do robô 2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Posição 2 inicial do robô: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Direção do robô 2: ");
            direcao2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Para virar o robô para a esquerda digite 'E' para direita 'D' e para movimentar 'M'");
            Console.WriteLine("Digite os comandos do robô.");
            coordenadas2 = Console.ReadLine();

            char[] coordenadasDois = coordenadas2.ToCharArray();

            for (int i = 0; i < Convert.ToInt32(coordenadasDois.Length); i++)
            {
                char C2 = coordenadasDois[i];

                if (C2 == 'E')
                {
                    switch (direcao2)
                    {
                        case 'N':
                            direcao2 = 'O';
                            break;
                        case 'S':
                            direcao2 = 'L';
                            break;
                        case 'L':
                            direcao2 = 'N';
                            break;
                        case 'O':
                            direcao2 = 'S';
                            break;
                    }
                }
                else if (C2 == 'D')
                {
                    switch (direcao2)
                    {
                        case 'N':
                            direcao2 = 'L';
                            break;
                        case 'S':
                            direcao2 = 'O';
                            break;
                        case 'L':
                            direcao2 = 'S';
                            break;
                        case 'O':
                            direcao2 = 'N';
                            break;
                    }
                }
                else if (C2 == 'M')
                {
                    switch (direcao2)
                    {
                        case 'N':
                            y2 = y2 + 1;
                            break;
                        case 'S':
                            y2 = y2 - 1;
                            break;
                        case 'L':
                            x2 = x2 + 1;
                            break;
                        case 'O':
                            x2 = x2 - 1;
                            break;
                    }
                }

            }

            Console.WriteLine("A posição final do robô é 1 " + x + "  " + y + " " + direcao);
            Console.WriteLine("A posição final do robô é 2 " + x2 + "  " + y2 + " " + direcao2);
            Console.ReadLine();
        }
    }
}
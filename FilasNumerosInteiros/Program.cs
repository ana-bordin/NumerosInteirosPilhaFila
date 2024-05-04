namespace FilasNumerosInteiros
{
    internal class Program
    {
        static FilaInteiro fila_1 = new FilaInteiro();
        static FilaInteiro fila_2 = new FilaInteiro();
        static FilaInteiro filaCopia = new FilaInteiro();

        static void Menu()
        {
            Console.WriteLine("Digite a opção desejada:\n" +
                              "1. Povoar as filas;\n" +
                              "2. Testar se as duas filas são iguais;\n" +
                              "3. Mostrar o maior número, o menor e a média aritimética entre eles;\n" +
                              "4. Transferir para uma fila auxiliar;\n" +
                              "5. Mostrar a quantidade e quais números impares de cada fila;\n" +
                              "6. Mostrar a quantidade e quais números pares de cada fila;\n" +
                              "0. Sair\n");
            EscolhaMenu(int.Parse(Console.ReadLine()));
        }
        static void EscolhaMenu(int op)
        {
            switch (op)
            {
                case 1:
                    PovoarFila(fila_1, 1);
                    fila_1.Print();
                    PovoarFila(fila_2, 2);
                    fila_2.Print();
                    break;
                case 2:
                    CompararFila();
                    break;
                case 3:
                    MostrarMedia(fila_1, 1);
                    MostrarMedia(fila_2, 2);
                    break;
                case 4:
                    CopiarFila();
                    filaCopia.Print();
                    break;
                case 5:
                    fila_1.OddNumbers(1);
                    fila_2.OddNumbers(2);
                    break;
                case 6:
                    fila_1.EvenNumbers(1);
                    fila_2.EvenNumbers(2);
                    break;
                default:
                    break;
            }
        }
        static void PovoarFila(FilaInteiro filaInteiro, int numFila)
        {
            int contador = 0;
            int parar = 0;
            do
            {
                filaInteiro.Push(new NumeroInteiro(new Random().Next(1, 100)));
                contador++;
                Console.WriteLine($"Você adicionou o {contador}º número;");
                Console.WriteLine($"Digite 0 para parar de povoar a {numFila}ª fila:");
                parar = int.Parse(Console.ReadLine());
            } while (parar != 0);
        }
        static void CompararFila()
        {
            int qtdElementos1 = fila_1.RunOver();
            int qtdElementos2 = fila_2.RunOver();

            if (qtdElementos1 == qtdElementos2)
                Console.WriteLine($"As filas são iguais e possuem {qtdElementos1} elementos;");
            else if (qtdElementos1 > qtdElementos2)
                Console.WriteLine($"A fila 1 é maior e possui {qtdElementos1} elementos;");
            else
                Console.WriteLine($"A fila 2 é maior e possui {qtdElementos2} elementos;");
        }
        static float CalcularMedia(int[] vetor)
        {
            return ((vetor[0] + vetor[1]) / 2);
        }
        static void MostrarMedia(FilaInteiro fila, int numFila)
        {
            int[] vetor = fila.BiggerAndSmaller();
            float media = CalcularMedia(vetor);
            Console.WriteLine($"Fila {numFila}:\n" +
                              $"O maior número é {vetor[0]}\n" +
                              $"O menor número é {vetor[1]}\n" +
                              $"A média é {media}");
        }
        static void CopiarFila()
        {
            Console.WriteLine("Escolha a fila:");
            int fila = int.Parse(Console.ReadLine());
            if (fila == 1)
            {
                fila_1.CopyStack(filaCopia);
            }
            else if (fila == 2)
            {
                fila_2.CopyStack(filaCopia);
            }
            else
                Console.WriteLine("Digite um número valido");
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(">>>Comparação de Filas<<<");
                Menu();
            } while (true);
        }
    }
}

namespace PilhasNumerosInteiros
{
    internal class Program
    {
        static PilhaDeInteiros pilha_1 = new PilhaDeInteiros();
        static PilhaDeInteiros pilha_2 = new PilhaDeInteiros();
        static PilhaDeInteiros pilhaCopia = new PilhaDeInteiros();

        static void Menu()
        {
            Console.WriteLine("Digite a opção desejada:\n" +
                              "1. Povoar as pilhas;\n" +
                              "2. Testar se as duas pilhas são iguais;\n" +
                              "3. Mostrar o maior número, o menor e a média aritimética entre eles;\n" +
                              "4. Transferir para uma pilha auxiliar;\n" +
                              "5. Mostrar a quantidade e quais números impares de cada pilha;\n" +
                              "6. Mostrar a quantidade e quais números pares de cada pilha;\n" +
                              "0. Sair\n");
            EscolhaMenu(int.Parse(Console.ReadLine()));
        }
        static void EscolhaMenu(int op)
        {
            switch (op)
            {
                case 1:
                    PovoarPilha(pilha_1, 1);
                    pilha_1.Print();
                    PovoarPilha(pilha_2, 2);
                    pilha_2.Print();
                    break;
                case 2:
                    CompararPilhas();
                    break;
                case 3:
                    MostrarMedia(pilha_1, 1);
                    MostrarMedia(pilha_2, 2);
                    break;
                case 4:
                    CopiarPilha();
                    pilhaCopia.Print();
                    break;
                case 5:
                    pilha_1.OddNumbers(1);
                    pilha_2.OddNumbers(2);
                    break;
                case 6:
                    pilha_1.EvenNumbers(1);
                    pilha_2.EvenNumbers(2);
                    break;
                default:
                    break;
            }
        }
        static void PovoarPilha(PilhaDeInteiros pilhaDeInteiros, int numPilha)
        {
            int parar = 0;
            do
            {
                NumeroInteiro num = new NumeroInteiro(new Random().Next(1, 100));
                pilhaDeInteiros.Push(num);
                Console.WriteLine($"Você adicionou o número {num};");
                Console.WriteLine($"Digite 0 para parar de povoar a {numPilha}ª pilha:");
                parar = int.Parse(Console.ReadLine());
            } while (parar != 0);
        }
        static void CompararPilhas()
        {
            int qtdElementos1 = pilha_1.RunOver();
            int qtdElementos2 = pilha_2.RunOver();

            if (qtdElementos1 == qtdElementos2)
                Console.WriteLine($"As pilhas são iguais e possuem {qtdElementos1} elementos;");
            else if (qtdElementos1 > qtdElementos2)
                Console.WriteLine($"A pilha 1 é maior e possui {qtdElementos1} elementos;");
            else
                Console.WriteLine($"A pilha 2 é maior e possui {qtdElementos2} elementos;");
        }
        static float CalcularMedia(int[] vetor)
        {
            return ((vetor[0] + vetor[1]) / 2);
        }
        static void MostrarMedia(PilhaDeInteiros pilha, int numPilha)
        {
            int[] vetor = pilha.BiggerAndSmaller();
            float media = CalcularMedia(vetor);
            Console.WriteLine($"Pilha {numPilha}:\n" +
                              $"O maior número é {vetor[0]}\n" +
                              $"O menor número é {vetor[1]}\n" +
                              $"A média é {media}");
        }
        static void CopiarPilha()
        {
            Console.WriteLine("Escolha a pilha:");
            int pilha = int.Parse(Console.ReadLine());
            if (pilha == 1)
            {
                pilha_1.CopyStack(pilhaCopia);
            }
            else if (pilha == 2)
            {
                pilha_2.CopyStack(pilhaCopia);
            }
            else
                Console.WriteLine("Digite um número valido");
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(">>>Comparação de Pilhas<<<");
                Menu();
            } while (true);



        }
    }
}

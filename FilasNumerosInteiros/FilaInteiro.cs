namespace FilasNumerosInteiros
{
    internal class FilaInteiro
    {
        NumeroInteiro Head;
        NumeroInteiro Tail;
        public FilaInteiro()
        {
            Head = null;
            Tail = null;
        }
        bool IsEmpty()
        {
            return Head == null && Tail == null;
        }
        string MessageEmpty()
        {
            return "Fila Vazia!";
        }
        public void Push(NumeroInteiro aux)
        {
            if (IsEmpty())
                Head = Tail = aux;
            else
            {
                Tail.SetNext(aux);
                Tail = aux;
            }
        }
        public void Print()
        {
            int qtdElementos = 0;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
            }
        }
        public int RunOver()
        {
            int qtdElementos = 0;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Head;
                do
                {
                    aux = aux.GetNext();
                    qtdElementos++;
                } while (aux != Tail.GetNext());
            }
            return qtdElementos;
        }
        public int[] BiggerAndSmaller()
        {
            int[] vetor = new int[2];
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Head;
                int maior = aux.GetNumber();
                int menor = aux.GetNumber();
                do
                {  
                    aux = aux.GetNext();
                    if (menor > aux.GetNumber())
                        menor = aux.GetNumber();
                    if (maior < aux.GetNumber())
                        maior = aux.GetNumber();                                
                } while (aux != Tail);
                vetor[0] = maior;
                vetor[1] = menor;
            }
            return vetor;
        }
        public void CopyStack(FilaInteiro filaCopia)
        {
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Head;
                while (aux != Tail.GetNext())
                {
                    filaCopia.Push(new NumeroInteiro(aux.GetNumber()));
                    aux = aux.GetNext();
                }
            }
        }
        public void EvenNumbers(int n)
        {
            int numPar = 0;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Head;
                do
                {
                    if (aux.GetNumber() % 2 == 0)
                    {
                        Console.WriteLine(aux.ToString());
                        numPar++;
                    }
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
            }
            Console.WriteLine($"Na fila {n} possui: {numPar}");
        }
        public void OddNumbers(int n)
        {
            int numImpar = 0;

            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Head;
                do
                {
                    if (aux.GetNumber() % 2 != 0)
                    {
                        Console.WriteLine(aux.ToString());
                        numImpar++;
                    }
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
                Console.WriteLine($"Na fila {n} possui: {numImpar}");
            }
        }
    }
}

using System.Runtime.Intrinsics.X86;

namespace PilhasNumerosInteiros
{
    internal class PilhaDeInteiros
    {
        NumeroInteiro Topo;
        public PilhaDeInteiros()
        {
            Topo = null;
        }
        bool IsEmpty()
        {
            return Topo == null;
        }
        string MessageEmpty()
        {
            return "Pilha Vazia!";
        }
        public void Push(NumeroInteiro aux)
        {
            if (IsEmpty())
                Topo = aux;
            else
            {
                aux.SetPrevious(Topo);
                Topo = aux;
            }
        }
        public void Pop()
        {
            if (IsEmpty())
                MessageEmpty();
            else
                Topo = Topo.GetPrevious();
        }
        public void Print()
        {
            NumeroInteiro aux = Topo;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetPrevious();
                } while (aux != null);
            }
        }
        public int RunOver()
        {
            int qtdElementos = 0;
            NumeroInteiro aux = Topo;
            if (IsEmpty())
                MessageEmpty();
            else
            {
                do
                {
                    aux = aux.GetPrevious();
                    qtdElementos++;
                } while (aux != null);
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
                NumeroInteiro aux = Topo;
                int maior = aux.GetNumber();
                int menor = aux.GetNumber();
                while (aux.GetPrevious() != null)
                {
                    aux = aux.GetPrevious();
                    if (menor > aux.GetNumber())
                        menor = aux.GetNumber();
                    if (maior < aux.GetNumber())
                        maior = aux.GetNumber();
                }
                vetor[0] = maior;
                vetor[1] = menor;
            }
            return vetor;
        }
        public void CopyStack(PilhaDeInteiros pilhaCopia)
        {
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Topo;
                while (aux != null)
                {
                    pilhaCopia.Push(new NumeroInteiro(aux.GetNumber()));
                    aux = aux.GetPrevious();
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
                NumeroInteiro aux = Topo;
                do
                {
                    if (aux.GetNumber() % 2 == 0)
                    {
                        Console.WriteLine(aux.ToString());
                        numPar++;
                    }
                    aux = aux.GetPrevious();
                } while (aux != null);
            }
            Console.WriteLine($"Na pilha {n} possui: {numPar}");
        }
        public void OddNumbers(int n)
        {
            int numImpar = 0;

            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroInteiro aux = Topo;
                do
                {
                    if (aux.GetNumber() % 2 != 0)
                    {
                        Console.WriteLine(aux.ToString());
                        numImpar++;
                    }
                    aux = aux.GetPrevious();
                } while (aux != null);
                Console.WriteLine($"Na pilha {n} possui: {numImpar}");
            }
        }

    }
}

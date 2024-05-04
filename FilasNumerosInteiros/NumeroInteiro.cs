namespace FilasNumerosInteiros
{
    internal class NumeroInteiro
    {
        int Numero;
        NumeroInteiro Proximo;

        public NumeroInteiro(int numero)
        {
            Numero = numero;
            Proximo = null;
        }
        public void SetNext(NumeroInteiro numeroProximo)
        {
            this.Proximo = numeroProximo;
        }
        public NumeroInteiro GetNext()
        {
            return Proximo;
        }
        public override string ToString()
        {
            return $"{Numero}";
        }
        public int GetNumber()
        {
            return Numero;
        }
    }
}
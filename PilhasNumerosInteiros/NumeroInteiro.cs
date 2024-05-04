namespace PilhasNumerosInteiros
{
    internal class NumeroInteiro
    {
        int Numero;
        NumeroInteiro Anterior;

        public NumeroInteiro(int numero)
        {
            Numero = numero;
            Anterior = null;
        }
        public void SetPrevious(NumeroInteiro numeroAnterior)
        {
            this.Anterior = numeroAnterior;
        }
        public NumeroInteiro GetPrevious()
        {
            return Anterior;
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

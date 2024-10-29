namespace EsercitazioneEredita
{
    public class AddNumberOperation : Operation
    {
        public readonly double NumberToAdd;

        public AddNumberOperation(double numberToAdd)
        {
            NumberToAdd = numberToAdd;
        }

        public override double Apply(double n)
        {
            return n + NumberToAdd;
        }
    }
}

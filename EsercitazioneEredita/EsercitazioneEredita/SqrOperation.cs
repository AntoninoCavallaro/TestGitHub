using System;

namespace EsercitazioneEredita
{
    public class SqrOperation : Operation
    {
        public override double Apply(double n)
        {
            return Math.Sqrt(n);
        }
    }
}

using System;

namespace EsercitazioneEredita
{
    public class PowOperation : Operation
    {
        public readonly double Exponent;

        public PowOperation(double exponent)
        {
            Exponent = exponent;
        }

        public override double Apply(double n)
        {
            return Math.Pow(n, Exponent);
        }
    }
}

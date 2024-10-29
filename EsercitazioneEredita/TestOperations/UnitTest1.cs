namespace EsercitazioneEredita;
using FluentAssertions;


    public class OperationTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(-3)]
        public void Apply_AllOperations_ShouldReturnExpectedResults(double input)
        {
            // Arrange: Creiamo un array di tutte le operazioni
            Operation[] operations = new Operation[]
            {
                new AddFiveOperation(),    // Aggiunge 5
                new AddPiOperation(),      // Aggiunge Pi
                new CubeOperation(),       // Eleva al cubo
                new SqrOperation(),        // Calcola la radice quadrata
                new PowOperation(2)        // Eleva a potenza 2 (quadrato)
            };

            //// Expected results per ciascuna operazione
            //double[] expectedResults = new double[]
            //{
            //    input + 5,                     // Risultato di AddFiveOperation
            //    input + Math.PI,               // Risultato di AddPiOperation
            //    Math.Pow(input, 3),            // Risultato di CubeOperation
            //    Math.Sqrt(input >= 0 ? input : 0),  // Risultato di SqrOperation (radice di input non negativo)
            //    Math.Pow(input, 2)             // Risultato di PowOperation (input ^ 2)
            //};


        }
    }



//public class OperationTests
//{
//    // Test per AddFiveOperation
//    [Theory]
//    [InlineData(10, 15)]
//    [InlineData(0, 5)]
//    [InlineData(-5, 0)]
//    public void AddFiveOperation_Should_AddFive(double input, double expected)
//    {
//        var operation = new AddFiveOperation();
//        var result = operation.Apply(input);

//        result.Should().Be(expected);
//    }

//    // Test per AddPiOperation
//    [Theory]
//    [InlineData(0, Math.PI)]
//    [InlineData(1, 1 + Math.PI)]
//    [InlineData(-Math.PI, 0)]
//    public void AddPiOperation_Should_AddPi(double input, double expected)
//    {
//        var operation = new AddPiOperation();
//        var result = operation.Apply(input);

//        result.Should().BeApproximately(expected, 1e-10);
//    }

//    // Test per CubeOperation
//    [Theory]
//    [InlineData(2, 8)]
//    [InlineData(-3, -27)]
//    [InlineData(0, 0)]
//    public void CubeOperation_Should_CubeTheNumber(double input, double expected)
//    {
//        var operation = new CubeOperation();
//        var result = operation.Apply(input);

//        result.Should().Be(expected);
//    }

//    // Test per PowOperation con esponente generico
//    [Theory]
//    [InlineData(2, 2, 4)]
//    [InlineData(3, 3, 27)]
//    [InlineData(5, 0, 1)]
//    public void PowOperation_Should_RaiseToPower(double input, double exponent, double expected)
//    {
//        var operation = new PowOperation(exponent);
//        var result = operation.Apply(input);

//        result.Should().Be(expected);
//    }

//    // Test per SqrOperation (Radice quadrata)
//    [Theory]
//    [InlineData(16, 4)]
//    [InlineData(25, 5)]
//    [InlineData(0, 0)]
//    public void SqrOperation_Should_CalculateSquareRoot(double input, double expected)
//    {
//        var operation = new SqrOperation();
//        var result = operation.Apply(input);

//        result.Should().Be(expected);
//    }

//    // Test per AddNumberOperation
//    [Theory]
//    [InlineData(10, 5, 15)]
//    [InlineData(0, 7, 7)]
//    [InlineData(-10, 3, -7)]
//    public void AddNumberOperation_Should_AddGivenNumber(double input, double numberToAdd, double expected)
//    {
//        var operation = new AddNumberOperation(numberToAdd);
//        var result = operation.Apply(input);

//        result.Should().Be(expected);
//    }
//}

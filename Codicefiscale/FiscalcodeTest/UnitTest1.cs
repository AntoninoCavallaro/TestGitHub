using FluentAssertions;
using global::Codicefiscale;
using System;
using Xunit;

namespace FiscalcodeTest
{
    public class PersonUtilsTests
    {
        [Theory]
        [InlineData("randazzo", "Anthony", "milano", "1975-04-13", Sex.Male, $"RNDNHN75D13F205B")]
        [InlineData("randazzo", "Mario", "roma", "1950-08-06", Sex.Male, $"RNDMRA50M06H501K")]
        [InlineData("Milici", "Maria", "torino", "1997-11-15", Sex.Female, $"MLCMRA97S55L219U")]
        [InlineData("Lotti", "Paolo", "catania", "1979-04-17", Sex.Male, $"LTTPLA79D17C351R")]

        public void GetFiscalCode_ShouldReturnCorrectCode(string surname, string name, string placeOfBirth, string dateOfBirth, Sex sex, string expectedCode)
        {
            var person = new Person(name, surname, placeOfBirth, DateOnly.Parse(dateOfBirth), sex);
            string result = PersonUtils.GetCompleteFiscalCode(person);

            result.Should().Be(expectedCode);
        }
    }
}


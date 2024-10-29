using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Codicefiscale
{
    public class PersonUtils
    {
        // Codice per i 15 caratteri
        public static string GetFiscalCode(Person person)
        {
            string surnameCode = ExtractCodeSurname(person.Surname);
            string nameCode = ExtractCodeName(person.Name);

            string yearCode = person.DateOfBirth.ToString("yy");
            string monthCode = GetMonth(person.DateOfBirth.Month);
            string dayCode = GetDay(person.DateOfBirth.Day, person.Sex);

            string placeOfBirth = CadastalCode.GetCatastalCode(person.PlaceOfBirth);
            return $"{surnameCode}{nameCode}{yearCode}{monthCode}{dayCode}{placeOfBirth}".ToUpper();
        }

        // Codice per il Cognome
        private static string ExtractCodeSurname(string value)
        {
            string consonants = string.Empty;
            string vowels = string.Empty;

            foreach (char c in value)
            {
                if ("AEIOUaeiou".IndexOf(c) == -1)
                {
                    consonants += c;
                }
                else 
                {
                    vowels += c;
                }
            }
            string combined = consonants.Length >= 3 ? consonants.Substring(0, 3) : (consonants + vowels).PadRight(3, 'X');
            return combined;
        }

        // Codice per il Nome
        private static string ExtractCodeName(string value)
        {
            string consonants = string.Empty;
            string vowels = string.Empty;

            foreach (char c in value)
            {
                if ("AEIOUaeiou".IndexOf(c) == -1) 
                {
                    consonants += c;
                }
                else 
                {
                    vowels += c;
                }
            }
            if (consonants.Length >= 4)
                return $"{consonants[0]}{consonants[2]}{consonants[3]}";
            else
            {
                string combined = consonants + vowels;
                return combined.Length >= 3 ? combined.Substring(0, 3) : combined.PadRight(3, 'X');
            }
        }

        // Codice per il Mese
        private static string GetMonth(int month)
        {
            return "ABCDEHLMPRST"[month - 1].ToString();
        }

        // Codice per il Giorno
        private static string GetDay(int day, Sex sex)
        {
            return (sex == Sex.Female ? day + 40 : day).ToString("D2");
        }

        // Codice fiscale completo di carattere di controllo
        public static string GetCompleteFiscalCode(Person person)
        {
            string partialFiscalCode = GetFiscalCode(person);
            char controlCharacter = ControlCharacter.CalculateControlCharacter(partialFiscalCode);

            return partialFiscalCode + controlCharacter;
        }

    }
}

public enum Sex
{
    Male,
    Female
}

public class Person
{
    public string Surname { get; }
    public string Name { get; }
    public string PlaceOfBirth { get; }
    public DateOnly DateOfBirth { get; }
    public Sex Sex { get; }

    public Person(string name, string surname, string placeOfBirth, DateOnly dateOfBirth, Sex sex)
    {
        const int SurnameMinLength = 2;
        const int NameMinLength = 2;
        const int PlaceOfBirthMinLength = 2;

        ArgumentNullException.ThrowIfNull(surname);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(placeOfBirth);

        surname = surname.Trim();
        name = name.Trim();
        placeOfBirth = placeOfBirth.Trim().ToUpper();

        if (surname.Length < SurnameMinLength)
            throw new ArgumentException("The surname must contain at least 2 letters.");

        if (name.Length < NameMinLength)
            throw new ArgumentException("The name must contain at least 2 letters.");

        if (placeOfBirth.Length < PlaceOfBirthMinLength)
            throw new ArgumentException("The place of birth must contain at least 2 letters.");

        Surname = surname;
        Name = name;
        PlaceOfBirth = placeOfBirth;
        DateOfBirth = dateOfBirth;
        Sex = sex;
    }


}
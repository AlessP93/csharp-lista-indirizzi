
public class Indirizzo
{
    public string Name { get; }
    public string Surname { get; }
    public string Street { get; }
    public string City { get; }
    public string Province { get; }
    public int Zip { get; }

    public Indirizzo(string name, string surname, string street, string city, string province, int zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }   
}
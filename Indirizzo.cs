//Creo una class Indirizzo
public class Indirizzo
{
    public string Name { get; }
    public string Surname { get; }
    public string Street { get; }
    public string City { get; }
    public string Province { get; }
    public int Zip { get; }

    //Costruttore
    public Indirizzo(string name, string surname, string street, string city, string province, int zip)
    {
        this.Name = name;
        this.Surname = surname;
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.Zip = zip;
    }
    public override string ToString()
    {
        string line = "";
        line += "Name: " + this.Name + "\n";
        line += "Surname: " + this.Surname + "\n";
        line += "Street: " + this.Street + "\n";
        line += "City: " + this.City + "\n";
        line += "Province: " + this.Province + "\n";
        line += "ZIP: " + this.Zip + "\n";
        line += "-------------------";

        return line;
    }
}
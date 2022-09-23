using System.Diagnostics.Contracts;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader indirizzi = File.OpenText("../../../addresses.csv");

while (!indirizzi.EndOfStream);
{
    string riga = indirizzi.ReadLine();

    string[] split = riga.Split(",");

    Console.WriteLine(riga);

    try
    {
        string Name = split[0];
        string Surname = split[1];
        string Street = split[2];
        string City = split[3];
        string Province = split[4];
        int Zip = int.Parse(split[5]);
    }
    catch (Exception)
    {
        Console.WriteLine("ciao");
    }
}



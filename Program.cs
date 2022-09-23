
//creo una lista listaIndirizzi
List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

//leggo il file di testo 
StreamReader indirizzi = File.OpenText(@"../../../addresses.csv");

while (!indirizzi.EndOfStream);
{
    string riga = indirizzi.ReadLine(); //scarto la prima riga riga di testo

    string[] split = riga.Split(","); //divido la riga in sezioni ad ogni virgola

    Console.WriteLine(riga); //stampo la riga

    try
    {
        //quando uso split si crea un array [nome,cognome...]
        string Name = split[0];
        string Surname = split[1];
        string Street = split[2];
        string City = split[3];
        string Province = split[4];
        int Zip = int.Parse(split[5]); //Parse = coverte in int32

        //stampo l' indirizzo singolo 
        Indirizzo SingleIndirizzo =  new Indirizzo(Name, Surname, Street, City, Province, Zip);

        //
        listaIndirizzi.Add(SingleIndirizzo);

        Console.WriteLine(SingleIndirizzo);
        indirizzi.ToString();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}



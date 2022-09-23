// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

StreamReader addresses = File.OpenText("addresses.txt");
List<Address> resultList = new List<Address>();
addresses.ReadLine();

while (!addresses.EndOfStream)
{
    //lettura dati come stringa
    string row = addresses.ReadLine();
    //divisione dati prendendo come riferimento virgola
    string[] split = row.Split(',');

    try
    {
        //definisco le variabili

        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        int zip = int.Parse(split[5]);

        Address address = new Address(name, surname, street, city, province, zip);
        resultList.Add(address);

        Console.WriteLine(address);
    }
    catch (Exception e)
    {
        Console.WriteLine("Indirizzo non valido " + row);
    }
    
}
addresses.Close();

try
{
    StreamWriter newAddress = File.CreateText("Formatted Address.txt");

    newAddress.WriteLine("Formatted address with invalid address");

    foreach (Address address in resultList)
    {
        newAddress.WriteLine();
        newAddress.WriteLine(address.ToString());
    }

    newAddress.Close();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

class Address
{
    public string name;
    public string surname;
    public string street;
    public string city;
    public string province; 
    public int zip;

    public Address(string name, string surname, string street, string city, string province, int zip)
    {
        this.name = name;
        this.surname = surname;
        this.street = street;
        this.city = city;
        this.province = province;
        this.zip = zip;
    }

    public string printAddress()
    {
        string text = "------ Address ------\n";
        text += "Name:\t" + this.name + "\n";
        text += "Surname:\t" + this.surname + "\n";
        text += "Street:\t" + this.street + "\n";
        text += "City:\t" + this.city + "\n";
        text += "Province:\t" + this.province + "\n";
        text += "Zip:\t" + this.zip + "\n";
        text += "-------------------";

        return text;
    }
}
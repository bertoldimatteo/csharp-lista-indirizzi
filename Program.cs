// See https://aka.ms/new-console-template for more information

StreamReader file = File.OpenText("../../../addresses.csv");

while (!file.EndOfStream)
{
    string address = file.ReadLine();
    Console.WriteLine(address);
}
file.Close();

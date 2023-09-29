using Week3.Entities;
using Week3.Services;

Product product1 = new ("Product 1", 2.5M, 19.99M);
Product product2 = new ("Product 2", 1.8M, 29.99M);
Product product3 = new ("Product 3", 3.0M, 39.99M);
Product product4 = new ("Product 4", 0.5M, 49.99M);
Product product5 = new ("Product 5", 1.2M, 59.99M);


ShippingService shippingService = new();

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Database\\CountryInfos.txt";
NotepadService notepadService = new();
string[] lines = notepadService.ReadFromNotepad(path).Split("\r\n");

List<CountryInformation> countryInformations = new ();
foreach (var line in lines)
{
    CountryInformation countryInformation = new(line);
}

foreach (var countryInfo in countryInformations)
{
    Console.WriteLine(shippingService.CalculateTax(product5, countryInfo));
}


Console.WriteLine();


// Extendion Methods

int[] numberArray = { 1, 2, 3, 4 };
int maxNumberOfArray = numberArray.Max();
int uniqueMembersCount = numberArray.Distinct().Count();

int secondNumberOfArray =  MyExtensions.ReturnSecondNumberOfArray(numberArray);

string fullName = "Berkcan_Gümüşışık";
fullName.GetLastName();

static class MyExtensions
{
    public static string GetLastName(this string fullName)
    {
        return fullName.Split(" ")[1];
    }
    public static int ReturnSecondNumberOfArray(this int[] array)
    {
        if (array.Length > 1)
            return array[1];
        else
            throw new Exception("Dizide en az 1 eleman olmalıdır");
    }
}
using Week_4.Entities;
using Week_4.Enums;

List<int> numbers = new List<int> { 100,150,160,45 };
bool allItemsGreater = true;
// Klasik foreach döngüsü ile bütün elemanları tek tek kontrol ediyoruz.
foreach (var number in numbers)
{
    if(number <= 50)
    {
        allItemsGreater = false;
        break;
    }
}
Console.WriteLine(allItemsGreater);

// Linq
bool allItemsGreaterLinq = numbers.All(number => number > 40);
Console.WriteLine(allItemsGreaterLinq);



List<User> userList = new List<User>
{
    new User("TravelExploer_", 100),
    new User("FoodAdventures", 100000),
    new User("FitnessFreak101", 170),
    new User("ArtistickSoul", 1000),
    new User("Fashionista", 10000),
};

Console.WriteLine(userList.Any(user => user.FollowerCount > 10000));

List<Person> people = new List<Person>
{
    new Person{FirstName ="Alice", LastName="Smith", Age=30, GenderType= Gender.Female},
    new Person{FirstName ="Bob", LastName="Johnson", Age=25, GenderType= Gender.Male},
    new Person{FirstName ="Charlie", LastName="Smith", Age=40, GenderType= Gender.Male},
    new Person{FirstName ="David", LastName="Wilson", Age=28, GenderType= Gender.Male},
    new Person{FirstName ="Emma", LastName="Lee", Age=35, GenderType= Gender.Female},
    new Person{FirstName ="Frank", LastName="Davis", Age=45, GenderType= Gender.Male},
    new Person{FirstName ="Grace", LastName="Taylor", Age=22, GenderType= Gender.Female},
    new Person{FirstName ="Hannah", LastName="White", Age=32, GenderType= Gender.Female},
    new Person{FirstName ="Issac", LastName="Clark", Age=27, GenderType= Gender.Male},
    new Person{FirstName ="Jack", LastName="Hall", Age=38, GenderType= Gender.Male},
};

List<Person> filterResult = people.Where(person => person.Age < 30 && person.GenderType == Gender.Male).ToList();
foreach (var item in filterResult)
{
    Console.WriteLine(item.FirstName);
}


bool filters = people
    .Where(person => person.Age < 30 )
    .Any(x => x.GenderType == Gender.Male);

Console.WriteLine(filters);


var male = people.Where(x=>x.GenderType == Gender.Male).FirstOrDefault();
Console.WriteLine(male);

var person1 = people.Where(x=>x.FirstName == "Alice").Single();
Console.WriteLine(person1);

var person2 = people.Where(x=>x.FirstName == "Alice").SingleOrDefault();
Console.WriteLine(person2);

List<int> grades = new List<int> { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
var average = grades.Average();
Console.WriteLine(average);

List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };
var distinctAges = ages.Distinct();
foreach (var item in distinctAges)
{
    Console.WriteLine(item);
}

foreach (int grade in grades.Skip(3))
{
    Console.WriteLine(grade);
}

foreach (int grade in grades.Take(3))
{
    Console.WriteLine(grade);
}

int ageSum = ages.Sum();
Console.WriteLine(ageSum);


int ageMax = ages.Max();
Console.WriteLine(ageMax);

int ageMin = ages.Min();
Console.WriteLine(ageMin);

/**
 * Linq => Bizim için bir kolaylık sağlıyor. Tek tek döngü kurmamıza gerek kalmıyor. Sorgu yazıyoruz ve o sorgu sonucunda istediğimiz verileri alabiliyoruz.
 * .All() => Bütün elemanlar için koşulun sağlanıp sağlanmadığını kontrol eder. Bütün elemanlar için koşul sağlanıyorsa true, en az bir eleman için koşul sağlanmıyorsa false döner.
 * .Any() => En az bir eleman için koşulun sağlanıp sağlanmadığını kontrol eder. En az bir eleman için koşul sağlanıyorsa true, hiçbir eleman için koşul sağlanmıyorsa false döner.
 * .Where() => Koşulu sağlayan elemanları getirir. 
 * .First() => İlk elemanı getirir.
 * .FirstOrDefault() => İlk elemanı getirir. Eğer eleman yoksa null döner.
 * .Single() => Tek bir eleman getirir. Eğer birden fazla eleman varsa hata verir.
 * .SingleOrDefault() => Tek bir eleman getirir. Eğer birden fazla eleman varsa null döner.
 * .Average() => Ortalama değeri getirir.
 * .Distinct() => Tekrar eden elemanları siler.
 * .Skip() => Belirtilen sayı kadar elemanı atlar.
 * .Take() => Belirtilen sayı kadar elemanı getirir.
 * .Sum() => Elemanların toplamını getirir.
 * .OrderBy() => Belirtilen özelliğe göre sıralar.
 * .Max() => En büyük elemanı getirir.
 * .Min() => En küçük elemanı getirir.
 */
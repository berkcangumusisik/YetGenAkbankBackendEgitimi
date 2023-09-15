using Week_1.Entities;
using Week_1.Enums;
using Week_1.ValueObject;

Student student1 = new Student(1, "Berkcan", "Gümüşışık");

Student student2 = new Student(2, "Aygün", "Bayram");

Console.WriteLine($"İsim : {student1.Name} Soyisim: {student1.Surname}");
Console.WriteLine($"İsim : {student2.Name} Soyisim: {student2.Surname}");


Storage storage = new Storage("WD Blue", new Capacity(1, CapacitySizeType.TB));
RAM memory = new RAM("Corsair", new Capacity(16, CapacitySizeType.GB));

Computer computer1 = new Computer("Apple", "Macbook Pro", "i7", memory , storage);


Guest guest1 = new Guest("Yeliz", "Akın", "12323423432", "0530 111 2233");
Reservation reservation = new Reservation(guest1, new DateTime(2021, 10, 1), new DateTime(2021, 10, 5));

/**
 * OOP yaklaşımı dilden bağımsızdır. Java ve C# gibi dillerde de kullanılabilir.
 * OOP Kullanma amaçları:
 - Kodun okunabilirliğini arttırmak
 - Kodun tekrar kullanılabilirliğini arttırmak
 - Bakım maaliyetlerinin düşük olması

 Instance : Bir sınıftan türetilen nesne
 Property : Bir nesnenin özellikleridir.
 Constructor : Bir nesne oluşturulduğunda çalışan metoddur. Constructor'lar nesne oluşturulurken parametre alabilir.Yazmasak bile her sınıfın bir constructor'ı vardır. Eğer biz constructor yazarsak default constructor'ı sileriz.

Entity: Her entity için veritabanında bir tablo oluşturulur. Entity'lerin özellikleri veritabanında sütun olarak tutulur.
Entity oluşturan her bir örnek(instance), veri tabanında bulunan tabloların bir satırını temsil eder.
Her entity mutlaka, instancelarını eşsiz kılan bir property'e sahip olmalıdır. Bu property genellikle Id olarak adlandırılır.

Value Object'ler veritabanına tablo olarak yansıtılmazlar.
Value Object'ler tablo sütunlarını, kod tarafında gruplamak için kullanılır.
Value Object'lerin unique bir Id'si olmaz.

 */


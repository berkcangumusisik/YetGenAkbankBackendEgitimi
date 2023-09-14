using YetGenAkbankJumpOOPConsole.Entities;
using YetGenAkbankJumpOOPConsole.Enums;

var student = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Berkcan",
    LastName = "Gümüşışık",
    Gender = Gender.Unknown,
    No = 1,
    RegistrationDate = DateTimeOffset.Now,
    CreatedOn = DateTimeOffset.Now.AddHours(-1),
};

var secondStudent = new Student
{
    Id = Guid.NewGuid(),
    FirstName = "Yakup",
    LastName = "Sıtacı",
    Gender = Gender.Male,
    No = 2,
    RegistrationDate = DateTimeOffset.Now,
    CreatedOn = DateTimeOffset.Now.AddHours(-1),
};
List<Student> students = new List<Student>();
students.Add(student);
students.Add(secondStudent);

students.ForEach(x => Console.WriteLine($"Öğrenci Bilgileri : No - {x.No} {x.FirstName} {x.LastName} {x.Gender}"));

var teacher = new Teacher();
teacher.FirstName = "Berkcan";
teacher.LastName = "Gümüşışık";

Console.WriteLine(teacher.FullName);

teacher.FirstName = "Ahmet";
teacher.LastName = "Kök";

Console.WriteLine(teacher.FullName);
teacher.SayMyName();
teacher.SayMyName();


/**
 *Projeni yapacaksan ya Türkçe ya İngilizce olsun. Ama tavsiye olarak Türkçe yapmanı öneririm.
 *.ForEach() : Bir liste içerisindeki her bir eleman için bir işlem yapmak istiyorsan kullanılır. Tek satırda Linq ile yapılabilir.
 * OOP'de kendini asla tekrar etme ortak alanlar varsa onları grupla. Örneğin; Student ve Teacher classlarında ortak alanlar var. Person classında topladık.
 * Polymorphism : Bir nesnenin birden fazla formu olabilir. Örneğin; Person classı içerisindeki FirstName ve LastName alanları Student ve Teacher classlarında da var. Bu alanlar Person classının bir formudur.
 */
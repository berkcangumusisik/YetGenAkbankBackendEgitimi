using Microsoft.Extensions.Logging;
using System.Security;
using System.Text.Json;
using YetGenAkbankJumpOOPConsole.Common;
using YetGenAkbankJumpOOPConsole.Entities;
using YetGenAkbankJumpOOPConsole.Enums;
using YetGenAkbankJumpOOPConsole.Services;

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

ILogger logger = new Logger<string>(new LoggerFactory());
const string logFilePath = "C:\\Users\\Berk\\Documents\\GitHub\\YetGenAkbankBackendEgitimi\\YetGenAkbankJump\\AccessControlLogs.txt";
var consoleLogger = new ConsoleLogger("");
var fileLogger = new FileLogger(logFilePath);


try
{
    var filePath = "C:\\Users\\Berk\\Documents\\GitHub\\YetGenAkbankBackendEgitimi\\YetGenAkbankJump\\AccessControlLogs.txt";
    var textFile = File.ReadAllText(filePath);

    consoleLogger.LogInfo("Dosya yüklendi.");

    var splittedLines = textFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

    consoleLogger.LogInfo("Dosya satırlara ayrıldı.");

    List<AccesControlLog> logs = new();
    foreach (var splittedLine in splittedLines)
    {
        var values = splittedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

        var accesControlLog = new AccesControlLog()
        {
            Id = Guid.NewGuid(),
            CreateOn = DateTimeOffset.Now,
            PersonId = Convert.ToInt64(values[0]),
            DeviceSerialNo = values[1],
            AccesType = AccesControlLog.ConvertStringToAccesType(values[2]),
            LogTime = Convert.ToDateTime(values[3]),
        };

        logs.Add(accesControlLog);
    }

    consoleLogger.LogSuccess("Loglar oluşturuldu.");

    fileLogger.Log("Dosya yüklendi.");

    consoleLogger.LogSuccess("Loglar json dosyasına yazıldı.");
    fileLogger.LogSuccess("Loglar json dosyasına yazıldı.");

    consoleLogger.LogSuccess("İşlem tamamlandı.");
    fileLogger.LogSuccess("İşlem tamamlandı.");

    
    Console.ReadLine();
}
catch (Exception ex)
{
    consoleLogger.Log(ex.Message);
}

/**
 * File.ReadAllText() : Bir dosyanın içeriğini okumak için kullanılır.
 * .Split() : Bu metot bir string'i parçalamak için kullanılır. İçerisine verdiğimiz parametreye göre parçalar.
 * StringSplitOptions.RemoveEmptyEntries : Bu parametre ile boşlukları kaldırır.
 */


List<object> myObjects = new List<object>();
myObjects.Add(consoleLogger);
myObjects.Add(fileLogger);
foreach (var myObject in myObjects)
{
    if (myObject is LoggerBase)
    {
        var baseLogger = myObject as LoggerBase;
        baseLogger.LogInfo("Ben bir base loggerım");
    }


    
}

decimal finalAmount = 0;
int amount = 68;

finalAmount = amount;


/**
 * Implicit : Veri kaybı olmaz.
 * Explicit : Veri kaybı olabilir.
 */
using Week_2;

new MyEntity();
new MyEntity();
new MyEntity();


Account account = new Account("Mehmet", "Kaya");
//account.Withdraw(2000);
account.Balance -= 1000;
Console.WriteLine(account.Balance);

BaseClass baseClass = new BaseClass();
baseClass.Text = "Merhaba";
baseClass.Print();


DerivedClass derivedClass = new DerivedClass();
derivedClass.Text = "Merhaba";
baseClass.Print();



class MyEntity
{
    public Guid ID { get; set; }
    public MyEntity()
    {
        ID = Guid.NewGuid();
        Console.WriteLine(ID);
    }
}


class BaseClass // Parent - Kalıtım Veren
{
    public string Text { get; set; }
    public void Print()
    {
        Console.WriteLine(Text);
    }
}

class DerivedClass : BaseClass // Child - Kalıtım Alan
{
    public int Number { get; set; } 
}


interface IPrinter
{
    void PrintPage();
}
class  SamsungPrinter : IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("Samsung yazdırılıyor...");
    }
}

class  HpPrinter : IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("HP yazdırılıyor...");
    }
}
/**
 * Guid - Globally Unique Identifier (Türkçe : Evrensel Benzersiz Tanımlayıcı)
 * ID - unique olması gereken bir değer
 * Guid ile oluşturulan değerlerin birbirine benzeme ihtimali yok denecek kadar azdır.
 * Guid.NewGuid() ile yeni bir Guid değeri oluşturulur.
 * ID'leri int olarak tutmak yerine Guid olarak tutmak daha mantıklıdır.
 * 
 Encapculation(Kapsülleme) bize bir nesnenin içerisindeki verileri gizlememizi sağlar. Bu sayede nesnenin içerisindeki verileri sadece nesne üzerinden erişebiliriz ve yanlışlıkla verileri değiştirmemiz engellenir.
 Acces Modifiers 
 - public : Her yerden erişilebilir.
 - private : Sadece tanımlandığı sınıf içerisinden erişilebilir. Hem get hem set edilemez. {get; private set; } ile sadece get edilebilir.

 */
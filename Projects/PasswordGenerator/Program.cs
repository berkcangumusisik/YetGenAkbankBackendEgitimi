using PasswordGenerator;

var passwordGenerator = new PWGenerator();
Console.Write("Lütfen şifrenizde istediğiniz karakter sayısını giriniz: ");
var passwordLenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Şifrenizde sayılar olsun mu? (E/H): ");
var includeNumbers = Console.ReadLine() == "E";

Console.Write("Şifrenizde küçük harfler olsun mu? (E/H): ");
var includeLowerCaseChars = Console.ReadLine() == "E";

Console.Write("Şifrenizde büyük harfler olsun mu? (E/H): ");
var includeUpperCase = Console.ReadLine() == "E";

Console.Write("Şifrenizde özel karakterler olsun mu? (E/H): ");
var includeSpecialChars = Console.ReadLine() == "E";


var password = passwordGenerator.GeneratePassword(passwordLenght, includeNumbers, includeLowerCaseChars, includeUpperCase, includeSpecialChars);

Console.WriteLine($"Şifreniz: {password}");
Console.ReadLine();

return 1;
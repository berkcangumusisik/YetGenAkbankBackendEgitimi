using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJumpOOPConsole.Enums;

namespace YetGenAkbankJumpOOPConsole.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int No { get; set; }
        public Gender Gender { get; set; }
    }
}
/**
 * Guid Tipi : Eşsiz bir değer oluşturur. Bu sayede aynı değeri oluşturmaz. Özellikle tecrübeli yazılımcılar tarafından kullanılır. ID için int kullanılmaz. Dünyada eşsiz olarak yer alır sadece projede değil.
 * int kullanırsak daha hızlı ve kolay olur. Guid kullanırsak daha yavaş ve zor olur. Ayrıca int daha az yer kaplar. Guid daha fazla yer kaplar.
 * TC, Posta Kodu, Telefon Numarası gibi değerlerde String kullanılır. Çünkü bu değerler ülkeden ülkeye değişir. String kullanırsak daha kolay olur.
 * Student classı içinde ID vereceksek StudentID yerine ID yazılır. Çünkü ID zaten Student classının bir parçasıdır.
 * Enum : Birbirine benzeyen değerleri gruplamak için kullanılır. Örneğin; Cinsiyet, Durum, Renk gibi. Enum kullanacağın yerde String kullanma
*/

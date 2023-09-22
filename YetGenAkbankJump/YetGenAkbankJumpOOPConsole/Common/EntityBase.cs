using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreateOn { get; set; }
    }
}

/**
 * Entity Base'i veritabanına göndereceğimiz her şeyde kullanırız.
 * Mesela hepsinde Guid kullanmak istemiyorsam verdiğim veri tipine göre değiştirebilirim.
 * class EntityBase<T> şeklinde yazdığımızda T'ye verdiğimiz veri tipine göre değişir.
 */
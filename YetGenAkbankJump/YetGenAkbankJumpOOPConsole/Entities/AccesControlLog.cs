using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJumpOOPConsole.Common;
using YetGenAkbankJumpOOPConsole.Enums;

namespace YetGenAkbankJumpOOPConsole.Entities
{
    public class AccesControlLog : EntityBase<Guid>
    {
        public long PersonId { get; set; }
        public string DeviceSerialNo { get; set; }
        public AccesType AccesType { get; set; }
        public DateTime LogTime { get; set; }

        public static AccesType ConvertStringToAccesType(string accesType)
        {
            switch (accesType)
            {
                case "FP":
                    return AccesType.FingerPrint;
                    break;
                case "FACE":
                    return AccesType.Face;
                case "CARD":
                    return AccesType.Card;
                default:
                   throw new Exception("CiYuAydi");
            }
        }
    }
}

/** 
 * return ediyorsak kod aşağı doğru devam etmez. Bu yüzden break kullanmaya gerek yok. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1.Enums;

namespace Week_1.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }

        public Computer() 
        {
            Random random = new Random();
            Id = random.Next(10000, int.MaxValue);
        }
        public Computer(string brand, string model):this()
        {
            Brand = brand.ToUpper();
            Model = model;
        }


        public Computer(string brand, string model, string cpu, RAM ram, Storage storage) : this(brand, model)
        {
            
            RAM = ram;
            Storage = storage;
            
        }

        
    }
}

/*
 :this ile constructor'lar arası bağlantı kurulabilir. Bu sayede kod tekrarından kaçınabiliriz.
 */
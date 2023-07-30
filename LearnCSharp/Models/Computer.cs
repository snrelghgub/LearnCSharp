using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Models
{
    class Computer
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }
        public int StorageCapacity { get; set; }
        public Computer(string type, string brand, string model, string processor, int ram, int storageCapacity)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Processor = processor;
            Ram = ram;
            StorageCapacity = storageCapacity;
        }
    }
}

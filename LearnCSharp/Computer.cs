using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Computer
    {
        string Type { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        string Processor { get; set; }
        int Ram     { get; set; }
        int StorageCapacity { get; set; }
        Computer(string type, string brand, string model, string processor, int ram, int storageCapacity)
        {
            this.Type = type;
            this.Brand = brand;
            this.Model = model;
            this.Processor = processor;
            this.Ram = ram;
            this.StorageCapacity = storageCapacity;
        }
    }
}

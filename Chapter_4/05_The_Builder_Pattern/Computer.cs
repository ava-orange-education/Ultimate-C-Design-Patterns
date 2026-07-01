using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._05_The_Builder_Pattern
{
    public class Computer
    {
        public string CPU { get; }
        public string RAM { get; }
        public string Storage { get; }

        private Computer(Builder builder)
        {
            CPU = builder.CPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
        }

        public class Builder
        {
            public string CPU;
            public string RAM;
            public string Storage;

            public Builder WithCPU(string cpu) { CPU = cpu; return this; }
            public Builder WithRAM(string ram) { RAM = ram; return this; }
            public Builder WithStorage(string storage) { Storage = storage; return this; }
            public Computer Build() => new Computer(this);
        }
    }
}

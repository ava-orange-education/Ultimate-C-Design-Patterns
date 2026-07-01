namespace Chapter_4._06_Builder_Pattern_Elevates
{
    public class GamingPC
    {
        public string CPU { get; }
        public string GPU { get; }
        public string RAM { get; }
        public string Storage { get; }

        private GamingPC(Builder builder)
        {
            CPU = builder.CPU;
            GPU = builder.GPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
        }

        public class Builder
        {
            public string CPU;
            public string GPU;
            public string RAM;
            public string Storage;

            public Builder WithCPU(string cpu) { CPU = cpu; return this; }
            public Builder WithGPU(string gpu) { GPU = gpu; return this; }
            public Builder WithRAM(string ram) { RAM = ram; return this; }
            public Builder WithStorage(string storage) { Storage = storage; return this; }

            public GamingPC Build() => new GamingPC(this);
        }
    }
}
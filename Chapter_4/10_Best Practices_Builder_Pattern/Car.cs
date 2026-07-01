namespace Chapter_4._10_Best_Practices_Builder_Pattern
{
    public class Car
    {
        private string v1;
        private string v2;
        private string v3;

        public string Engine { get; }
        public string PaintColor { get; }
        public string Seats { get; }

        private Car(Builder builder)
        {
            Engine = builder.Engine;
            PaintColor = builder.PaintColor;
            Seats = builder.Seats;
        }

        public Car(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public class Builder
        {
            public string Engine;
            public string PaintColor;
            public string Seats;

            public Builder WithEngine(string engine) { Engine = engine; return this; }
            public Builder WithPaintColor(string color) { PaintColor = color; return this; }
            public Builder WithSeats(string seats) { Seats = seats; return this; }
            public Car Build() => new Car(this);
        }
    }
}
namespace Chapter_10._10_Best_Practices_Memento.Size
{
    public class Shape
    {
        public Shape(object type, object position)
        {
            Type = type;
            Position = position;
        }

        public object Position { get; internal set; }
        public object Type { get; internal set; }
    }
}
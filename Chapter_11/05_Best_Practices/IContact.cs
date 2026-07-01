namespace Chapter_11._05_Best_Practices
{
    public interface IContact
    {
        void Accept(IContactVisitor visitor);
    }
}
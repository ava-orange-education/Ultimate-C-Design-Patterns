namespace Chapter_16._02_Common_Antipatterns
{
    public class User
    {
        public bool IsActive { get; internal set; }
        public string Username { get; internal set; }
        public string Email { get; internal set; }
        public object Password { get; internal set; }
        public object Name { get; internal set; }
        public int Id { get; internal set; }
    }
}
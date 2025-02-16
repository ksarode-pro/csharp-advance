namespace Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public GenderDefination Gender { get; set; }
    }

    public enum GenderDefination
    {
        MALE,
        FEMALE,
        TRANSGENDER
    }
}
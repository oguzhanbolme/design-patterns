public class User : UserPrototype
{
    public int id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public override UserPrototype Clone()
    {
        return (UserPrototype)this.MemberwiseClone();
    }
}
public class Admin:Person
{
    public string username;
    public string password;
    public Admin(string n,long p,DateTime d,char g,string u,string pass):base(n,p,d,g)
    {
        username = u;
        password = pass;
    }
    public override void GetDetails()
    {
        base.GetDetails();
        Console.WriteLine("Username: "+username);
    }
}
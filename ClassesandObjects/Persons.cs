public class Person
{
   
    public string Name { get; set; }
    public long Phone { get; set; }
    public DateTime Dob { get; set; }
    public char Gender { get; set; }

    private string description;
    


    public Person(string name, long phone, DateTime dob, char gender)
    {
        Name = name;
        Phone = phone;
        Dob = dob;
        Gender = gender;
    }

   
    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                description = value;
            }
            else
            {
                description = "No description available";
            }
        }
    }

 
    public virtual void GetDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Phone: " + Phone);
        Console.WriteLine("DOB: " + Dob.ToShortDateString());
        Console.WriteLine("Gender: " + Gender);
    }
}

public class Dentist : Person, IMedicine
{
    public int Experience { get; set; }
    private List<string> medicines;

    
    public Dentist(string name, long phone, DateTime dob, char gender, int experience)
        : base(name, phone, dob, gender) 
    {
        Experience = experience;
        medicines = new List<string>(); 
    }

    public void AddMedicine(string medicine)
    {
        medicines.Add(medicine);
        Console.WriteLine("Medicine added by Dentist: " + medicine);
    }

 
    public List<string> GetMedicine()
    {
        return medicines;
    }

    
    public override void GetDetails()
    {
        base.GetDetails();
        Console.WriteLine("Experience: " + Experience);
    }
}

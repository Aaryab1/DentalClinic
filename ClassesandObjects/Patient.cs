public class Patient : Person, IMedicine
{
    public string Disease { get; } 
    private List<string> medicines; 

   
    public Patient(string name, long phone, DateTime dob, char gender, string disease)
        : base(name, phone, dob, gender) 
    {
        this.Disease = disease; 
        medicines = new List<string>(); 
    }

    public override void GetDetails()
    {
        base.GetDetails(); 
        Console.WriteLine("Disease: " + Disease); 
    }

    
    public void AddMedicine(string medicine)
    {
        medicines.Add(medicine); 
        Console.WriteLine("Medicine added to Patient: " + medicine);
    }


    public List<string> GetMedicine()
    {
        return medicines; 
    }
}

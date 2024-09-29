public class CriticalPatient : Patient
{
    public string Criticality { get; }


    public CriticalPatient(string name, long phone, DateTime dob, char gender, string disease, string criticality)
        : base(name, phone, dob, gender, disease) 
    {
        this.Criticality = criticality; 
    }

   
    public override void GetDetails()
    {
        base.GetDetails(); 
        Console.WriteLine("Criticality: " + Criticality); 
    }
}

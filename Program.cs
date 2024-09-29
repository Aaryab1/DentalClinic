Console.WriteLine("//////////////////////Dentist//////////////////////");
var dentist1 = new Dentist("Dr. John Doe", 9876543210, new DateTime(1980, 1, 1), 'M', 10);
dentist1.AddMedicine("ABC");
dentist1.AddMedicine("Gentamycin");
Console.WriteLine("Medicines prescribed by the Dentist:");
foreach (var med in dentist1.GetMedicine())
{
    Console.WriteLine(med);
}

dentist1.GetDetails();


Console.WriteLine("//////////////////////Patient//////////////////////");
var patient1 = new Patient("Alice", 1234567890, new DateTime(1990, 1, 1), 'F', "Cavity");
patient1.AddMedicine("painkiller");
patient1.AddMedicine("antibiotic");
Console.WriteLine("Medicines prescribed to the Patient:");
foreach (var med in patient1.GetMedicine())
{
    Console.WriteLine(med);
}

Console.WriteLine("//////////////////////Critical Patient//////////////////////");

var criticalpatient1 = new CriticalPatient("Bob", 2345678901, new DateTime(1985, 1, 1), 'M', "Heart Disease", "Critical");
criticalpatient1.AddMedicine("aspirin");
criticalpatient1.AddMedicine("paintop");
Console.WriteLine("Medicines prescribed to the Critical Patient:");
foreach (var med in criticalpatient1.GetMedicine())
{
    Console.WriteLine(med);
}

Console.WriteLine("//////////////////////Admin//////////////////////");
var admin1 = new Admin("admin", 123456, new DateTime(1990, 1, 1), 'M', "admin", "admin123");
admin1.GetDetails();

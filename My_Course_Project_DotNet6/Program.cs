// See https://aka.ms/new-console-template for more information
using System.Globalization;

Person person = new Person();

Console.WriteLine("Welcome to the .net6 project course, here we start to collect a person's data");

//Insert Person global data
Console.Write("First name: ");
person.FirstName = Console.ReadLine();
Console.Write("Middle Name (let empty if there is no middle name): ");
person.MiddleName = Console.ReadLine();
Console.Write("Last name: ");
person.LastName = Console.ReadLine();
Console.Write("Date of Birth: ");
string date = Console.ReadLine();
person.BirthDate = DateOnly.Parse(date, CultureInfo.InvariantCulture);
Console.Write("Have a job? (answer true or false): ");
person.EmploymentStatus = Convert.ToBoolean(Console.ReadLine());
if (person.EmploymentStatus == true)
{
    Console.Write("Company name: ");
    person.Company = Console.ReadLine();
    Console.Write("Job Title: ");
    person.Title = Console.ReadLine();
    Console.Write("Salary: ");
    person.Salary = Convert.ToDouble(Console.ReadLine());
}
else person.Salary = 0;

//Insert previous Jobs details
Console.Write("Have Previous jobs? (answer true or false): ");
List<Job> jobs = new List<Job>();
bool booljob = Convert.ToBoolean(Console.ReadLine());
while (booljob)
{
    Job job = new Job();
    Console.Write("Company name: ");
    job.Company = Console.ReadLine();
    Console.Write("Job Title: ");
    job.Title = Console.ReadLine();
    jobs.Add(job);
    Console.Write("Want to add another job? (true or false): ");
    booljob = Convert.ToBoolean(Console.ReadLine());
}
person.Jobs = jobs;

//Insert cars details 
Console.Write("Have any car? (answer true or false): ");
List<Car> cars = new List<Car>();
bool boolcar = Convert.ToBoolean(Console.ReadLine());
while (boolcar)
{
    Car car = new Car();
    Console.Write("Car Manufacturer: ");
    car.Manufacturer = Console.ReadLine();
    Console.Write("Model Name: ");
    car.ModelName = Console.ReadLine();
    cars.Add(car);
    Console.Write("Want to add another car? (answer true or false): ");
    boolcar = Convert.ToBoolean(Console.ReadLine());
}
person.Cars = cars;

//Write the details
Console.WriteLine("\nHere the details you have inserted");
if (string.IsNullOrEmpty(person.MiddleName)) Console.WriteLine("Full name: {0} {1}", person.FirstName, person.LastName);
else Console.WriteLine("Full name: {0} {1} {2}", person.FirstName, person.MiddleName, person.LastName);

Console.WriteLine("Birthdate: {0}", person.BirthDate);
if (person.EmploymentStatus)
{
    Console.WriteLine("Work now as {0} for {1} with a salary of {2}", person.Title, person.Company, person.Salary.ToString());
}

else Console.WriteLine("Without a job");

foreach(Job job in person.Jobs)
{
    Console.WriteLine("Worked as {0} in {1}", job.Title, job.Company);
}
foreach(Car car in person.Cars)
{
    Console.WriteLine("Have {0} car from {1}", car.ModelName, car.Manufacturer);
}
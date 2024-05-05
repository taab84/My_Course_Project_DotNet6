public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateOnly BirthDate { get; set; }
    public bool EmploymentStatus { get; set; }
    public string Company { get; set; }
    public string Title { get; set; }
    public double Salary { get; set; }
    public List<Job> Jobs { get; set; }
    public List<Car> Cars { get; set; }
}


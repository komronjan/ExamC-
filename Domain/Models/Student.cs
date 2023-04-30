namespace Domain.Models;

public class Student : General1
{
    public DateTime BirthDate { get; set; }
    public string Adress { get; set; }

    public Student(int id, string firstName, string lastName, DateTime birthDate, string adress)
    : base(id, firstName, lastName)
    {
        this.BirthDate = birthDate;
        this.Adress = adress;
    }
}

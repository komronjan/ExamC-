namespace Domain.Models;

public class Teacher : General1
{
    public string Position { get; set; }
    public int ExpreienceAmount { get; set; }
    public Teacher(int id, string firstName, string lastName, string position, int experienceAmount)
    : base(id, firstName, lastName)
    {
        this.Position = position;
        this.ExpreienceAmount = experienceAmount;
    }
    
}

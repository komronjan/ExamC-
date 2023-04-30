namespace Domain.Models;

public class  General1
{
    public int Id { get; set; }
    public string   FirstName { get; set; }
    public string   LastName { get; set; }


    public  General1(int id, string firstName,string lastName){
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=lastName;
    }

}

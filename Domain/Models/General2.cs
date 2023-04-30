
namespace Domain.Models;

public class General2
{
    public int Id { get; set; }
    public   string Title { get; set; }
    public string Description  { get; set; }

    public General2(int id, string title, string description)
    {
        this.Id = id;
        this.Title = title;
        this.Description = description;
    }

}
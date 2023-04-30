namespace Domain.Models;

public class Post:General2 {
    public int VoteAmount{ get; set; }
   public  DateTime CreatedAt { get; set; }
    
 public Post(int id, string title, string description,int voteAmount,  DateTime createdAt  )
 :base(id,title,description)
 {
    this.CreatedAt=createdAt;
    this.VoteAmount=voteAmount;
}
}

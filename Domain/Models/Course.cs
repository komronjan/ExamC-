namespace Domain.Models;

public class Course :General2 {
    

public  decimal Fee { get; set; }
 public bool HasDiscount{ get; set; }
 
 
 
 public Course(int id, string title, string description,decimal fee, bool hasDiscount )
 :base(id,title,description)
 {
    this.Fee=fee;
    this.HasDiscount=hasDiscount;
 }
}


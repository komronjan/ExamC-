namespace Infrasturcture.Services;
using Domain.Models;
public class PostServices
{
     List<Post> _post;

    public PostServices()
    {
        _post=new List<Post>();
    }
    public List<Post> GetPosts(){
        return _post;
    }
    public void AddPost( Post post){
        
        _post.Add(post);
    }
     public void UpdatePost(Post post,int id){
        foreach (var pt in _post)
        {
            if(pt.Id==id){
              pt.CreatedAt=post.CreatedAt;
              pt.Description=post.Description;
              pt.Title=post.Title;
              pt.VoteAmount=post.VoteAmount;
            }
        }
    }
      public void Delete(int id){
        foreach (var post in _post )
        {
            if (post.Id==id){
                _post.Remove(post);
                break;
            }
        }
    }

}

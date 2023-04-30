namespace Infrasturcture.Services;
using Domain.Models;

public class TeacherServices
{
    
    List<Teacher> _teacher;

    public TeacherServices()
    {
        _teacher=new List<Teacher>();
    }
    public List<Teacher> GetTeachers(){
        return _teacher;
    }
    public void AddTeaher(Teacher teacher){
        
        _teacher.Add(teacher);
    }
     public void UpdateTeacher(Teacher teacher,int id){
        foreach (var tr in _teacher)
        {
            if(tr.Id==id){
               tr.FirstName=teacher.FirstName;
               tr.LastName=teacher.LastName;
               tr.Position=teacher.Position;
               tr.ExpreienceAmount=teacher.ExpreienceAmount;
            }
        }
    }
      public void Delete(int id){
        foreach (var teacher in _teacher )
        {
            if (teacher.Id==id){
                _teacher.Remove(teacher);
                break;
            }
        }
    }
}

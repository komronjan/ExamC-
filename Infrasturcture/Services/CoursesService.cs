namespace Infrasturcture.Services;
using Domain.Models;
public class CoursesService
{
      List<Course> _course;
    public CoursesService()
    {
        _course=new List<Course>();
    }
    public List<Course> GetCourses(){
        return _course;
    }
    public void AddCourse( Course course){
        
        _course.Add(course);
    }
    public void UpdateCourse(Course course,int id){
         foreach (var cousr in _course)
        {
            if(cousr.Id==id){
              cousr.HasDiscount=course.HasDiscount;
              cousr.Description=course.Description;
              cousr.Title=course.Title;
              cousr.Fee=course.Fee;
            }
        }
    }
    public void Delete(int id){
        foreach (var course in _course )
        {
            if (course.Id==id){
                _course.Remove(course);
                break;
            }
        }
    }

}

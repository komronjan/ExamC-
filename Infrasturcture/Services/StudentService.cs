namespace Infrasturcture.Services;
using Domain.Models;
public class StudentService
{
    List<Student> _student;

    public StudentService()
    {
        _student=new List<Student>();
    }
    public List<Student> GetStudents(){
        return _student;
    }
    public void AddStudent( Student student){
        
        _student.Add(student);
    }
    public void UpdateStudent(Student student,int id){
        foreach (var st in _student)
        {
            if(st.Id==id){
                st.FirstName=student.FirstName;
                st.LastName=student.LastName;
                st.BirthDate=student.BirthDate;
                st.Adress=student.Adress;
            }
        }
    }
    public void Delete(int id){
        foreach (var student in _student )
        {
            if (student.Id==id){
                _student.Remove(student);
                break;
            }
        }
    }


}

namespace MVC_crud.Models.Entities;
//Adding Entities folder under Models, creating all classes need for the project
public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool Subscribed { get; set; }
    public Student()
    {
    }
}
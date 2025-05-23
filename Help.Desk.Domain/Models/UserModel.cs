using Help.Desk.Domain.Models.Common;

namespace Help.Desk.Domain.Models;

public class UserModel: BaseModel
{
    public UserModel(int id, string name, string lastName, string phoneNumber, string email, string password, int departmentId, string role, bool active) : base(id)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Password = password;
        DepartmentId = departmentId;
        Role = role;
        Active = active;
    }

    public string Name {get; set;}
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int DepartmentId { get; set; }
    public string Role { get; set; }
    public bool Active { get; set; }
    
    public void ActivateUser()=> Active = true;
    public void DeactivateUser()=> Active = false;
}
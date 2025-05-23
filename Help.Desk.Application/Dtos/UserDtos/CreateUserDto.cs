namespace Help.Desk.Application.Dtos.UserDtos;

public class CreateUserDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int DepartmentId { get; set; }
    public string Role { get; set; }
}
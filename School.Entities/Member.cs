namespace School.Entities;

public abstract class Member
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required string Address { get; set; }
}

public class Teacher : Member
{
        
}

public class Student : Member
{
    
}

class Class
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required ClassLevel Level { get; set; }

}

public enum ClassLevel
{
    FirstYear,
    SecondYear,
    ThirdYear,
}
namespace BlazorTraining.Model
{
    public class Student
    {
        public Student(int id, string name, string lastName, int age, bool isActive)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}

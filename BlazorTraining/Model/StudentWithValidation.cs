using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorTraining.Model
{
    public class StudentWithValidation
    {
        public StudentWithValidation()
        {

        }
        public StudentWithValidation(int id, string name, string lastName, int age, bool isActive)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            IsActive = isActive;
        }

        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last name is too short")]
        public string LastName { get; set; }

        [Required]
        public Sex Sex { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Range(1, 100, ErrorMessage = "Age should be between 1 and 100")]
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }

    public enum Sex
    {
        Male, Female
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Номер курса")]
        [Required(ErrorMessage = "Введите номер курса")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Предмет")]
        [Required(ErrorMessage = "Введите название предмета")]
        public string Title { get; set; }

        [Range(0, 5)]
        [Display(Name = "Кредиты")]
        [Required(ErrorMessage = "Введите кредиты")]
        public int Credits { get; set; }

        [Display(Name = "Отделение")]
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        [StringLength(50)]
        [Display(Name = "Имя")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Введите фамилию")]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "Фамилия")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Введите дату")]
        [Display(Name = "Дата поступления")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Полное имя")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
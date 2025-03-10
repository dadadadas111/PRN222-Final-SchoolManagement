using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Selected { get; set; }
        [Unique]
        public string KeyId { get; set; }
        public string Qualification { get; set; }
        public int YearsOfEx { get; set; }
        public ICollection<AssignGrade> AssignGrades { get; set; }  
        public ICollection<TeacherSession> TeacherSessions { get; set; }
    }
}

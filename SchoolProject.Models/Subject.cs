using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public ICollection<GradeSubject> GradeSubjects { get; set; }
    }
}

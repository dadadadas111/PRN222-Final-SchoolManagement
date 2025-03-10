using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Enroll
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        [NotMapped]
        public Student? Student { get; set; }
        public int? SessionId { get; set; }
        [NotMapped]
        public Session? Session { get; set; }
        public int? GradeId { get; set; }
        [NotMapped]
        public Grade? Grade { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public ICollection<TeacherSession> TeacherSessions { get; set; } = new HashSet<TeacherSession>();
        public ICollection<Enroll> Enrollment { get; set; } = new HashSet<Enroll>();
    }
}

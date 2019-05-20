using System;
using System.Collections.Generic;

namespace CRUD2.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Student1 { get; set; }
        public int? Class { get; set; }
        public DateTime? Date { get; set; }
    }
}

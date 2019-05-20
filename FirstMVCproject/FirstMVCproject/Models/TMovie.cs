using System;
using System.Collections.Generic;

namespace FirstMVCproject.Models
{
    public partial class TMovie
    {
        public int Id { get; set; }
        public string Actor { get; set; }
        public string Actoress { get; set; }
        public string Movie { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}

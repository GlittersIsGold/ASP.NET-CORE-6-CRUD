using System;
using System.Collections.Generic;

namespace Dairy.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Created { get; set; } = null!;
        public string Updated { get; set; } = null!;
    }
}

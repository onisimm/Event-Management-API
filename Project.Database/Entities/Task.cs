using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? DueDate { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}


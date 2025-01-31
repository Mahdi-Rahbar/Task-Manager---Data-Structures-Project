using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }

        public Task(string name, string description, DateTime deadline, string status)
        {
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
        }
    }
}

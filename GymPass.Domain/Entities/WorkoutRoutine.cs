using System;
using System.Collections.Generic;
using System.Text;

namespace GymPass.Domain.Entities
{
    public class WorkoutRoutine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Client> Clients { get; set; }
        public ICollection<SubRoutine> SubRoutines { get; set; }
        public WorkoutRoutine()
        {
            Clients = new HashSet<Client>();
            SubRoutines = new HashSet<SubRoutine>();
        }
    }
}

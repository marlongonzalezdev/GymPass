using System;
using System.Collections.Generic;
using System.Text;

namespace GymPass.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public WorkoutRoutine WorkoutRoutine { get; set; }

        public Client()
        {
            Payments = new HashSet<Payment>();
        }
    }
}

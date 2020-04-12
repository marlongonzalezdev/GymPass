using System;
using System.Collections.Generic;
using System.Text;

namespace GymPass.Domain.Entities
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public Equipment Equipment { get; set; }
    }
}

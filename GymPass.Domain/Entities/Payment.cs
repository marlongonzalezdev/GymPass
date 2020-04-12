using System;
using System.Collections.Generic;
using System.Text;

namespace GymPass.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Client Client { get; set; }
        public PaymentPeriod PaymentPeriod { get; set; }
    }
}

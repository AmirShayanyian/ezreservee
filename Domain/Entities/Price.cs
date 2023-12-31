using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Price : BaseEntity
    {
        public Decimal Amount;
        public string PaymentType;
        public DateOnly PaymentDate;
    }
}

using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket:BaseEntity
    {
        public string TicketNr { get; set; } = null!;
        public Decimal Price { get; set; }
        public string SeatNr { get; set; } = string.Empty;
        public TicketStatus Status { get; set; }

        public Concert Concert { get; set; } 

    }

 
}

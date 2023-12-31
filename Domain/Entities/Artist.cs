using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Artist
    {
        public string UserName { get; set; } = string.Empty;
        public Genre Genre { get; set; } = default;
        public List<Concert> ConcertList { get; set; } = new();
    }
}
